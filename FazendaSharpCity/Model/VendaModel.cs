using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class VendaModel
    {
        public int idVenda {  get; set; }
        public float precoUnit { get; set; }
        public DateTime dtVenda { get; set; }
        public string formaPag {  get; set; }
        public int qtd {  get; set; }

    }
}
