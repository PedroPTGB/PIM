using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class VendaModel
    {
        public int idProduto {  get; set; }
        public string nome {  get; set; }
        public int qtd {  get; set; }
        public DateTime validade { get; set; }
        public decimal preco {  get; set; }
        public string descricao { get; set; }

    }
}
