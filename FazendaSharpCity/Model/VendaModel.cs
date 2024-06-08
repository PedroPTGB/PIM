using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class VendaModel
    {
        private int idCliente;
        private int idProduto;
        private int idFornecedor;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdProduto { get => idProduto; set => idProduto = value; }
        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        
        public VendaModel(int idCliente, int idProduto, int idFornecedor) 
        {
            IdCliente = idCliente;
            IdProduto = idProduto;
            IdFornecedor= idFornecedor;
        } 
    }
}
