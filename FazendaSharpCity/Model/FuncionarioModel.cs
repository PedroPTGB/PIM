﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class FuncionarioModel : EnvolvidosModel
    {
        private int idFuncionario;
        private int cpf;
        private string dtNasc;
        private string rg;
        private string cargo;
        private int nivelAcesso;
        private string loginName;
        private string senha;


        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public string DtNasc { get => dtNasc; set => dtNasc = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public int NivelAcesso { get => nivelAcesso; set => nivelAcesso = value; }

        public string LoginName { get => loginName; set => loginName = value; }
        public string Senha { get => senha; set => senha = value; }
        
        public FuncionarioModel(string nome, string telefone, string email, int idFuncionario, int cpf, string dtNasc, string rg, string cargo, int nivelAcesso, string loginName, string senha) : base (nome, telefone, email)
        {
            IdFuncionario = idFuncionario;
            Cpf = cpf;
            DtNasc = dtNasc;
            Rg = rg;
            Cargo = cargo;
            NivelAcesso = nivelAcesso;
            LoginName = loginName;
            Senha = senha;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}
