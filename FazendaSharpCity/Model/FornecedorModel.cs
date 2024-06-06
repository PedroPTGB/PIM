using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class FornecedorModel : EnvolvidosModel
    {
        public EnderecoModel Endereco { get; set; }


        public int idFornecedor { get; set; }
        public string cnpj {  get; set; }
        public string razaoSocial { get; set; }

        private string nomeFantasia;
        public string NomeFantasia { get => Nome; set => Nome = value; }

        public FornecedorModel() 
        {
            EnderecoModel Endereco = new EnderecoModel();
        }

        public FornecedorModel(string email, string telefone, int id, string CNPJ, string nome) : base (nome, telefone, email)
        {
            idFornecedor = id;
            cnpj = CNPJ;
            NomeFantasia = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
