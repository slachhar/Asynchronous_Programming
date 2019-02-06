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
			StringBuilder s = new StringBuilder();
			Task t1 = new Task(() =>
			{
				long i = 100000;
				
				while (i > 1)
				{
					s.Append("Accepted");
					s.Append("\n");
					i--;
				}
			});

			Task T2 = t1.ContinueWith((antecedent) => {
				listBox1.Items.Add(s);
				listBox1.Items.Add("Rejected");
			},
			TaskScheduler.FromCurrentSynchronizationContext());
			t1.Start();

		}
	}
}
