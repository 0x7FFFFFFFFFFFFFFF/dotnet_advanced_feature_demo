using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResponsibleWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SlowTask();
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            await Task.Run(() => SlowTask2());
        }

        public void SlowTask()
        {
            result.Text = "Start the slow task.";
            Thread.Sleep(8000);
            result.Text = result.Text + Environment.NewLine + "Slow task down.";
        }

        public void SlowTask2()
        {
            result.Text = "Start the slow task.";
            Thread.Sleep(8000);
            result.Text = result.Text + Environment.NewLine + "Slow task down.";
        }
    }
}
