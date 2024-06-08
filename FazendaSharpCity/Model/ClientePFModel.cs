using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class ClientePFModel : ClienteModel
    {
        public EnderecoModel Endereco { get; set; }
        private string cpf;
        private string rg;
        private string sexo;
        private string dtNasc;

        public string Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string DtNasc { get => dtNasc; set => dtNasc = value; }

        public ClientePFModel()  
        {
            EnderecoModel Endereco = new EnderecoModel();
        }
        public ClientePFModel(string cpf, string rg, string sexo, string dtNasc, string nome, string telefone, string email) : base (nome, telefone, email)
        {
            Cpf = cpf;
            Rg = rg;
            Sexo = sexo;
            DtNasc = dtNasc;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
