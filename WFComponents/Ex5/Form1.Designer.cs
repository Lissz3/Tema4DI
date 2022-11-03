namespace Ex5;

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
			this.lbFirst = new System.Windows.Forms.ListBox();
			this.lbSecond = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnToR = new System.Windows.Forms.Button();
			this.btnToL = new System.Windows.Forms.Button();
			this.txbAdd = new System.Windows.Forms.TextBox();
			this.lblCount = new System.Windows.Forms.Label();
			this.lblIndex = new System.Windows.Forms.Label();
			this.MyTimer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// lbFirst
			// 
			this.lbFirst.FormattingEnabled = true;
			this.lbFirst.ItemHeight = 15;
			this.lbFirst.Location = new System.Drawing.Point(68, 12);
			this.lbFirst.Name = "lbFirst";
			this.lbFirst.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbFirst.Size = new System.Drawing.Size(120, 94);
			this.lbFirst.TabIndex = 0;
			this.lbFirst.Tag = "first";
			this.lbFirst.SelectedIndexChanged += new System.EventHandler(this.lbFirst_SelectedIndexChanged);
			// 
			// lbSecond
			// 
			this.lbSecond.FormattingEnabled = true;
			this.lbSecond.ItemHeight = 15;
			this.lbSecond.Location = new System.Drawing.Point(268, 12);
			this.lbSecond.Name = "lbSecond";
			this.lbSecond.Size = new System.Drawing.Size(120, 94);
			this.lbSecond.TabIndex = 1;
			this.lbSecond.Tag = "0";
			this.lbSecond.SelectedIndexChanged += new System.EventHandler(this.lbFirst_SelectedIndexChanged);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(39, 147);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Tag = "add";
			this.btnAdd.Text = "Añadir";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDel
			// 
			this.btnDel.Location = new System.Drawing.Point(139, 147);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(75, 23);
			this.btnDel.TabIndex = 3;
			this.btnDel.Tag = "del";
			this.btnDel.Text = "Quitar";
			this.btnDel.UseVisualStyleBackColor = true;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnToR
			// 
			this.btnToR.Location = new System.Drawing.Point(247, 147);
			this.btnToR.Name = "btnToR";
			this.btnToR.Size = new System.Drawing.Size(75, 23);
			this.btnToR.TabIndex = 4;
			this.btnToR.Tag = "toRight";
			this.btnToR.Text = "Pasar  →";
			this.btnToR.UseVisualStyleBackColor = true;
			this.btnToR.Click += new System.EventHandler(this.btnToR_Click);
			// 
			// btnToL
			// 
			this.btnToL.Location = new System.Drawing.Point(347, 147);
			this.btnToL.Name = "btnToL";
			this.btnToL.Size = new System.Drawing.Size(75, 23);
			this.btnToL.TabIndex = 5;
			this.btnToL.Tag = "toLeft";
			this.btnToL.Text = "Pasar ←";
			this.btnToL.UseVisualStyleBackColor = true;
			this.btnToL.Click += new System.EventHandler(this.btnToL_Click);
			// 
			// txbAdd
			// 
			this.txbAdd.Location = new System.Drawing.Point(39, 176);
			this.txbAdd.Name = "txbAdd";
			this.txbAdd.Size = new System.Drawing.Size(175, 23);
			this.txbAdd.TabIndex = 6;
			this.txbAdd.Tag = "TextToAdd";
			this.txbAdd.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txbAdd_KeyUp);
			// 
			// lblCount
			// 
			this.lblCount.AutoSize = true;
			this.lblCount.Location = new System.Drawing.Point(67, 109);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(21, 15);
			this.lblCount.TabIndex = 7;
			this.lblCount.Text = "C: ";
			// 
			// lblIndex
			// 
			this.lblIndex.AutoSize = true;
			this.lblIndex.Location = new System.Drawing.Point(149, 109);
			this.lblIndex.Name = "lblIndex";
			this.lblIndex.Size = new System.Drawing.Size(19, 15);
			this.lblIndex.TabIndex = 8;
			this.lblIndex.Text = "S: ";
			// 
			// MyTimer
			// 
			this.MyTimer.Interval = 200;
			this.MyTimer.Tick += new System.EventHandler(this.MyTimer_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(455, 210);
			this.Controls.Add(this.lblIndex);
			this.Controls.Add(this.lblCount);
			this.Controls.Add(this.txbAdd);
			this.Controls.Add(this.btnToL);
			this.Controls.Add(this.btnToR);
			this.Controls.Add(this.btnDel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lbSecond);
			this.Controls.Add(this.lbFirst);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private ListBox lbFirst;
    private ListBox lbSecond;
    private Button btnAdd;
    private Button btnDel;
    private Button btnToR;
    private Button btnToL;
    private TextBox txbAdd;
    private Label lblCount;
    private Label lblIndex;
	private System.Windows.Forms.Timer MyTimer;
}
