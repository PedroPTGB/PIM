﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    internal class ClientePJModel : ClienteModel
    {
        private int cnpj;
        private int inscricaoEstadual;
        private int inscricaoMunicipal;

        public int Cnpj { get => cnpj; set => cnpj = value; }
        public string NomeFantasia { get => Nome; set => Nome = value; }
        public int InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public int InscricaoMunicipal { get => inscricaoMunicipal; set => inscricaoMunicipal = value; }
    }
}
