using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessModel;

namespace Business
{
    public class Produto
    {
        public void Gravar(ProdutoModel produto)
        {
            new Database.Produto().Gravar(produto.Nome, produto.Marca, produto.Descricao, produto.Valor);

            //Database.Produto produto =  new Database.Produto();
            //produto.Gravar(produto.Nome, produto.Marca, produto.Descricao, produto.Valor);
        }
    }
}
