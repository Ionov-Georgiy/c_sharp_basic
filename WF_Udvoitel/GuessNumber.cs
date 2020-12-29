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
    public partial class GuessNumber : Form
    {

        TryGuess ngTryGuess;

        public int NumberToTry
        {
            get { return numberToTry; }
            set
            {
                numberToTry = value; 
                MakeATry();
            }
        }
        private int numberToTry { get; set; }

        public GuessNumber()
        {
            InitializeComponent();
        }

        private void buttonGenerateSecretNumber_Click(object sender, EventArgs e)
        {
            StartNG();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GuessNumber_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.IsAccessible = true;
            this.Owner.Visible = true;
        }

        private void StartNG()
        {
            this.IsSecretNumberExist.Text = "Число загадано";
            this.IsSecretNumberExist.ForeColor = Color.Green;
            ngTryGuess = new TryGuess();
        }

        private void MakeATry()
        {
            if (ngTryGuess.Try(numberToTry))
            {
                if (ngTryGuess.CheckLoss())
                {
                    this.StatusOfTry.Text = "Поражение!\nПопыток сделано:" + ngTryGuess.CurrentTries + "\nМаксимум попыток:" + ngTryGuess.MaxSteps;
                    this.StatusOfTry.ForeColor = Color.Red;
                }
                else
                {
                    this.StatusOfTry.Text = "Победа!";
                    this.StatusOfTry.ForeColor = Color.Green;
                }
            }
            else
            {
                if (ngTryGuess.CheckLoss())
                {
                    this.StatusOfTry.Text = "Поражение!\nПопыток сделано: " + ngTryGuess.CurrentTries + "\nМаксимум попыток: " + ngTryGuess.MaxSteps;
                    this.StatusOfTry.ForeColor = Color.Red;
                    return;
                }
                if (ngTryGuess.IsMoreThanSecret(numberToTry))
                {
                    this.StatusOfTry.Text = numberToTry.ToString() + " больше загаданного";
                    this.StatusOfTry.ForeColor = Color.Blue;
                }
                else
                {
                    this.StatusOfTry.Text = numberToTry.ToString() + " менее загаданного";
                    this.StatusOfTry.ForeColor = Color.Orange;
                }
            }
            
        }

        private void buttonTryGuess_Click(object sender, EventArgs e)
        {
            if (ngTryGuess == null)
            {
                MessageBox.Show("Необходимо сначала загадать число!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.IsAccessible = false;
            InputForm inputForm = new InputForm();
            inputForm.Show(this);
        }
    }
}
