using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SeventhLessonTasks
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonFirstTask_Click(object sender, EventArgs e)
        {
            Assembly asmbl = Assembly.LoadFrom("FirstTask.dll");
            Type tpOfCls = asmbl.GetType("FirstTask.Program", true);
            object obj = Activator.CreateInstance(tpOfCls);
            MethodInfo mf = tpOfCls.GetMethod("Main", BindingFlags.NonPublic | BindingFlags.Static);
            object cnslTxt = mf.Invoke(obj, new object[] { new string[] { } });
            FirstLessonTaskResult fsltRForm = new FirstLessonTaskResult();
            fsltRForm.textBoxFirstTaskResult.Text = cnslTxt.ToString();
            IsAccessible = false;
            fsltRForm.Show(this);
        }
    }
}
