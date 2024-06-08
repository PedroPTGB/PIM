using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class VendaModel
    {
        public int IdVenda {  get; set; }
        public float PrecoUnit { get; set; }
        public DateTime DtVenda { get; set; }
        public string FormaPag {  get; set; }
        public int Qtd {  get; set; }

    }
}
