namespace Ex7
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.cmbAsig = new System.Windows.Forms.ComboBox();
			this.cmbAlumno = new System.Windows.Forms.ComboBox();
			this.lblAsig = new System.Windows.Forms.Label();
			this.lblAlumno = new System.Windows.Forms.Label();
			this.lblAsigAvg = new System.Windows.Forms.Label();
			this.lblStAvg = new System.Windows.Forms.Label();
			this.lblTableAvg = new System.Windows.Forms.Label();
			this.lblMin = new System.Windows.Forms.Label();
			this.lblMax = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// cmbAsig
			// 
			this.cmbAsig.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAsig.FormattingEnabled = true;
			this.cmbAsig.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.cmbAsig.Location = new System.Drawing.Point(33, 48);
			this.cmbAsig.Name = "cmbAsig";
			this.cmbAsig.Size = new System.Drawing.Size(147, 23);
			this.cmbAsig.TabIndex = 0;
			this.cmbAsig.SelectionChangeCommitted += new System.EventHandler(this.Cmb_SelectionChangeCommitted);
			// 
			// cmbAlumno
			// 
			this.cmbAlumno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbAlumno.FormattingEnabled = true;
			this.cmbAlumno.Location = new System.Drawing.Point(186, 48);
			this.cmbAlumno.Name = "cmbAlumno";
			this.cmbAlumno.Size = new System.Drawing.Size(147, 23);
			this.cmbAlumno.TabIndex = 1;
			this.cmbAlumno.SelectionChangeCommitted += new System.EventHandler(this.Cmb_SelectionChangeCommitted);
			// 
			// lblAsig
			// 
			this.lblAsig.AutoSize = true;
			this.lblAsig.Location = new System.Drawing.Point(33, 30);
			this.lblAsig.Name = "lblAsig";
			this.lblAsig.Size = new System.Drawing.Size(64, 15);
			this.lblAsig.TabIndex = 2;
			this.lblAsig.Text = "Asignatura";
			// 
			// lblAlumno
			// 
			this.lblAlumno.AutoSize = true;
			this.lblAlumno.Location = new System.Drawing.Point(186, 30);
			this.lblAlumno.Name = "lblAlumno";
			this.lblAlumno.Size = new System.Drawing.Size(50, 15);
			this.lblAlumno.TabIndex = 3;
			this.lblAlumno.Text = "Alumno";
			// 
			// lblAsigAvg
			// 
			this.lblAsigAvg.AutoSize = true;
			this.lblAsigAvg.Location = new System.Drawing.Point(33, 74);
			this.lblAsigAvg.Name = "lblAsigAvg";
			this.lblAsigAvg.Size = new System.Drawing.Size(43, 15);
			this.lblAsigAvg.TabIndex = 4;
			this.lblAsigAvg.Text = "Media:";
			// 
			// lblStAvg
			// 
			this.lblStAvg.AutoSize = true;
			this.lblStAvg.Location = new System.Drawing.Point(186, 74);
			this.lblStAvg.Name = "lblStAvg";
			this.lblStAvg.Size = new System.Drawing.Size(43, 15);
			this.lblStAvg.TabIndex = 5;
			this.lblStAvg.Text = "Media:";
			// 
			// lblTableAvg
			// 
			this.lblTableAvg.AutoSize = true;
			this.lblTableAvg.Location = new System.Drawing.Point(33, 141);
			this.lblTableAvg.Name = "lblTableAvg";
			this.lblTableAvg.Size = new System.Drawing.Size(117, 15);
			this.lblTableAvg.TabIndex = 0;
			this.lblTableAvg.Text = "Nota media general: ";
			// 
			// lblMin
			// 
			this.lblMin.AutoSize = true;
			this.lblMin.Location = new System.Drawing.Point(186, 104);
			this.lblMin.Name = "lblMin";
			this.lblMin.Size = new System.Drawing.Size(80, 15);
			this.lblMin.TabIndex = 6;
			this.lblMin.Text = "Nota mínima:";
			// 
			// lblMax
			// 
			this.lblMax.AutoSize = true;
			this.lblMax.Location = new System.Drawing.Point(186, 89);
			this.lblMax.Name = "lblMax";
			this.lblMax.Size = new System.Drawing.Size(82, 15);
			this.lblMax.TabIndex = 7;
			this.lblMax.Text = "Nota máxima:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(400, 186);
			this.Controls.Add(this.lblMax);
			this.Controls.Add(this.lblMin);
			this.Controls.Add(this.lblTableAvg);
			this.Controls.Add(this.lblStAvg);
			this.Controls.Add(this.lblAsigAvg);
			this.Controls.Add(this.lblAlumno);
			this.Controls.Add(this.lblAsig);
			this.Controls.Add(this.cmbAlumno);
			this.Controls.Add(this.cmbAsig);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(30);
			this.Text = "Visor de notas";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ComboBox cmbAsig;
		private ComboBox cmbAlumno;
		private Label lblAsig;
		private Label lblAlumno;
		private Label lblAsigAvg;
		private Label lblStAvg;
		private Label lblTableAvg;
		private Label lblMin;
		private Label lblMax;
		private ToolTip toolTip1;
	}
}