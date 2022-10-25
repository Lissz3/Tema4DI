namespace Ex2
{
	public partial class FrmColor : Form
	{
		public FrmColor()
		{
			InitializeComponent();
		}

		private void btnColor_Click(object sender, EventArgs e)
		{
			ChangeColor();
		}

		void ChangeColor()
		{
			bool problem = false;
			if (int.TryParse(txbR.Text, out int R) && R < 255 && R >= 0)
			{
				lblR.ForeColor = Color.Red;
				problem = true;
			}
			if (int.TryParse(txbG.Text, out int G) && G < 255 && G >= 0)
			{
				lblG.ForeColor = Color.Red;
				problem = true;
			}
			if (int.TryParse(txbB.Text, out int B) && B < 255 && B >= 0)
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

		private void txb_Enter(object sender, EventArgs e)
		{
			ChangeColor();
		}

		private void txb_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ChangeColor();
			}
		}
	}
}