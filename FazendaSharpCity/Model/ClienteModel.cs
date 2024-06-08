using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class ClienteModel : EnvolvidosModel
    {
        public int IdCliente { get; set; }

        public ClienteModel() { }

        public ClienteModel(string nome, string telefone, string email) : base(nome, telefone, email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}
