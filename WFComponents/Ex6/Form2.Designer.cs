namespace Ex6
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.txbPin = new System.Windows.Forms.TextBox();
			this.lblTrys = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txbPin
			// 
			this.txbPin.Location = new System.Drawing.Point(25, 12);
			this.txbPin.Name = "txbPin";
			this.txbPin.PasswordChar = '*';
			this.txbPin.Size = new System.Drawing.Size(69, 23);
			this.txbPin.TabIndex = 0;
			this.txbPin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbPin_KeyUp);
			// 
			// lblTrys
			// 
			this.lblTrys.AutoSize = true;
			this.lblTrys.Location = new System.Drawing.Point(29, 38);
			this.lblTrys.Name = "lblTrys";
			this.lblTrys.Size = new System.Drawing.Size(62, 15);
			this.lblTrys.TabIndex = 1;
			this.lblTrys.Text = "Intentos: 3";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(120, 61);
			this.Controls.Add(this.lblTrys);
			this.Controls.Add(this.txbPin);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form2";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PIN";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public TextBox txbPin;
		public Label lblTrys;
	}
}