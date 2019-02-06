using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = new int();
            Task t1 = new Task(() =>
            {
                long i = 1000000000;

                while (i > 1)
                {
                    sum = sum + 1;
                    i--;
                }
            });

            Task T2 = t1.ContinueWith((antecedent) =>
            {
                //s.ToString().Split('\n');
                listBox1.Items.Insert(0, sum);
            },
            TaskScheduler.FromCurrentSynchronizationContext());
            t1.Start();

        }
    }
}
