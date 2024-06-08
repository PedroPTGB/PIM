using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class EnderecoModel
    {
        private string logradouro;
        private string numero;
        private string complemento;
        public string bairro { get; set; }
        private string estado;
        private string cidade;
        public string cep { get; set; }
        public int num { get; set; }

        public string Logradouro {  get { return logradouro; } set { logradouro = value; } } 
        public string Numero { get {  return numero; } set {  numero = value; } }
        public string Complemento { get { return complemento; } set {  complemento = value; } }
        public string Estado { get { return estado; } set {  estado = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }

    }
}
