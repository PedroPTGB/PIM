using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class EnvolvidosModel
    {
        private string nome;
        private string telefone;
        private string email;

        public string Nome { get => Nome; set => Nome = value; }
        public string Telefone { get => Telefone; set => Telefone = value; }
        public string Email { get => email; set => email = value; }

        public EnvolvidosModel(string nome, string telefone, string email) 
        { 
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }



    }
}
