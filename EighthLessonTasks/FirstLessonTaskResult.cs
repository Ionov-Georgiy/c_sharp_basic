using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeventhLessonTasks
{
    public partial class FirstLessonTaskResult : Form
    {
        public FirstLessonTaskResult()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FirstLessonTaskResult_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.IsAccessible = true;
        }
    }
}
