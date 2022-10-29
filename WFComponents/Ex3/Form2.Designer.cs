namespace Ex3
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
			this.picbImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// picbImage
			// 
			this.picbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picbImage.Location = new System.Drawing.Point(0, 0);
			this.picbImage.Name = "picbImage";
			this.picbImage.Size = new System.Drawing.Size(341, 224);
			this.picbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picbImage.TabIndex = 0;
			this.picbImage.TabStop = false;
			// 
			// Form2
			// 
			//this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			//this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			//this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(341, 224);
			this.Controls.Add(this.picbImage);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize)(this.picbImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private PictureBox picbImage;
	}
}