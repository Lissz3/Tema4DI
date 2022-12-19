#nullable disable

using Ex9.Properties;
using Microsoft.VisualBasic.Logging;
using System;
using System.Text;

namespace Ex9
{
	public partial class Form1 : Form
	{
		string initialText;
		string title = "DuckPad++";
		string initialTitle = "Sin título : DuckPad++";
		string lastDir;
		List<string> recentFiles = new List<string>();
		Form2 f2 = new ();
		public Form1()
		{
			InitializeComponent();
			Text = initialTitle;
		}
		private void NuevoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (Text.Contains('*'))
			{
				DialogResult d = MessageBox.Show("¿Desea guardar el documento?", "DuckPad++", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (d == DialogResult.Yes)
				{
					TryCatches(() => SaveFile(false));
				}
			}
			else
			{
				initialTitle = "Sin título : DuckPad++";
			}
			Text = initialTitle;
			rtxbMine.Clear();
		}

		private void GuardarTextoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TryCatches(() => SaveFile(true));
		}

		public void OpenFileDialog()
		{
			OpenFileDialog opf = new OpenFileDialog();
			opf.Filter = "Texto (*.txt)|*.txt|Archivo de configuración (*.ini)|*.ini|Java(*.java)|*.java|CS (*.cs)|*.cs|Python (*.py)|*.py|HTML (*.html)|*.html|CSS (*.css)|*.css|XML (*.xml)|*.xml|Todos los archivos|*.*";
			opf.InitialDirectory = "C:\\";
			if (opf.ShowDialog() == DialogResult.OK)
			{
				lastDir = opf.FileName.Substring(0, opf.FileName.LastIndexOf('\\') - 1);
				OpenFileFromPath(opf.FileName);
			}
		}

		private void OpenFileFromPath(string path)
		{
			using (StreamReader sr = new StreamReader(path))
			{
				rtxbMine.Text = sr.ReadToEnd();
			}
			initialText = rtxbMine.Text;
			initialTitle = path.Substring(path.LastIndexOf('\\') + 1);
			Text = initialTitle;
			MoveLastFilesList(path);
		}

		public void TryCatches(Action function)
		{
			try
			{
				function.Invoke();
			}
			catch (UnauthorizedAccessException e)
			{
				MyMBox("No tiene permisos para guardar el archivo en ese directorio.\nMás información sobre el error: " + e.Message);
			}
			catch (ArgumentNullException e)
			{
				MyMBox("Error al guardar.\nMás información sobre el error: " + e.Message);
			}
			catch (ArgumentException e)
			{
				MyMBox("Error al guardar.\nMás información sobre el error: " + e.Message);
			}
			catch (DirectoryNotFoundException e)
			{
				MyMBox("Directorio no encontrado.\nMás información sobre el error: " + e.Message);
			}
			catch (IOException e)
			{
				MyMBox("Error inesperado.\nMás información sobre el error: " + e.Message);
			}
		}

		public void SaveFile(bool continueEditing)
		{
			SaveFileDialog s = new SaveFileDialog();
			s.InitialDirectory = "C:\\";
			s.Filter = "Texto (*.txt)|*.txt|Archivo de configuración (*.ini)|*.ini|Java(*.java)|*.java|CS (*.cs)|*.cs|Python (*.py)|*.py|HTML (*.html)|*.html|CSS (*.css)|*.css|XML (*.xml)|*.xml|Todos los archivos|*.*";
			s.ValidateNames = true;
			if (s.ShowDialog() == DialogResult.OK)
			{

				using (StreamWriter swr = new StreamWriter(s.FileName))
				{
					swr.Write(rtxbMine.Text);
				}
				if (continueEditing)
				{
					initialTitle = s.FileName.Substring(s.FileName.LastIndexOf('\\') + 1);
					Text = initialTitle;
					initialText = rtxbMine.Text;
				}
				MoveLastFilesList(s.FileName);
				lastDir = s.FileName.Substring(0, s.FileName.LastIndexOf('\\') - 1);
			}
		}

		private void MoveLastFilesList(string newPath)
		{
			int fileNumbers = 5;
			if (recentFiles.Contains(newPath))
			{
				recentFiles.Remove(newPath);
			}
			recentFiles.Insert(0, newPath);
			if (recentFiles.Count < fileNumbers)
			{
				fileNumbers = recentFiles.Count;
			}
			recentFiles = recentFiles.Take(fileNumbers).ToList();
			DynamicMenuForRecentFiles();
		}

		private void DynamicMenuForRecentFiles()
		{
			archivosRecientesToolStripMenuItem.DropDownItems.Clear();
			recentFiles.ForEach(file =>
			{
				archivosRecientesToolStripMenuItem.DropDownItems.Add(file, null, new EventHandler(OpenRecentFile));
			});
		}

		private void OpenRecentFile(object sender, EventArgs e)
		{
			string path = ((ToolStripItem)sender).Text.ToString();
			OpenFileFromPath(path);
		}

		private void MyMBox(string error)
		{
			MessageBox.Show(error, "Lissta",
							MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			tsmiFontColor.Image = ChangeColorToImage(Resources.Image1, Color.Black);
			tsmiBackColor.Image = ChangeColorToImage(Resources.Image1, Color.White);
			initialText = rtxbMine.Text;
			string path = Environment.GetEnvironmentVariable("APPDATA") + "\\DuckPad++";
			if (File.Exists(path + "\\Config.ini"))
			{
				using (StreamReader myconfig = new StreamReader(path + "\\Config.ini"))
				{
					adjustLine.Checked = myconfig.ReadLine() == "true";

					switch (myconfig.ReadLine())
					{
						case "lower":
							tsmiLower.Checked = true;
							break;
						case "upper":
							tsmiUpper.Checked = true;
							break;
						default:
							tsmiNone.Checked = true;
							break;
					}

					if (int.TryParse(myconfig.ReadLine(), out int argbForeColor))
					{
						rtxbMine.ForeColor = Color.FromArgb(argbForeColor);
					}
					else
					{
						rtxbMine.ForeColor = Color.Black;
					}

					if (int.TryParse(myconfig.ReadLine(), out int argbBackColor))
					{
						rtxbMine.BackColor = Color.FromArgb(argbBackColor);
					}
					else
					{
						rtxbMine.BackColor = DefaultBackColor;
					}

					rtxbMine.Font = new Font(myconfig.ReadLine(), 10);

					string configFiles = myconfig.ReadLine();
					if (configFiles != null)
					{
						recentFiles = configFiles.Split(';').ToList();
					}
					DynamicMenuForRecentFiles();
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			string path = Environment.GetEnvironmentVariable("APPDATA") + "\\DuckPad++";

			if (!Directory.Exists(path))
			{
				Directory.CreateDirectory(path);
			}

			using (StreamWriter myconfig = new StreamWriter(path + "\\Config.ini"))
			{
				myconfig.WriteLine(adjustLine.Checked);
				myconfig.WriteLine(tsmiNone.Checked ? "none" : tsmiLower.Checked ? "lower" : tsmiUpper.Checked ? "upper" : "none");
				myconfig.WriteLine(rtxbMine.ForeColor.ToArgb());
				myconfig.WriteLine(rtxbMine.BackColor.ToArgb());
				myconfig.WriteLine(rtxbMine.Font.Name);
				if (recentFiles.Count > 0)
				{
					myconfig.WriteLine(string.Join(";", recentFiles));
				}
			}
		}

		private void AdjustLine(object sender, EventArgs e)
		{
			adjustLine.Checked = !adjustLine.Checked;
			rtxbMine.WordWrap = !rtxbMine.WordWrap;
		}

		private void ColorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog c = new();
			if (c.ShowDialog(this) == DialogResult.OK)
			{
				rtxbMine.ForeColor = c.Color;
				tsmiFontColor.Image = ChangeColorToImage(Resources.Image1, c.Color);
			}

		}

		private void ColorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ColorDialog c = new();
			if (c.ShowDialog(this) == DialogResult.OK)
			{
				rtxbMine.BackColor = c.Color;
				tsmiBackColor.Image = ChangeColorToImage(Resources.Image1, c.Color);
			}
		}

		private void FuenteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			FontDialog f = new();
			if (f.ShowDialog(this) == DialogResult.OK)
			{
				rtxbMine.Font = f.Font;
			}
		}

		private void RtxbMine_TextChanged(object sender, EventArgs e)
		{
			if (rtxbMine.Text != "")
			{
				Text = initialText == rtxbMine.Text ? initialTitle : "*" + initialTitle;

				ChangeText();
			}
		}


		private void CheckedChangedOnCaseOptions(object sender, EventArgs e)
		{
			ToolStripMenuItem item = (ToolStripMenuItem)sender;
			bool nextState = !item.Checked;
			switch (item.Tag)
			{
				case "none":
					ChangeCheckeds(nextState, false, false);
					break;
				case "upper":
					ChangeCheckeds(false, nextState, false);
					break;
				case "lower":
					ChangeCheckeds(false, false, nextState);
					break;
				default:
					ChangeCheckeds(nextState, false, false);
					break;
			}
			ChangeText();
		}

		public void ChangeCheckeds(bool none, bool upper, bool lower)
		{
			tsmiNone.Checked = none;
			tsmiUpper.Checked = upper;
			tsmiLower.Checked = lower;
		}

		public void ChangeText()
		{
			if (tsmiLower.Checked)
			{
				rtxbMine.Text = rtxbMine.Text.ToLower();
			}
			else if (tsmiUpper.Checked)
			{
				rtxbMine.Text = rtxbMine.Text.ToUpper();
			}
			rtxbMine.Select(rtxbMine.Text.Length, 0);
		}

		private void DeshacerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rtxbMine.Undo();
		}

		private void CopiarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rtxbMine.Copy();
		}

		private void PegarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rtxbMine.Paste();
		}

		private void CortarToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rtxbMine.Cut();
		}

		private void SeleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			rtxbMine.SelectAll();
		}

		private Image ChangeColorToImage(Image img, Color color)
		{
			using (Graphics g = Graphics.FromImage(img))
			{
				g.Clear(color);
			}

			return img;
		}

		private void AbrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TryCatches(() => OpenFileDialog());
		}

		private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Editor de texto hecho por Isabel Rosado.", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void InformaciónDeSelecciónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			f2.Show();
			SetTextInfo();
		}

		private void RtxbMine_SelectionChanged(object sender, EventArgs e)
		{
				SetTextInfo();
		}

		private void SetTextInfo()
		{
			f2.lblCNum.Text = GetCharCount(rtxbMine.SelectedText).ToString();
			f2.lblLongN.Text = GetSelectionLength().ToString();
			f2.lblSentNum.Text = GetSentencesCount(rtxbMine.SelectedText).ToString();
			f2.lblStartNum.Text = GetStartPoint().ToString();
			f2.lblWNum.Text = GetWordCount(rtxbMine.SelectedText).ToString();
		}

		private int GetStartPoint()
		{
			return rtxbMine.SelectionStart;
		}

		private int GetSelectionLength()
		{
			return rtxbMine.SelectionLength;
		}

		private int GetSentencesCount(string selection)
		{
			return string.IsNullOrWhiteSpace(selection) ? 0 : selection.Split('.').Length;
		}

		private int GetWordCount(string selection)
		{
			return string.IsNullOrWhiteSpace(selection) ? 0 : selection.Split(' ').Length;
		}

		private int GetCharCount(string selection)
		{
			char[] delimiters = { ' ', '\r', '\n' };
			return string.Join("", selection.Split(delimiters, StringSplitOptions.RemoveEmptyEntries)).Length;
			//return selection.ToCharArray().Where(c => !char.IsWhiteSpace(c)).Count();
		}
	}
}