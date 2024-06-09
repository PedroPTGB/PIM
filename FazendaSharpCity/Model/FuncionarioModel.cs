using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class FuncionarioModel : EnvolvidosModel
    {
        public EnderecoModel Endereco {  get; set; }
        public int idFuncionario{ get; set;}
        public string cpf  { get; set;}
        public DateTime dtNasc { get; set;}
        public bool gerente { get; set;}
        public string login { get; set;}
        public string senha { get; set; }
        public float salario {  get; set; }

        public FuncionarioModel()
        {
            Endereco = new EnderecoModel();
        }
    }
}
