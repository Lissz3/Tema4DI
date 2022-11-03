using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex6
{
	public partial class Form2 : Form
	{
		int cont = 3;
		readonly string pin = "1234";
		public Form2()
		{
			InitializeComponent();

		}

		private void txbPin_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				if (txbPin.Text == pin)
				{
					DialogResult = DialogResult.OK;
				}
				else
				{
					cont--;
					lblTrys.Text = "Intentos: " + cont;
					if (cont == 0)
					{
						DialogResult = DialogResult.Abort;
					}
				}
			}
		}


	}
}
