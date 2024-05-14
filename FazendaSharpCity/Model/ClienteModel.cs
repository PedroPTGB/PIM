using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class ClienteModel : EnvolvidosModel
    {
        private int idCliente;

        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
