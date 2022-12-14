using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;

namespace Ex2
{

	public partial class FrmColor : Form
	{
		readonly string title = "ColorShifter";
		public FrmColor()
		{
			InitializeComponent();
			CancelButton = btnExit;
		}

		private void BtnColor_Click(object sender, EventArgs e)
		{
			ChangeColor();
		}

		void ChangeColor()
		{
			bool problem = false;
			if (!int.TryParse(txbR.Text, out int R) || R > 255 || R < 0)
			{
				lblR.ForeColor = Color.Red;
				problem = true;
			}
			if (!int.TryParse(txbG.Text, out int G) || G > 255 || G < 0)
			{
				lblG.ForeColor = Color.Red;
				problem = true;
			}
			if (!int.TryParse(txbB.Text, out int B) || B > 255 || B < 0)
			{
				lblB.ForeColor = Color.Red;
				problem = true;
			}

			if (!problem)
			{
				BackColor = Color.FromArgb(R, G, B);
				lblR.ForeColor = DefaultForeColor;
				lblG.ForeColor = DefaultForeColor;
				lblB.ForeColor = DefaultForeColor;
			}

		}

		private void Txb_Enter(object sender, EventArgs e)
		{
			ChangeColor();
		}




		private void MyFormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Do you want to close?", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Btns_MouseEnter(object sender, EventArgs e)
		{
			((Button)sender).BackColor = Color.DodgerBlue;
		}

		private void Btns_MouseLeave(object sender, EventArgs e)
		{
			((Button)sender).BackColor = DefaultBackColor;
		}

		void LoadImage(string path)  //Excepcion
		{
			try
			{
				pbxImage.Image = new Bitmap(path);
			}
			catch (ArgumentException)
			{
				lblPath.ForeColor = Color.Red;
			}
		}

		private void BtnLoad_Click(object sender, EventArgs e)
		{
			if (txbPath.Text != "")
			{
				LoadImage(txbPath.Text);
			}
		}

		private void MyEnter(object sender, EventArgs e)
		{
			if (sender == txbR || sender == txbG || sender == txbB)
			{
				AcceptButton = btnColor;

			} else if ( sender == txbPath)
			{
				AcceptButton = btnLoad;
			}
		}
	}
}