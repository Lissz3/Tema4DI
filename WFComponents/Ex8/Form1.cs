#nullable disable

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Windows.Forms;

namespace Ex8
{
	public partial class Form1 : Form
	{
		FolderBrowserDialog folderBrowserDialog1 = new();
		string folderName = "";
		FileInfo[] files;
		DirectoryInfo d;
		Form2 f2;
		public Button btnNext;
		public Button btnPrev;

		public Form1()
		{
			InitializeComponent();
			Size = new Size(180 * 3 + 80, 120 * 3);
			lblInfo.Text = "Información de la imagen:\nNombre: \nTamaño: \nResolución:";
			tp.SetToolTip(btnOpen, "Seleccionar directorio");
		}
		private void BtnOpen_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.Description = "Seleccione directorio";
			folderBrowserDialog1.ShowNewFolderButton = false;
			folderBrowserDialog1.RootFolder = Environment.SpecialFolder.Personal;
			DialogResult result = folderBrowserDialog1.ShowDialog();
			if (result == DialogResult.OK)
			{
				folderName = folderBrowserDialog1.SelectedPath;
				if (folderName != null)
				{
					string lblText = "Directorio: " + folderName;
					Color c = Color.Black;
					d = new DirectoryInfo(folderName);
					try
					{
						files = d.GetFiles("*.png");
					}
					catch (UnauthorizedAccessException)
					{
						lblText = "Directorio: No tiene permisos para acceder al directorio.";
						c = Color.Red;
					}

					lblDir.Text = lblText;
					lblDir.ForeColor = c;
					

					CreatePictureBoxes();
				}
			}
		}

		void CreatePictureBoxes()
		{
			int x = btnOpen.Location.X;
			int y = lblInfo.Location.Y + lblInfo.Height + 20;
			int cont = 0;
			for (int i = 0; i < files.Length; i++)
			{
				PictureBox pb = new()
				{
					Location = new Point(x, y),
					Image = new Bitmap(files[i].FullName),
					Tag = i,
					Size = new Size(180, 120),
					BorderStyle = BorderStyle.FixedSingle,
					SizeMode = PictureBoxSizeMode.Zoom,
				};
				x += pb.Width + 10;
				cont++;
				if (cont == 3)
				{
					x = btnOpen.Location.X;
					y = pb.Location.Y + pb.Height + 20;
					cont = 0;
				}
				pb.Click += new EventHandler(PbOnClick);
				Controls.Add(pb);
			}

			CreateNewForm();
			AddButtonsAfterPbs();
			f2.ChangeLabelInfo(lblInfo);
		}

		void PbOnClick(object sender, EventArgs e)
		{
			if (int.TryParse(((PictureBox)sender).Tag.ToString(), out int index))
			{
				f2.SetImage(index);
				f2.ChangeLabelInfo(lblInfo);
			}
		}

		void CreateNewForm()
		{
			if (files.Length != 0)
			{
				f2 = new(this)
				{
					Files = files
				};
				f2.Show();
			}

		}

		void AddButtonsAfterPbs()
		{
			PictureBox last = null;
			for (int i = Controls.Count - 1; i > 0; i--)
			{
				if (Controls[i] is PictureBox)
				{
					last = (PictureBox)Controls[i];
					break;
				}
			}

			btnNext = new()
			{
				Text = "Avance",
				Tag = "N",
			};
			btnNext.Click += new EventHandler(BtnClick);
			btnNext.Location = new Point(Size.Width / 2 - btnNext.Width, last.Location.Y + last.Height + 20);
			tp.SetToolTip(btnNext, "Siguiente imagen");
			Controls.Add(btnNext);

			btnPrev = new()
			{
				Text = "Anterior",
				Tag = "P"
			};
			btnPrev.Click += new EventHandler(BtnClick);
			btnPrev.Location = new Point(btnNext.Location.X + btnNext.Width + 5, btnNext.Location.Y);
			tp.SetToolTip(btnPrev, "Imagen anterior");
			Controls.Add(btnPrev);

			AddEvents();
		}

		private void BtnClick(object sender, EventArgs e)
		{
			if (((Button)sender).Tag.ToString() == "N")
			{
				f2.NextPrevImg(true);
			}
			else
			{
				f2.NextPrevImg(false);
			}

			f2.ChangeLabelInfo(lblInfo);
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Right)
			{
				btnNext.PerformClick();
			}
			else if (e.KeyCode == Keys.Left)
			{
				btnPrev.PerformClick();
			}
		}


		private void ChangePreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.Left:
				case Keys.Right:
					e.IsInputKey = true;
					break;
			}
		}

		void AddEvents()
		{
			Array.ForEach(Controls.OfType<Button>().ToArray(), control =>
			{
				control.PreviewKeyDown += new PreviewKeyDownEventHandler(ChangePreviewKeyDown);
				control.KeyDown += new KeyEventHandler(Form1_KeyDown);
			});
		}

		public void Clear()
		{
			for (int i = Controls.Count - 1; i > 0; i--)
			{
				if (Controls[i] is PictureBox)
				{
					Controls.Remove(Controls[i]);
				}
			}

			Controls.Remove(btnNext);
			Controls.Remove(btnPrev);
			lblInfo.Text = "Información de la imagen:\nNombre: \nTamaño: \nResolución:";
			lblDir.Text = "Directorio: ";
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("¿Seguro que desea salir?", "Visor de imágenes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
		}
	}
}
