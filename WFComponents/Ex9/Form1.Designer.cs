namespace Ex9
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoDocumentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.guardarTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.abrirArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.archivosRecientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.seleccionarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.informaciónDeSelecciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adjustLine = new System.Windows.Forms.ToolStripMenuItem();
			this.selecciónDeEscrituraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiNone = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLower = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUpper = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.fuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiFontColor = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiBackColor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rtxbMine = new System.Windows.Forms.RichTextBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.herramientasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoDocumentoToolStripMenuItem,
            this.guardarTextoToolStripMenuItem,
            this.abrirArchivoToolStripMenuItem,
            this.archivosRecientesToolStripMenuItem,
            this.toolStripSeparator1,
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "&Archivo";
			// 
			// nuevoDocumentoToolStripMenuItem
			// 
			this.nuevoDocumentoToolStripMenuItem.Name = "nuevoDocumentoToolStripMenuItem";
			this.nuevoDocumentoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.nuevoDocumentoToolStripMenuItem.Text = "&Nuevo documento";
			this.nuevoDocumentoToolStripMenuItem.Click += new System.EventHandler(this.NuevoDocumentoToolStripMenuItem_Click);
			// 
			// guardarTextoToolStripMenuItem
			// 
			this.guardarTextoToolStripMenuItem.Name = "guardarTextoToolStripMenuItem";
			this.guardarTextoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.guardarTextoToolStripMenuItem.Text = "&Guardar";
			this.guardarTextoToolStripMenuItem.Click += new System.EventHandler(this.GuardarTextoToolStripMenuItem_Click);
			// 
			// abrirArchivoToolStripMenuItem
			// 
			this.abrirArchivoToolStripMenuItem.Name = "abrirArchivoToolStripMenuItem";
			this.abrirArchivoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.abrirArchivoToolStripMenuItem.Text = "A&brir archivo";
			this.abrirArchivoToolStripMenuItem.Click += new System.EventHandler(this.AbrirArchivoToolStripMenuItem_Click);
			// 
			// archivosRecientesToolStripMenuItem
			// 
			this.archivosRecientesToolStripMenuItem.Name = "archivosRecientesToolStripMenuItem";
			this.archivosRecientesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.archivosRecientesToolStripMenuItem.Text = "Archivos &recientes";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
			this.salirToolStripMenuItem.Text = "&Salir";
			// 
			// ediciónToolStripMenuItem
			// 
			this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.cortarToolStripMenuItem,
            this.seleccionarTodoToolStripMenuItem,
            this.toolStripSeparator2,
            this.informaciónDeSelecciónToolStripMenuItem});
			this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
			this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
			this.ediciónToolStripMenuItem.Text = "&Edición";
			// 
			// deshacerToolStripMenuItem
			// 
			this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
			this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.deshacerToolStripMenuItem.Text = "&Deshacer";
			this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.DeshacerToolStripMenuItem_Click);
			// 
			// copiarToolStripMenuItem
			// 
			this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
			this.copiarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.copiarToolStripMenuItem.Text = "&Copiar";
			this.copiarToolStripMenuItem.Click += new System.EventHandler(this.CopiarToolStripMenuItem_Click);
			// 
			// pegarToolStripMenuItem
			// 
			this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
			this.pegarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.pegarToolStripMenuItem.Text = "&Pegar";
			this.pegarToolStripMenuItem.Click += new System.EventHandler(this.PegarToolStripMenuItem_Click);
			// 
			// cortarToolStripMenuItem
			// 
			this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
			this.cortarToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.cortarToolStripMenuItem.Text = "C&ortar";
			this.cortarToolStripMenuItem.Click += new System.EventHandler(this.CortarToolStripMenuItem_Click);
			// 
			// seleccionarTodoToolStripMenuItem
			// 
			this.seleccionarTodoToolStripMenuItem.Name = "seleccionarTodoToolStripMenuItem";
			this.seleccionarTodoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.seleccionarTodoToolStripMenuItem.Text = "&Seleccionar todo";
			this.seleccionarTodoToolStripMenuItem.Click += new System.EventHandler(this.SeleccionarTodoToolStripMenuItem_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(204, 6);
			// 
			// informaciónDeSelecciónToolStripMenuItem
			// 
			this.informaciónDeSelecciónToolStripMenuItem.Name = "informaciónDeSelecciónToolStripMenuItem";
			this.informaciónDeSelecciónToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
			this.informaciónDeSelecciónToolStripMenuItem.Text = "&Información de selección";
			this.informaciónDeSelecciónToolStripMenuItem.Click += new System.EventHandler(this.InformaciónDeSelecciónToolStripMenuItem_Click);
			// 
			// herramientasToolStripMenuItem
			// 
			this.herramientasToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
			this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adjustLine,
            this.selecciónDeEscrituraToolStripMenuItem,
            this.toolStripSeparator3,
            this.fuenteToolStripMenuItem,
            this.tsmiFontColor,
            this.tsmiBackColor,
            this.toolStripSeparator4,
            this.acercaDeToolStripMenuItem});
			this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
			this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
			this.herramientasToolStripMenuItem.Text = "&Herramientas";
			// 
			// adjustLine
			// 
			this.adjustLine.Name = "adjustLine";
			this.adjustLine.Size = new System.Drawing.Size(188, 22);
			this.adjustLine.Text = "Ajuste de &línea";
			this.adjustLine.Click += new System.EventHandler(this.AdjustLine);
			// 
			// selecciónDeEscrituraToolStripMenuItem
			// 
			this.selecciónDeEscrituraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNone,
            this.tsmiLower,
            this.tsmiUpper});
			this.selecciónDeEscrituraToolStripMenuItem.Name = "selecciónDeEscrituraToolStripMenuItem";
			this.selecciónDeEscrituraToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.selecciónDeEscrituraToolStripMenuItem.Text = "Selección de escrit&ura";
			// 
			// tsmiNone
			// 
			this.tsmiNone.Checked = true;
			this.tsmiNone.CheckState = System.Windows.Forms.CheckState.Checked;
			this.tsmiNone.Name = "tsmiNone";
			this.tsmiNone.Size = new System.Drawing.Size(136, 22);
			this.tsmiNone.Tag = "none";
			this.tsmiNone.Text = "&Ninguna";
			this.tsmiNone.Click += new System.EventHandler(this.CheckedChangedOnCaseOptions);
			// 
			// tsmiLower
			// 
			this.tsmiLower.Name = "tsmiLower";
			this.tsmiLower.Size = new System.Drawing.Size(136, 22);
			this.tsmiLower.Tag = "lower";
			this.tsmiLower.Text = "M&inúsculas";
			this.tsmiLower.Click += new System.EventHandler(this.CheckedChangedOnCaseOptions);
			// 
			// tsmiUpper
			// 
			this.tsmiUpper.Name = "tsmiUpper";
			this.tsmiUpper.Size = new System.Drawing.Size(136, 22);
			this.tsmiUpper.Tag = "upper";
			this.tsmiUpper.Text = "Mayúscu&las";
			this.tsmiUpper.Click += new System.EventHandler(this.CheckedChangedOnCaseOptions);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
			// 
			// fuenteToolStripMenuItem
			// 
			this.fuenteToolStripMenuItem.Name = "fuenteToolStripMenuItem";
			this.fuenteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.fuenteToolStripMenuItem.Text = "&Fuente";
			this.fuenteToolStripMenuItem.Click += new System.EventHandler(this.FuenteToolStripMenuItem_Click);
			// 
			// tsmiFontColor
			// 
			this.tsmiFontColor.BackColor = System.Drawing.Color.Transparent;
			this.tsmiFontColor.Name = "tsmiFontColor";
			this.tsmiFontColor.Size = new System.Drawing.Size(188, 22);
			this.tsmiFontColor.Text = "Color de &texto";
			this.tsmiFontColor.Click += new System.EventHandler(this.ColorDeTextoToolStripMenuItem_Click);
			// 
			// tsmiBackColor
			// 
			this.tsmiBackColor.BackColor = System.Drawing.Color.Transparent;
			this.tsmiBackColor.Name = "tsmiBackColor";
			this.tsmiBackColor.Size = new System.Drawing.Size(188, 22);
			this.tsmiBackColor.Text = "Color de &fondo";
			this.tsmiBackColor.Click += new System.EventHandler(this.ColorDeFondoToolStripMenuItem_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(185, 6);
			// 
			// acercaDeToolStripMenuItem
			// 
			this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
			this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
			this.acercaDeToolStripMenuItem.Text = "Acer&ca de ...";
			this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
			// 
			// rtxbMine
			// 
			this.rtxbMine.AcceptsTab = true;
			this.rtxbMine.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtxbMine.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtxbMine.Location = new System.Drawing.Point(0, 24);
			this.rtxbMine.Name = "rtxbMine";
			this.rtxbMine.Size = new System.Drawing.Size(800, 426);
			this.rtxbMine.TabIndex = 1;
			this.rtxbMine.Text = "";
			this.rtxbMine.WordWrap = false;
			this.rtxbMine.SelectionChanged += new System.EventHandler(this.RtxbMine_SelectionChanged);
			this.rtxbMine.TextChanged += new System.EventHandler(this.RtxbMine_TextChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rtxbMine);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem archivoToolStripMenuItem;
		private ToolStripMenuItem guardarTextoToolStripMenuItem;
		private ToolStripMenuItem abrirArchivoToolStripMenuItem;
		private ToolStripMenuItem archivosRecientesToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem salirToolStripMenuItem;
		private ToolStripMenuItem ediciónToolStripMenuItem;
		private ToolStripMenuItem deshacerToolStripMenuItem;
		private ToolStripMenuItem copiarToolStripMenuItem;
		private ToolStripMenuItem pegarToolStripMenuItem;
		private ToolStripMenuItem cortarToolStripMenuItem;
		private ToolStripMenuItem seleccionarTodoToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem informaciónDeSelecciónToolStripMenuItem;
		private ToolStripMenuItem herramientasToolStripMenuItem;
		private ToolStripMenuItem adjustLine;
		private ToolStripMenuItem selecciónDeEscrituraToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripMenuItem tsmiFontColor;
		private ToolStripMenuItem tsmiBackColor;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripMenuItem acercaDeToolStripMenuItem;
		private RichTextBox rtxbMine;
		private ToolStripMenuItem nuevoDocumentoToolStripMenuItem;
		private ToolStripMenuItem fuenteToolStripMenuItem;
		private ToolStripMenuItem tsmiNone;
		private ToolStripMenuItem tsmiLower;
		private ToolStripMenuItem tsmiUpper;
	}
}