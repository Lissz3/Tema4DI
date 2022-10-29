#nullable disable
namespace Ex5;

public partial class Form1 : Form
{
	ListBox.SelectedIndexCollection indices;
	string selectedOb;
	int cont = 1;
	string titulo = "Titulo Scroll";
	public Form1()
	{
		InitializeComponent();
		Text = "";
		MyTimer.Start();
	}

	private void btnAdd_Click(object sender, EventArgs e)
	{
		if (lbFirst.FindStringExact(txbAdd.Text) == ListBox.NoMatches && txbAdd.Text != "")
		{
			lbFirst.Items.Add(txbAdd.Text);
			lblCount.Text = "C: " + lbFirst.Items.Count.ToString();
		}
	}

	private void txbAdd_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Enter)
		{
			btnAdd_Click(sender, e);
		}
	}

	private void lbFirst_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (sender == lbFirst)
		{
			indices = ((ListBox)sender).SelectedIndices;
			lblIndex.Text = "S: ";
			foreach (var item in indices)
			{
				lblIndex.Text += item + " ";
			}
		}
		else
		{
			selectedOb = ((ListBox)sender).SelectedItem.ToString();
		}
	}

	private void btnDel_Click(object sender, EventArgs e)
	{
		for (int i = indices.Count - 1; i >= 0; i--)
		{
			lbFirst.Items.RemoveAt(indices[i]);
		}
	}

	private void btnToR_Click(object sender, EventArgs e)
	{
		if (indices != null)
		{
			for (int i = 0; i < indices.Count; i++)
			{
				string it = lbFirst.Items[indices[i]].ToString();
				if (lbSecond.FindStringExact(it) == ListBox.NoMatches)
				{
					lbSecond.Items.Add(it);
				}
			}
		}
	}

	private void btnToL_Click(object sender, EventArgs e)
	{
		if (selectedOb != null)
		{
			if (lbFirst.FindStringExact(selectedOb) == ListBox.NoMatches)
			{
				lbFirst.Items.Add(selectedOb);
			}
		}
	}

	private void MyTimer_Tick(object sender, EventArgs e)
	{
		if (Text == "")
		{
			Text += titulo[titulo.Length - cont].ToString();
		}
		cont++;
		if (cont == titulo.Length - 1)
		{
			cont = 0;
		}
	}
}
