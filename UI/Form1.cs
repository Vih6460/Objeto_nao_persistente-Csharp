using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessModel;
using Business;

namespace Aula4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ProdutoModel produto = new ProdutoModel();
            produto.Nome = txtNome.Text;
            produto.Marca = txtMarca.Text;
            produto.Descricao = txtDescricao.Text;
            produto.Valor = double.Parse(txtValor.Text);
            Produto prod = new Produto();
            prod.Gravar(produto);
        }
    }
}
