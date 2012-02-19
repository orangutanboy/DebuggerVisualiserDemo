using System;
using System.Windows.Forms;

namespace VisualiserDemo
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void doStuffButton_Click(object sender, EventArgs e)
        {
            var demoObject = new DemoObject();
            System.Diagnostics.Debugger.Break();
        }
    }
}
