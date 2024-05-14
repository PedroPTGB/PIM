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
        private string bairro;
        private string estado;
        private string cidade;

        public string Logradouro {  get { return logradouro; } set { logradouro = value; } } 
        public string Numero { get {  return numero; } set {  numero = value; } }
        public string Complemento { get { return complemento; } set {  complemento = value; } }
        public string Bairro { get {  return bairro; } set { } }
        public string Estado { get { return estado; } set {  estado = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }

    }
}
