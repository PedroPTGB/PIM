using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FazendaSharpCity.Model
{
    public class ClientePFModel : ClienteModel
    {
        public EnderecoModel Endereco { get; set; }
       
        public string Cpf { get; set; }

       
        public string Cnpj { get; set; }

        
        public string Sexo { get; set; }

        
        public DateTime DtNasc {  get; set; }

        
        public bool TipoPessoa { get; set; }

        

        public ClientePFModel()  
        {
            EnderecoModel Endereco = new EnderecoModel();
            if (Cpf != "") 
                TipoPessoa = true;
            else
                TipoPessoa = false;
        }
    }
}
