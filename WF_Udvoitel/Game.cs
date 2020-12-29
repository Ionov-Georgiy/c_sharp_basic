using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Udvoitel
{
    public partial class Game : Form
    {

        Doubler dbGame = new Doubler();
        private delegate void MakeStepF();

        public Game()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.IsAccessible = true;
            this.Owner.Visible = true;
        }

        private void buttonPlus1_Click(object sender, EventArgs e)
        {
            MakeStepF func = dbGame.AddOneToValue;
            MakeStep(func);
        }
        private void MakeStep(MakeStepF func)
        {
            if (!dbGame.IsTargetAchived)
            {
                func();
            }
            if(dbGame.IsTargetAchived)
            {
                if (dbGame.IsWin)
                {
                    MessageBox.Show("Вы победили!\nКоличество шагов: " + dbGame.CurrentStep + "\nМаксимальное количество шагов: " + dbGame.MaxSteps);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Вы проиграли!\nКоличество шагов: " + dbGame.CurrentStep + "\nМаксимальное количество шагов: " + dbGame.MaxSteps);
                    this.Close();
                }
            }
            RefreshForm();
        }

        private void RefreshForm()
        {
            this.Target.Text = dbGame.TargetValue.ToString();
            this.CurrentValue.Text = dbGame.CurrentValue.ToString();
            this.MaxSteps.Text = dbGame.MaxSteps.ToString();
            this.CurrentStep.Text = dbGame.CurrentStep.ToString();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            MakeStepF func = dbGame.DoubleValue;
            MakeStep(func);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            MakeStepF func = dbGame.Cancel;
            MakeStep(func);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            MakeStepF func = dbGame.Start;
            MakeStep(func);
        }
    }
}
