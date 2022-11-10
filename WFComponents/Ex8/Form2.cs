#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex8
{
	public partial class Form2 : Form
	{
		public FileInfo[] Files { get; set; }
		int selectedImg = 0;
		Form1 form1;

		public Form2(Form1 f1)
		{
			InitializeComponent();
			pbForm2.ContextMenuStrip = contextMenuStrip1;
			form1 = f1;
		}


		private void Form2_Load(object sender, EventArgs e)
		{
			SetImage(0);
		}

		public void NextPrevImg(bool flag)
		{
			if (flag)
			{
				if (selectedImg == Files.Length - 1)
				{
					selectedImg = 0;
				}
				else
				{
					selectedImg += 1;
				}
			}
			else
			{
				if (selectedImg == 0)
				{
					selectedImg = Files.Length - 1;
				}
				else
				{
					selectedImg -= 1;
				}
			}

			SetImage(selectedImg);
		}


		public void SetImage(int newImg)
		{
			string fullname = Files[newImg].FullName;
			pbForm2.Image = new Bitmap(fullname);
			pbForm2.Tag = fullname.Substring(fullname.LastIndexOf('\\')+1);
			ChangeSizeAndTitle(pbForm2.Image.Size, pbForm2.Tag.ToString());
		}

		void ChangeSizeAndTitle(Size size, string title)
		{
			Size = size;
			Text = title;
		}

		public void ChangeLabelInfo(Label lbl)
		{
			double size = Files[selectedImg].Length;
			lbl.Text = string.Format("Información de la imagen:\nNombre: {0}\nTamaño: {1}\nResolución: {2}", Files[selectedImg].Name, size > 1024 ? size > Math.Pow(1024, 2) ? string.Format("{0:.00} MB", size / Math.Pow(1024, 2)) : string.Format("{0:.00} KB", size / 1024) : string.Format("{0:.00} Bytes", size), pbForm2.Image.Size);
		}


		private void SiguenteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			form1.btnNext.PerformClick();
		}

		private void AnteriorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			form1.btnPrev.PerformClick();
		}

		private void Form2_FormClosing(object sender, FormClosingEventArgs e)
		{
			form1.Clear();
		}

		private void ContextMenuStrip1_Click(object sender, EventArgs e)
		{
			form1.Clear();
			Close();
		}
	}

}
