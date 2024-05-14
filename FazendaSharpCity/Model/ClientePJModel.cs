using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class ClientePJModel : ClienteModel
    {
        private int cnpj;
        private string nomeFantasia;
        private int inscricaoEstadual;
        private int inscricaoMunicipal;

        public int Cnpj { get => cnpj; set => cnpj = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public int InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public int InscricaoMunicipal { get => inscricaoMunicipal; set => inscricaoMunicipal = value; }

        public ClientePJModel(int cnpj, string nomef, int inscEstadual, int inscMunicipal) 
        {
            Cnpj = cnpj;
            NomeFantasia = nomef;
            InscricaoEstadual = inscEstadual;
            InscricaoMunicipal = inscMunicipal;
        }
    }
}
