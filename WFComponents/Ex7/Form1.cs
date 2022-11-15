#nullable disable

namespace Ex7
{
	public partial class Form1 : Form
	{
		Classroom cr;
		public Form1()
		{
			InitializeComponent();
			cr = new Classroom(GetStudents());
		}

		string GetStudents()
		{
			string fullname = "C:\\" + Environment.GetEnvironmentVariable("homepath") + "\\names.txt";
			StreamReader r;
			string readStudents;
			try
			{
				using (r = new StreamReader(fullname))
				{
					readStudents = r.ReadToEnd();
				}

				return readStudents;
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
			return null;
		}

		void MyMBox(string error)
		{
			MessageBox.Show(error, "Error",
							MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			string asigOc = "";
			int length = 0;

			foreach (string asignaturas in Enum.GetNames(typeof(Asignaturas)))
			{
				if (asignaturas.Length > length)
				{
					length = asignaturas.Length;
					asigOc = asignaturas;
				}

				cmbAsig.Items.Add(asignaturas);
			}

			foreach (string student in cr.students)
			{
				cmbAlumno.Items.Add(student);
			}

			int x = 12;
			int y = lblTableAvg.Location.Y + lblTableAvg.Height + 20;

			Label lblAsOculta = new()
			{
				Text = asigOc,
				Location = new Point(x, y),
			};

			x = 12 + lblAsOculta.Width;

			for (int i = 0; i < Enum.GetNames(typeof(Asignaturas)).Length; i++)
			{
				Label lbl = new()
				{
					Text = Enum.GetName(typeof(Asignaturas), i),
					Location = new Point(x, y),
					TextAlign = ContentAlignment.MiddleCenter,
					Size = lblAsOculta.PreferredSize
				};
				Controls.Add(lbl);
				x += lbl.Width;
			}

			x = 12;
			y += lblAsOculta.Height;

			for (int i = 0; i < cr.marks.GetLength(0); i++)
			{
				Label lblNombre = new()
				{
					Text = cr.students[i],
					TextAlign = ContentAlignment.MiddleRight,
					Location = new Point(x, y),
					Size = lblAsOculta.PreferredSize,
					AutoSize = false
				};
				Controls.Add(lblNombre);
				lblNombre.Tag = "0";
				x += lblAsOculta.Width;

				for (int j = 0; j < cr.marks.GetLength(1); j++)
				{
					Label lblNotas = new()
					{
						Text = cr[i, j].ToString(),
						TextAlign = ContentAlignment.MiddleCenter,
						Location = new Point(x, y),
						Size = lblAsOculta.PreferredSize,
						AutoSize = false,
						Tag = Enum.GetName(typeof(Asignaturas), j) + ", " + cr.students[i],
					};
					Controls.Add(lblNotas);
					lblNotas.MouseHover += new EventHandler(lbl_MouseHover);
					x += lblAsOculta.PreferredSize.Width;
				}
				x = 12;
				y += 20;
			}

			lblTableAvg.Text = string.Format("Media general: {0:0.00}", cr.Average());
		}

		private void Cmb_SelectionChangeCommitted(object sender, EventArgs e)
		{
			if (sender == cmbAsig)
			{
				lblAsigAvg.Text = string.Format("Media: {0:0.00}", cr.Average((Asignaturas) cmbAsig.SelectedIndex));
			} 
			else
			{
				cr.MinMax(cmbAlumno.SelectedIndex, out int max, out int min);
				lblStAvg.Text = string.Format("Media: {0:0.00}", cr.Average(cmbAlumno.SelectedIndex));
				lblMax.Text = string.Format("Nota máxima: {0}", max);
				lblMin.Text = string.Format("Nota mínima: {0}", min);

			}
		}

		private void lbl_MouseHover(object sender, EventArgs e)
		{
			toolTip1.SetToolTip((Label)sender, (((Label)sender).Tag).ToString());
		}
	}
}