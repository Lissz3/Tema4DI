#define CARACTER
namespace Ex1
{
	public partial class Form1 : Form
	{
		readonly string title = "Mouse Tester";

		public Form1()
		{
			InitializeComponent();
			Text = title;
			Icon = new Icon(@"G:\Mi unidad\04.DESENV INTERF\1EV\Tema4\mouse.ico");

		}

		private void ShowCoords(object sender, MouseEventArgs e)
		{
			if (sender == this)
			{
				Text = string.Format("{0} - X: {1}, Y: {2}", title, e.X, e.Y);
			}
			else
			{
				Button bt = (Button)sender;// == btnRClick ? btnRClick : btnLClick;
				Text = string.Format("{0} - X: {1}, Y: {2}", title, e.X + bt.Left, e.Y + bt.Top);
			}
		}

		private void Form1_MouseLeave(object sender, EventArgs e)
		{
			Text = title;
		}

		private void Form1_KeyUp(object sender, KeyEventArgs e) //solo teclas
		{
#if !CARACTER
			if (e.KeyCode == Keys.Escape)
			{
				Text = title;
			}
			else
			{
				Text = e.KeyData.ToString();
				Text = e.KeyValue.ToString();
			}
#endif
		}

		private void Form1_MouseUp(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				btnLClick.BackColor = DefaultBackColor;
			}
			else if (e.Button == MouseButtons.Right)
			{
				btnRClick.BackColor = DefaultBackColor;
			}
			else
			{
				btnLClick.BackColor = DefaultBackColor;

				btnRClick.BackColor = DefaultBackColor;
			}
		}

		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				btnLClick.BackColor = Color.AliceBlue;
			}
			else if (e.Button == MouseButtons.Right)
			{
				btnRClick.BackColor = Color.AliceBlue;
			}
			else
			{
				btnLClick.BackColor = Color.BlueViolet;

				btnRClick.BackColor = Color.BlueViolet;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Do you want to close?", title, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
			{
				e.Cancel = true;
			}
		}

		private void Form1_KeyPress(object sender, KeyPressEventArgs e)
		{
#if CARACTER
			Text = e.KeyChar.ToString();		
#endif
		}
	}
}