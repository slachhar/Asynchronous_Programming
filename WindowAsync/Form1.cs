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
			long i = 10000000;
			while(i>1)
			{
				listBox1.Items.Add("Accepted");
				i--;
			}
			listBox1.Items.Add("Rejected");
		}
	}
}
