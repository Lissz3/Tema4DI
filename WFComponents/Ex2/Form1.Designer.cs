namespace Ex2
{
	partial class FrmColor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmColor));
			this.btnExit = new System.Windows.Forms.Button();
			this.lblR = new System.Windows.Forms.Label();
			this.lblG = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.txbR = new System.Windows.Forms.TextBox();
			this.txbG = new System.Windows.Forms.TextBox();
			this.txbB = new System.Windows.Forms.TextBox();
			this.btnColor = new System.Windows.Forms.Button();
			this.lblPath = new System.Windows.Forms.Label();
			this.txbPath = new System.Windows.Forms.TextBox();
			this.btnLoad = new System.Windows.Forms.Button();
			this.pbxImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(354, 182);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 0;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
			this.btnExit.MouseEnter += new System.EventHandler(this.Btns_MouseEnter);
			this.btnExit.MouseLeave += new System.EventHandler(this.Btns_MouseLeave);
			// 
			// lblR
			// 
			this.lblR.AutoSize = true;
			this.lblR.Location = new System.Drawing.Point(12, 9);
			this.lblR.Name = "lblR";
			this.lblR.Size = new System.Drawing.Size(17, 15);
			this.lblR.TabIndex = 1;
			this.lblR.Text = "R:";
			// 
			// lblG
			// 
			this.lblG.AutoSize = true;
			this.lblG.Location = new System.Drawing.Point(12, 39);
			this.lblG.Name = "lblG";
			this.lblG.Size = new System.Drawing.Size(18, 15);
			this.lblG.TabIndex = 2;
			this.lblG.Text = "G:";
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Location = new System.Drawing.Point(12, 72);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(17, 15);
			this.lblB.TabIndex = 3;
			this.lblB.Text = "B:";
			// 
			// txbR
			// 
			this.txbR.Location = new System.Drawing.Point(36, 6);
			this.txbR.Name = "txbR";
			this.txbR.Size = new System.Drawing.Size(100, 23);
			this.txbR.TabIndex = 4;
			this.txbR.Text = "0";
			this.txbR.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txb_KeyUp);
			// 
			// txbG
			// 
			this.txbG.Location = new System.Drawing.Point(36, 36);
			this.txbG.Name = "txbG";
			this.txbG.Size = new System.Drawing.Size(100, 23);
			this.txbG.TabIndex = 5;
			this.txbG.Text = "0";
			this.txbG.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txb_KeyUp);
			// 
			// txbB
			// 
			this.txbB.Location = new System.Drawing.Point(36, 65);
			this.txbB.Name = "txbB";
			this.txbB.Size = new System.Drawing.Size(100, 23);
			this.txbB.TabIndex = 6;
			this.txbB.Text = "0";
			this.txbB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txb_KeyUp);
			// 
			// btnColor
			// 
			this.btnColor.Location = new System.Drawing.Point(12, 94);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(124, 23);
			this.btnColor.TabIndex = 7;
			this.btnColor.Text = "Color";
			this.btnColor.UseVisualStyleBackColor = true;
			this.btnColor.Click += new System.EventHandler(this.BtnColor_Click);
			this.btnColor.MouseEnter += new System.EventHandler(this.Btns_MouseEnter);
			this.btnColor.MouseLeave += new System.EventHandler(this.Btns_MouseLeave);
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Location = new System.Drawing.Point(151, 9);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(34, 15);
			this.lblPath.TabIndex = 8;
			this.lblPath.Text = "Path:";
			// 
			// txbPath
			// 
			this.txbPath.Location = new System.Drawing.Point(188, 6);
			this.txbPath.Name = "txbPath";
			this.txbPath.Size = new System.Drawing.Size(162, 23);
			this.txbPath.TabIndex = 9;
			this.txbPath.Text = "C:\\Users\\bdisa\\Downloads\\banco.png";
			this.txbPath.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txb_KeyUp);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(354, 6);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 10;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
			// 
			// pbxImage
			// 
			this.pbxImage.Location = new System.Drawing.Point(151, 35);
			this.pbxImage.Name = "pbxImage";
			this.pbxImage.Size = new System.Drawing.Size(278, 141);
			this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbxImage.TabIndex = 11;
			this.pbxImage.TabStop = false;
			// 
			// FrmColor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 217);
			this.Controls.Add(this.pbxImage);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.txbPath);
			this.Controls.Add(this.lblPath);
			this.Controls.Add(this.btnColor);
			this.Controls.Add(this.txbB);
			this.Controls.Add(this.txbG);
			this.Controls.Add(this.txbR);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblG);
			this.Controls.Add(this.lblR);
			this.Controls.Add(this.btnExit);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmColor";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ColorShifter";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyFormClosing);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmColor_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnExit;
		private Label lblR;
		private Label lblG;
		private Label lblB;
		private TextBox txbR;
		private TextBox txbG;
		private TextBox txbB;
		private Button btnColor;
		private Label lblPath;
		private TextBox txbPath;
		private Button btnLoad;
		private PictureBox pbxImage;
	}
}