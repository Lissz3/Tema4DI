﻿namespace Ex4
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
			this.btnNewImage = new System.Windows.Forms.Button();
			this.cbxModal = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// btnNewImage
			// 
			this.btnNewImage.AutoSize = true;
			this.btnNewImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.btnNewImage.Location = new System.Drawing.Point(12, 12);
			this.btnNewImage.Name = "btnNewImage";
			this.btnNewImage.Size = new System.Drawing.Size(121, 31);
			this.btnNewImage.TabIndex = 0;
			this.btnNewImage.Text = "Nueva Imagen";
			this.btnNewImage.UseVisualStyleBackColor = true;
			// 
			// cbxModal
			// 
			this.cbxModal.AutoSize = true;
			this.cbxModal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.cbxModal.Location = new System.Drawing.Point(139, 16);
			this.cbxModal.Name = "cbxModal";
			this.cbxModal.Size = new System.Drawing.Size(73, 25);
			this.cbxModal.TabIndex = 1;
			this.cbxModal.Text = "Modal";
			this.cbxModal.UseVisualStyleBackColor = true;
			this.cbxModal.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 54);
			this.Controls.Add(this.cbxModal);
			this.Controls.Add(this.btnNewImage);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button btnNewImage;
		private CheckBox cbxModal;
	}
}