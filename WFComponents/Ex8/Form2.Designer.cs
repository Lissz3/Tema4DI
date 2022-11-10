namespace Ex8
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.pbForm2 = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.siguenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.anteriorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.pbForm2)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbForm2
			// 
			this.pbForm2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbForm2.Location = new System.Drawing.Point(0, 0);
			this.pbForm2.Name = "pbForm2";
			this.pbForm2.Size = new System.Drawing.Size(189, 79);
			this.pbForm2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pbForm2.TabIndex = 0;
			this.pbForm2.TabStop = false;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.siguenteToolStripMenuItem,
            this.anteriorToolStripMenuItem,
            this.toolStripSeparator1,
            this.cerrarToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(181, 98);
			this.contextMenuStrip1.Click += new System.EventHandler(this.ContextMenuStrip1_Click);
			// 
			// siguenteToolStripMenuItem
			// 
			this.siguenteToolStripMenuItem.Name = "siguenteToolStripMenuItem";
			this.siguenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.siguenteToolStripMenuItem.Text = "Siguente";
			this.siguenteToolStripMenuItem.Click += new System.EventHandler(this.SiguenteToolStripMenuItem_Click);
			// 
			// anteriorToolStripMenuItem
			// 
			this.anteriorToolStripMenuItem.Name = "anteriorToolStripMenuItem";
			this.anteriorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.anteriorToolStripMenuItem.Text = "Anterior";
			this.anteriorToolStripMenuItem.Click += new System.EventHandler(this.AnteriorToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// cerrarToolStripMenuItem
			// 
			this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
			this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.cerrarToolStripMenuItem.Text = "Cerrar";
			this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.AnteriorToolStripMenuItem_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(189, 79);
			this.Controls.Add(this.pbForm2);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.Text = "Form2";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbForm2)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private PictureBox pbForm2;
		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem siguenteToolStripMenuItem;
		private ToolStripMenuItem anteriorToolStripMenuItem;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripMenuItem cerrarToolStripMenuItem;
	}
}