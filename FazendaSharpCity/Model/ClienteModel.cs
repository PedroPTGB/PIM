using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class ClienteModel : EnvolvidosModel
    {
        private int idCliente;

        public ClienteModel(int id, string nome, string telefone, string email) : base(nome, telefone, email)
        {
            IdCliente = id;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
    }
}
