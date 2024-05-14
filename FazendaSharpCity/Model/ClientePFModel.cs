using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class ClientePFModel : ClienteModel
    {
        private int cpf;
        private string rg;
        private string sexo;
        private string dtNasc;

        public int Cpf { get => cpf; set => cpf = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string DtNasc { get => dtNasc; set => dtNasc = value; }

        public ClientePFModel(int cpf, string rg, string sexo, string dtNasc)
        {
            Cpf = cpf;
            Rg = rg;
            Sexo = sexo;
            DtNasc = dtNasc;
        }
    }
}
