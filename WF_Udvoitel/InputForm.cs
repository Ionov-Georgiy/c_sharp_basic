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
    public partial class InputForm : Form
    {

        private int inputValue;

        public InputForm()
        {
            InitializeComponent();
        }

        private void InputValue_TextChanged(object sender, EventArgs e)
        {
            int result = 0;
            bool condition = Int32.TryParse(this.InputValue.Text, out result);
            if (condition && result >= 1 && result <= 100)
            {
                inputValue = result;
            }
            else
            {
                MessageBox.Show("Необходимо вводить целочисленные значения не более 100 и не менее 1!", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.InputValue.Text = inputValue.ToString();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            GuessNumber owFormCs = Owner as GuessNumber;
            owFormCs.NumberToTry = inputValue;
            this.Close();
        }

        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.IsAccessible = true;
        }
    }
}
