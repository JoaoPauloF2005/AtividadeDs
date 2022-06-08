using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadeDs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double resultado;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string produto = txtProduto.Text;
            int quantidade = int.Parse(txtQtde.Text);
            double valor_untario = double.Parse(txtValor.Text);

            resultado = quantidade * valor_untario;

            lblTotal.Text = resultado.ToString();

            ListViewItem item = new ListViewItem(txtProduto.Text);
            item.SubItems.Add(txtQtde.Text);
            item.SubItems.Add(txtValor.Text);
            ListProduto.Items.Add(item);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtProduto.Clear();
            txtQtde.Clear();
            txtValor.Clear();
            lblTotal.Text = "0";
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
