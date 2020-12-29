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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Game form = new Game();
            this.Visible = false;
            this.IsAccessible = false;
            form.Show(this);
        }

        private void buttonGuessNumber_Click(object sender, EventArgs e)
        {
            GuessNumber form = new GuessNumber();
            this.Visible = false;
            this.IsAccessible = false;
            form.Show(this);
        }
    }
}
