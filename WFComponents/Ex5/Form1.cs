#nullable disable
using System.Collections;

namespace Ex5;

public partial class Form1 : Form
{
	ListBox.SelectedIndexCollection indices;
	string selectedOb;
	int cont = 0;
	string titulo = "Titulo Scroll";
	bool catbat;
	public Form1()
	{
		InitializeComponent();
		Text = "";
		MyTimer.Start();
		Icon = Properties.Resources.catbat;
		catbat = true;
		AcceptButton = btnAdd;
		tp.SetToolTip(btnAdd, "Añadir elementos");
		tp.SetToolTip(btnDel, "Eliminar elementos seleccionados");
		tp.SetToolTip(btnToL, "Añadir elementos de derecha a izquierda");
		tp.SetToolTip(btnToR, "Añadir elementos de izquierda a derecha");
		tp.SetToolTip(btnToR, "Añadir elementos de izquierda a derecha");
		tp.SetToolTip(txbAdd, "Elemento a añadir");
		tp.SetToolTip(lbFirst, "Primer ListBox");
		tp.SetToolTip(lbFirst, "Segundo ListBox");
	}

	private void BtnAdd_Click(object sender, EventArgs e)
	{
		if (lbFirst.FindStringExact(txbAdd.Text) == ListBox.NoMatches && txbAdd.Text != "")
		{
			lbFirst.Items.Add(txbAdd.Text);
			lblCount.Text = "C: " + lbFirst.Items.Count.ToString();
		}
	}


	private void LbFirst_SelectedIndexChanged(object sender, EventArgs e)
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
			if (lbSecond.SelectedIndex != -1)
			{
				selectedOb = ((ListBox)sender).SelectedItem.ToString();
			}
		}
	}

	private void BtnDel_Click(object sender, EventArgs e)
	{
		if (lbFirst.Items.Count != 0)
		{
			for (int i = indices.Count - 1; i >= 0; i--)
			{
				lbFirst.Items.RemoveAt(indices[i]);
			}
		}
	}

	private void BtnToR_Click(object sender, EventArgs e)
	{
		if (indices != null)
		{
			for (int i = indices.Count - 1; i >= 0; i--)
			{
				string it = lbFirst.Items[indices[i]].ToString();
				if (lbSecond.FindStringExact(it) == ListBox.NoMatches)
				{
					lbSecond.Items.Add(it);
				}
			}

			for (int i = indices.Count - 1; i >= 0; i--)
			{
				lbFirst.Items.RemoveAt(indices[i]);
			}
			lbSecond.Tag = lbSecond.Items.Count;
			tp.SetToolTip(lbSecond, lbSecond.Items.Count.ToString());
		}
	}

	private void BtnToL_Click(object sender, EventArgs e)
	{
		if (selectedOb != null)
		{
			if (lbFirst.FindStringExact(selectedOb) == ListBox.NoMatches)
			{
				lbFirst.Items.Add(selectedOb);
				lbSecond.Items.Remove(selectedOb);
			}
			lbSecond.ClearSelected();
		}
		tp.SetToolTip(lbSecond, lbSecond.Items.Count.ToString());

	}

	private void MyTimer_Tick(object sender, EventArgs e)
	{
		Icon = catbat ? Properties.Resources.catbat : Properties.Resources.catvamp;
		catbat = catbat ? false : true;
		if (cont == titulo.Length + 1)
		{
			cont = 0;
			Text = "";
		}
		Text = titulo.Substring(titulo.Length - cont);
		cont++;
	}
}
