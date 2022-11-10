#define NOTABLE
#nullable disable
using Microsoft.VisualBasic.Logging;
using System.IO;

namespace Ex6
{
	public partial class Form1 : Form
	{
		private readonly string[] abc = { "-", "ABC", "DEF", "GHI", "JKL", "MNO", "PQRS", "TUV", "WXYZ", ",", "+", "" };
		private readonly string[] nums = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "*", "0", "#" };
		SaveFileDialog saveFileDialog1;
		public Form1()
		{
			InitializeComponent();
			Form2 f2 = new();
			DialogResult res;
			res = f2.ShowDialog();

			switch (res)
			{
				case DialogResult.OK:
					MessageBox.Show("Contraseña Aceptada", "Móvil",
					MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;

				case DialogResult.Abort:
					MessageBox.Show("Intentos superados", "Móvil",
							MessageBoxButtons.OK, MessageBoxIcon.Stop);
					Environment.Exit(0);
					break;

				case DialogResult.Cancel:
					MessageBox.Show("Operación Cancelada", "Móvil",
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Environment.Exit(0);
					break;
			}

		}

		private void Form1_Load(object sender, EventArgs e)
		{
#if NOTABLE
			tlp.Visible = false;
			int x = 12;
			int y = txbMvl.Location.Y + txbMvl.Height + 10;

			for (int i = 0; i < 12; i++)
			{
				Button button = new()
				{
					Text = abc[i] + "\n" + nums[i],
					Margin = new Padding(0, 0, 0, 0),
					Location = new Point(x, y),
					Size = new Size(71, 51),
				};
				Controls.Add(button);
				button.Tag = "0";
				button.MouseEnter += Button_MouseEnter;
				button.MouseLeave += Button_MouseLeave;
				button.MouseClick += Button_MouseClick;
				if ((i + 1) % 3 == 0)
				{
					x = 12;
					y += button.Size.Height;
				}
				else
				{
					x += button.Size.Width;
				}
			}
#else
			int x = 10;
			int y = txbMvl.Location.Y + txbMvl.Height + 10;
			int column = 0;
			int row = 0;

			for (int i = 0; i < 12; i++)
			{
				Button button = new Button();
				button.Text = abc[i] + "\n" + nums[i];
				button.Margin = new Padding(0, 0, 0, 0);
				button.Location = new Point(x, y);
				tlp.Controls.Add(button, column, row);
				button.Dock = DockStyle.Fill;
				button.Tag = "0";
				button.MouseEnter += Button_MouseEnter;
				button.MouseLeave += Button_MouseLeave;
				button.MouseClick += Button_MouseClick;
				if ((i + 1) % 3 == 0)
				{
					x = 10;
					y += button.Size.Height;
					row++;
					column = 0;
				}
				else
				{
					x += button.Size.Width;
					column++;
				}

			}
#endif

		}



		private void Button_MouseClick(object sender, MouseEventArgs e)
		{
			((Button)sender).BackColor = Color.LightSteelBlue;
			((Button)sender).Tag = "1";
			txbMvl.Text += ((Button)sender).Text.Substring(((Button)sender).Text.Length - 1);
		}

		private void Button_MouseEnter(object sender, EventArgs e)
		{
			if (((Button)sender).Tag.ToString() != "1")
			{
				((Button)sender).BackColor = Color.LightPink;
			}
		}
		private void Button_MouseLeave(object sender, EventArgs e)
		{
			if (((Button)sender).Tag.ToString() != "1")
			{
				((Button)sender).BackColor = DefaultBackColor;
			}
		}

		private void BtnReset_Click(object sender, EventArgs e)
		{
#if NOTABLE
			foreach (var item in Controls)
			{
				if (item is Button button)
				{
					button.BackColor = DefaultBackColor;
					button.Tag = "0";
				}
			}
			txbMvl.Text = "";
#else
			foreach (var item in tlp.Controls)
			{
				if (item is Button button)
				{
					button.BackColor = DefaultBackColor;
					button.Tag = "0";
				}
			}
			txbMvl.Text = "";

#endif
		}

		private void ResetToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BtnReset_Click(sender, e);
		}

		private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void GToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (txbMvl.Text != "")
			{
				StreamWriter s;
				saveFileDialog1 = new SaveFileDialog
				{
					Title = "Selección de directorio para almacenar datos",
					InitialDirectory = "C:\\",
					Filter = "Text Files | *.txt",
					ValidateNames = true
				};

				if (saveFileDialog1.ShowDialog() == DialogResult.OK)
				{
					try
					{
						using (s = new StreamWriter(saveFileDialog1.FileName))
						{
							s.WriteLine(txbMvl.Text);
						}
					}
					catch (UnauthorizedAccessException)
					{
						MyMBox("Permisos insuficientes");
					}
					catch (ArgumentNullException)
					{
						MyMBox("El archivo no existe");
					}
					catch (IOException)
					{
						MyMBox("Error inesperado");
					}
				}
				else
				{
					MyMBox("Operación cancelada");
				}
			}
			else
			{
				MyMBox("Tiene que insertar un número a guardar");
			}
		}

		private void AToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Movil de escritorio - Isabel Rosado", "Acerca de...",
							MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		void MyMBox(string error)
		{
			MessageBox.Show(error, "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}
	}
}
