namespace Life
{
    public partial class Form1 : Form
    {
        public Color AliveColorNext { get; private set; }
        public Color DeadColorNext { get; private set; }

        public bool IsStarted { get => UpdateTimer.Enabled; private set => UpdateTimer.Enabled = value; }

        public LifeGameWinforms? Map { get; private set; }

        public Form1()
        {
            InitializeComponent();
            AliveColorNext = Color.FromArgb(192, 0, 0);
            DeadColorNext = Color.Black;
        }

        private void ImageUpdateTick(object sender, EventArgs e)
        {
            if (Map is not null)
            {
                Map.NextGeneration();
                MainCanvas.Invoke(() => MainCanvas.Refresh());
            }
        }

        private void ColorAliveClick(object sender, EventArgs e)
        {
            Color? color = ChangeButtonColor((Button)sender);
            if (color is not null)
            {
                AliveColorNext = color ?? Color.Black;
                if (Map is not null)
                {
                    Map.AliveColor = AliveColorNext;
                }
            }
        }

        private void ColorDeadClick(object sender, EventArgs e)
        {
            Color? color = ChangeButtonColor((Button)sender);
            if (color is not null)
            {
                DeadColorNext = color ?? Color.Black;
                if (Map is not null)
                {
                    Map.DeadColor = DeadColorNext;
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
            Map = new(MainCanvas.Width / cellSize, MainCanvas.Height / cellSize, cellSize, AliveColorNext, DeadColorNext);
            Map.GenerateRandom((int)FrequencyUpDown.Value, (int)FrequencyUpDown.Maximum);
            MainCanvas.Image?.Dispose();
            MainCanvas.Image = Map.ResizedBitmap;
            UpdateTimer.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (Map is not null)
            {
                UpdateTimer.Start();
            }
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            UpdateTimer.Stop();
        }

        private void MainCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (Map is not null && e.Button != MouseButtons.None)
            {
                int x = e.Location.X / Map.CellSize;
                int y = e.Location.Y / Map.CellSize;
                Map.SetCellAndDraw(x, y, e.Button == MouseButtons.Left);
                MainCanvas.Refresh();
            }
        }
    }
}