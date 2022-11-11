#nullable disable

using System.IO;

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
			btnNewImage.ForeColor = DefaultForeColor;

			oflSelect.Title = "Selector de imagen";
			oflSelect.InitialDirectory = "c:\\";
			oflSelect.Filter = "jpg files (*.jpg)|*.jpg|png files (*.png)|*.png|All files (*.*)|*.*";
			oflSelect.ValidateNames = true;
			oflSelect.RestoreDirectory = true;
			Form2 f2 = null;

			if (oflSelect.ShowDialog() == DialogResult.OK)
			{
				filePath = oflSelect.FileName;
				f2 = new();
				f2.Text = filePath.Substring(filePath.LastIndexOf("\\") + 1);
				try
				{
					f2.picbImage.Image = new Bitmap(filePath);
				}
				catch (ArgumentException)
				{
					btnNewImage.ForeColor = Color.Red;
					f2 = null;
				}
			}

			if (f2 != null)
			{
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