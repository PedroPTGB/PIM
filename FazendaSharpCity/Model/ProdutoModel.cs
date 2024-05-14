using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class ProdutoModel
    {
        private int idProduto;
        private string nome;
        private string tipoProduto;
        private decimal preco;

        public int IdProduto { get => idProduto; set => idProduto = value; }
        public string Nome { get => nome; set => nome = value; }
        public string TipoProduto { get => tipoProduto; set => tipoProduto = value; }
        public decimal Preco { get => preco; set => preco = value; }

        public ProdutoModel(int idProduto, string nome, string tipoProduto, decimal preco)
        {
            IdProduto = idProduto;
            Nome = nome;
            TipoProduto = tipoProduto;
            Preco = preco;
        }

    }
}
