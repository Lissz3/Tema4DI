namespace Ex4
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
			this.rdbSuma = new System.Windows.Forms.RadioButton();
			this.rdbResta = new System.Windows.Forms.RadioButton();
			this.rdbMult = new System.Windows.Forms.RadioButton();
			this.rdbDiv = new System.Windows.Forms.RadioButton();
			this.txtPrimero = new System.Windows.Forms.TextBox();
			this.txtSegundo = new System.Windows.Forms.TextBox();
			this.lblSimbolo = new System.Windows.Forms.Label();
			this.lblIgual = new System.Windows.Forms.Label();
			this.lblRes = new System.Windows.Forms.Label();
			this.btnCalc = new System.Windows.Forms.Button();
			this.tmrTitle = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// rdbSuma
			// 
			this.rdbSuma.AutoSize = true;
			this.rdbSuma.Checked = true;
			this.rdbSuma.Location = new System.Drawing.Point(11, 95);
			this.rdbSuma.Name = "rdbSuma";
			this.rdbSuma.Size = new System.Drawing.Size(55, 19);
			this.rdbSuma.TabIndex = 0;
			this.rdbSuma.TabStop = true;
			this.rdbSuma.Tag = "+";
			this.rdbSuma.Text = "Suma";
			this.rdbSuma.UseVisualStyleBackColor = true;
			this.rdbSuma.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// rdbResta
			// 
			this.rdbResta.AutoSize = true;
			this.rdbResta.Location = new System.Drawing.Point(83, 95);
			this.rdbResta.Name = "rdbResta";
			this.rdbResta.Size = new System.Drawing.Size(53, 19);
			this.rdbResta.TabIndex = 1;
			this.rdbResta.Tag = "-";
			this.rdbResta.Text = "Resta";
			this.rdbResta.UseVisualStyleBackColor = true;
			this.rdbResta.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// rdbMult
			// 
			this.rdbMult.AutoSize = true;
			this.rdbMult.Location = new System.Drawing.Point(158, 95);
			this.rdbMult.Name = "rdbMult";
			this.rdbMult.Size = new System.Drawing.Size(101, 19);
			this.rdbMult.TabIndex = 2;
			this.rdbMult.Tag = "*";
			this.rdbMult.Text = "Multiplicación";
			this.rdbMult.UseVisualStyleBackColor = true;
			this.rdbMult.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// rdbDiv
			// 
			this.rdbDiv.AutoSize = true;
			this.rdbDiv.Location = new System.Drawing.Point(279, 95);
			this.rdbDiv.Name = "rdbDiv";
			this.rdbDiv.Size = new System.Drawing.Size(67, 19);
			this.rdbDiv.TabIndex = 3;
			this.rdbDiv.Tag = "/";
			this.rdbDiv.Text = "División";
			this.rdbDiv.UseVisualStyleBackColor = true;
			this.rdbDiv.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
			// 
			// txtPrimero
			// 
			this.txtPrimero.Location = new System.Drawing.Point(12, 23);
			this.txtPrimero.Name = "txtPrimero";
			this.txtPrimero.Size = new System.Drawing.Size(112, 23);
			this.txtPrimero.TabIndex = 4;
			this.txtPrimero.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// txtSegundo
			// 
			this.txtSegundo.Location = new System.Drawing.Point(158, 23);
			this.txtSegundo.Name = "txtSegundo";
			this.txtSegundo.Size = new System.Drawing.Size(112, 23);
			this.txtSegundo.TabIndex = 5;
			this.txtSegundo.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			this.txtSegundo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSegundo_KeyUp);
			// 
			// lblSimbolo
			// 
			this.lblSimbolo.AutoSize = true;
			this.lblSimbolo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblSimbolo.Location = new System.Drawing.Point(131, 23);
			this.lblSimbolo.Name = "lblSimbolo";
			this.lblSimbolo.Size = new System.Drawing.Size(21, 21);
			this.lblSimbolo.TabIndex = 6;
			this.lblSimbolo.Text = "+";
			// 
			// lblIgual
			// 
			this.lblIgual.AutoSize = true;
			this.lblIgual.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblIgual.Location = new System.Drawing.Point(276, 23);
			this.lblIgual.Name = "lblIgual";
			this.lblIgual.Size = new System.Drawing.Size(21, 21);
			this.lblIgual.TabIndex = 7;
			this.lblIgual.Text = "=";
			// 
			// lblRes
			// 
			this.lblRes.AutoSize = true;
			this.lblRes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblRes.Location = new System.Drawing.Point(287, 23);
			this.lblRes.Name = "lblRes";
			this.lblRes.Size = new System.Drawing.Size(14, 21);
			this.lblRes.TabIndex = 8;
			this.lblRes.Text = " ";
			// 
			// btnCalc
			// 
			this.btnCalc.AutoSize = true;
			this.btnCalc.Location = new System.Drawing.Point(103, 57);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(75, 25);
			this.btnCalc.TabIndex = 9;
			this.btnCalc.Text = "Calcular";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.button1_Click);
			// 
			// tmrTitle
			// 
			this.tmrTitle.Interval = 1000;
			this.tmrTitle.Tick += new System.EventHandler(this.tmrTitle_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 137);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.lblRes);
			this.Controls.Add(this.lblIgual);
			this.Controls.Add(this.lblSimbolo);
			this.Controls.Add(this.txtSegundo);
			this.Controls.Add(this.txtPrimero);
			this.Controls.Add(this.rdbDiv);
			this.Controls.Add(this.rdbMult);
			this.Controls.Add(this.rdbResta);
			this.Controls.Add(this.rdbSuma);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "00:00";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private RadioButton rdbSuma;
		private RadioButton rdbResta;
		private RadioButton rdbMult;
		private RadioButton rdbDiv;
		private TextBox txtPrimero;
		private TextBox txtSegundo;
		private Label lblSimbolo;
		private Label lblIgual;
		private Label lblRes;
		private Button btnCalc;
		private System.Windows.Forms.Timer tmrTitle;
	}
}