namespace Ex8
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
			this.btnOpen = new System.Windows.Forms.Button();
			this.lblDir = new System.Windows.Forms.Label();
			this.lblInfo = new System.Windows.Forms.Label();
			this.tp = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// btnOpen
			// 
			this.btnOpen.Location = new System.Drawing.Point(12, 12);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.Size = new System.Drawing.Size(75, 23);
			this.btnOpen.TabIndex = 0;
			this.btnOpen.Text = "Abrir";
			this.btnOpen.UseVisualStyleBackColor = true;
			this.btnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
			// 
			// lblDir
			// 
			this.lblDir.AutoSize = true;
			this.lblDir.Location = new System.Drawing.Point(12, 38);
			this.lblDir.Name = "lblDir";
			this.lblDir.Size = new System.Drawing.Size(65, 15);
			this.lblDir.TabIndex = 1;
			this.lblDir.Text = "Directorio: ";
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Location = new System.Drawing.Point(12, 53);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(146, 15);
			this.lblInfo.TabIndex = 2;
			this.lblInfo.Text = "Información de la imagen:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(313, 138);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.lblDir);
			this.Controls.Add(this.btnOpen);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 40);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Visor de imágenes";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnOpen;
		private Label lblDir;
		public Label lblInfo;
		private ToolTip tp;
	}
}