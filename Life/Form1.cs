namespace Life
{
    public partial class Form1 : Form
    {
        public Color AliveColorNext { get; private set; }
        public Color DeadColorNext { get; private set; }
        public LifeGameRules Rules { get; set; }

        public bool IsStarted { get => UpdateTimer.Enabled; private set => UpdateTimer.Enabled = value; }

        public LifeGameWinforms? Game { get; private set; }

        public Form1()
        {
            InitializeComponent();
            AliveColorNext = Color.FromArgb(192, 0, 0);
            DeadColorNext = Color.Black;
            Rules = LifeGameRulesPresets.Default;
            SelectRulesDropDown.SelectedIndex = 0;
        }

        private void ImageUpdateTick(object sender, EventArgs e)
        {
            if (Game is not null)
            {
                Game.NextGeneration();
                MainCanvas.Refresh();
                Text = $"Conway's Game of Life | Generation {Game.Generation}";
            }
        }

        private void ColorAliveClick(object sender, EventArgs e)
        {
            Color? color = ChangeButtonColor((Button)sender);
            if (color is not null)
            {
                AliveColorNext = color ?? Color.Black;
                if (Game is not null)
                {
                    Game.AliveColor = AliveColorNext;
                }
            }
        }

        private void ColorDeadClick(object sender, EventArgs e)
        {
            Color? color = ChangeButtonColor((Button)sender);
            if (color is not null)
            {
                DeadColorNext = color ?? Color.Black;
                if (Game is not null)
                {
                    Game.DeadColor = DeadColorNext;
                }
                MainCanvas.BackColor = color ?? Color.Black;
            }
        }

        private Color? ChangeButtonColor(Button btn)
        {
            if (MainColorDialog.ShowDialog() != DialogResult.OK)
            {
                return null;
            }
            btn.ForeColor = MainColorDialog.Color;
            return MainColorDialog.Color;
        }

        private void CreateButtonClick(object sender, EventArgs e)
        {
            int cellSize = (int)CellSizeUpDown.Value;
            Game = new(MainCanvas.Width / cellSize, MainCanvas.Height / cellSize, Rules, cellSize, AliveColorNext, DeadColorNext);
            Game.GenerateRandom((int)FrequencyUpDown.Value, (int)FrequencyUpDown.Maximum);
            MainCanvas.Image?.Dispose();
            MainCanvas.Image = Game.ResizedBitmap;
            UpdateTimer.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Game is not null)
            {
                UpdateTimer.Start();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
        }

        private void MainCanvasDraw(object sender, MouseEventArgs e)
        {
            if (Game is not null && e.Button != MouseButtons.None)
            {
                int x = e.Location.X / Game.CellSize;
                int y = e.Location.Y / Game.CellSize;
                Game.SetCellAndDraw(x, y, e.Button == MouseButtons.Left);
                MainCanvas.Refresh();
            }
        }

        private void ChangeRulesButton_Click(object sender, EventArgs e)
        {
            if (Rules is LifeGameRulesCustom rules)
            {
                RulesDialog dialog = new(rules);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SelectRulesDropDown.SelectedIndex = 5;
                    SetRules(rules);
                }
            }
            else
            {
                MessageBox.Show("This rules can not be modified");
            }
        }

        private void SelectRulesDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (SelectRulesDropDown.SelectedIndex)
            {
                case 0:
                    SetRules(LifeGameRulesPresets.Default);
                    break;
                case 1:
                    SetRules(LifeGameRulesPresets.DayAndNight);
                    break;
                case 2:
                    SetRules(LifeGameRulesPresets.HighLife);
                    break;
                case 3:
                    SetRules(LifeGameRulesPresets.LifeWithoutDeath);
                    break;
                case 4:
                    SetRules(LifeGameRulesPresets.Seeds);
                    break;
            }
        }

        private void SetRules(LifeGameRules rules)
        {
            Rules = rules;
            if (Game is not null)
            {
                Game.Rules = Rules;
            }
        }
    }
}