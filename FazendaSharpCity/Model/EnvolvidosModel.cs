using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class EnvolvidosModel
    {
        public string Nome;
        public string Telefone;
        public string Email;

        public EnvolvidosModel() { }

        public EnvolvidosModel(string nome, string telefone, string email) 
        { 
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }



    }
}
