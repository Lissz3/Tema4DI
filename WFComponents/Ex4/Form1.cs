#nullable disable
namespace Ex4
{
	public delegate double Operation(double a, double b);
	public partial class Form1 : Form
	{
		Dictionary<string, Operation> operations = new();
		string opText;
		int sec = 56;
		int min = 0;
		public Form1()
		{
			InitializeComponent();
			operations.Add(rdbSuma.Tag.ToString(), (a, b) => a + b);
			operations.Add(rdbResta.Tag.ToString(), (a, b) => a - b);
			operations.Add(rdbMult.Tag.ToString(), (a, b) => a * b);
			operations.Add(rdbDiv.Tag.ToString(), (a, b) => a / b);
			opText = rdbSuma.Tag.ToString();
			tmrTitle.Start();
		}

		private void radioButton_CheckedChanged(object sender, EventArgs e)
		{
			opText = ((RadioButton)sender).Tag.ToString();
			lblSimbolo.Text = opText;
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			Color c;
			if (!int.TryParse(((TextBox)sender).Text, out _))
			{
				c = Color.Red;
			}
			else
			{
				c = Color.White;
			}
			((TextBox)sender).BackColor = c;

		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (double.TryParse(txtPrimero.Text, out double a) && double.TryParse(txtSegundo.Text, out double b))
			{
				double res = operations[opText].Invoke(a, b);
				lblRes.Text = "" + res;
			}
		}

		private void txtSegundo_KeyUp(object sender, KeyEventArgs e)  //Mejor Accept Button
		{
			if (e.KeyCode == Keys.Enter)
			{
				button1_Click(sender, e);
			}
		}

		private void tmrTitle_Tick(object sender, EventArgs e)
		{
			sec++;
			if (sec == 60)
			{
				min++;
				sec = 0;
			}

			Text = string.Format("{0,2:00}:{1,2:00}", min, sec);
		}
	}
}