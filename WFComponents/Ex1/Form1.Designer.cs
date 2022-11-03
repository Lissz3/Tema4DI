namespace Ex1
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
			this.btnLClick = new System.Windows.Forms.Button();
			this.btnRClick = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLClick
			// 
			this.btnLClick.AutoSize = true;
			this.btnLClick.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnLClick.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnLClick.Location = new System.Drawing.Point(110, 99);
			this.btnLClick.Name = "btnLClick";
			this.btnLClick.Size = new System.Drawing.Size(121, 40);
			this.btnLClick.TabIndex = 0;
			this.btnLClick.Text = "Left Click";
			this.btnLClick.UseVisualStyleBackColor = true;
			this.btnLClick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowCoords);
			// 
			// btnRClick
			// 
			this.btnRClick.AutoSize = true;
			this.btnRClick.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnRClick.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnRClick.Location = new System.Drawing.Point(260, 99);
			this.btnRClick.Name = "btnRClick";
			this.btnRClick.Size = new System.Drawing.Size(121, 40);
			this.btnRClick.TabIndex = 1;
			this.btnRClick.Text = "Right Click";
			this.btnRClick.UseVisualStyleBackColor = true;
			this.btnRClick.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowCoords);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(503, 247);
			this.Controls.Add(this.btnRClick);
			this.Controls.Add(this.btnLClick);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
			this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ShowCoords);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnLClick;
		private Button btnRClick;
	}
}