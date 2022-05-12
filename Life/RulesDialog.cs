using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Life
{
    public partial class RulesDialog : Form
    {
        public LifeGameRulesCustom Rules { get; set; }

        public RulesDialog(LifeGameRulesCustom rules)
        {
            InitializeComponent();

            for (int i = 1; i < 10; i++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / 10));
            }
            for (int i = 0; i < 6; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / 6));
            }
            Rules = rules;
            UpdateButtons();
        }

        private void ChangeStateButtonClick(object sender, EventArgs e)
        {
            ((Button)sender).SB_Switch();
        }

        private void UpdateButtons()
        {
            AliveButton0.SB_SetChanges(Rules.AliveChanges[0]);
            AliveButton1.SB_SetChanges(Rules.AliveChanges[1]);
            AliveButton2.SB_SetChanges(Rules.AliveChanges[2]);
            AliveButton3.SB_SetChanges(Rules.AliveChanges[3]);
            AliveButton4.SB_SetChanges(Rules.AliveChanges[4]);
            AliveButton5.SB_SetChanges(Rules.AliveChanges[5]);
            AliveButton6.SB_SetChanges(Rules.AliveChanges[6]);
            AliveButton7.SB_SetChanges(Rules.AliveChanges[7]);
            AliveButton8.SB_SetChanges(Rules.AliveChanges[8]);

            DeadButton0.SB_SetChanges(Rules.DeadChanges[0]);
            DeadButton1.SB_SetChanges(Rules.DeadChanges[1]);
            DeadButton2.SB_SetChanges(Rules.DeadChanges[2]);
            DeadButton3.SB_SetChanges(Rules.DeadChanges[3]);
            DeadButton4.SB_SetChanges(Rules.DeadChanges[4]);
            DeadButton5.SB_SetChanges(Rules.DeadChanges[5]);
            DeadButton6.SB_SetChanges(Rules.DeadChanges[6]);
            DeadButton7.SB_SetChanges(Rules.DeadChanges[7]);
            DeadButton8.SB_SetChanges(Rules.DeadChanges[8]);
        }

        private void ApplyRules()
        {
            Rules.SetChangesArray(true, new bool[]
            {
                AliveButton0.SB_Changes(),
                AliveButton1.SB_Changes(),
                AliveButton2.SB_Changes(),
                AliveButton3.SB_Changes(),
                AliveButton4.SB_Changes(),
                AliveButton5.SB_Changes(),
                AliveButton6.SB_Changes(),
                AliveButton7.SB_Changes(),
                AliveButton8.SB_Changes(),
            });
            Rules.SetChangesArray(false, new bool[]
            {
                DeadButton0.SB_Changes(),
                DeadButton1.SB_Changes(),
                DeadButton2.SB_Changes(),
                DeadButton3.SB_Changes(),
                DeadButton4.SB_Changes(),
                DeadButton5.SB_Changes(),
                DeadButton6.SB_Changes(),
                DeadButton7.SB_Changes(),
                DeadButton8.SB_Changes(),
            });
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            ApplyRules();
            DialogResult = DialogResult.OK;
            Close();
        }
    }

    internal static class StateButton
    {
        public static bool SB_Changes(this Button btn)
        {
            return (bool)btn.Tag;
        }

        public static void SB_SetChanges(this Button btn, bool changes)
        {
            btn.Tag = changes;
            btn.BackColor = changes ? Color.Red : Color.Green;
            if (changes)
            {
                btn.Text = "Switch";
            }
            else
            {
                btn.Text = "Stay";
            }
        }

        public static void SB_Switch(this Button btn)
        {
            btn.SB_SetChanges(!btn.SB_Changes());
        }
    }
}
