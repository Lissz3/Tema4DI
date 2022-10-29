namespace Ex3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnNewImage_Click(object sender, EventArgs e)
		{
			var filePath = string.Empty;

			oflSelect.Title = "Selector de imagen";
			oflSelect.InitialDirectory = "c:\\";
			oflSelect.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
			oflSelect.ValidateNames = true;
			oflSelect.RestoreDirectory = true;

			if (oflSelect.ShowDialog() == DialogResult.OK)
			{
				filePath = oflSelect.FileName;
			}

			Form2 f2 = new(filePath);

			if (cbxModal.Checked)
			{
				
				DialogResult res = f2.ShowDialog();
				if (res == DialogResult.Cancel)
				{
					f2.Close();
				}

			}
			else
			{
				f2.Show();
			}


		}

		private void cbxModal_CheckedChanged(object sender, EventArgs e)
		{
			if (cbxModal.Checked)
			{
				cbxModal.ForeColor = Color.Red;
			}
			else
			{
				cbxModal.ForeColor = DefaultForeColor;
			}
		}
	}
}