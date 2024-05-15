using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class GerenteModel : FuncionarioModel
    {
        public GerenteModel(string nome, string telefone, string email, int idFuncionario, int cpf, string dtNasc, string rg, string cargo, int nivelAcesso, string loginName, string senha) : base(nome, telefone, email, idFuncionario, cpf, dtNasc, rg, cargo, nivelAcesso, loginName, senha)
        {
            IdFuncionario = idFuncionario;
            Cpf = cpf;
            DtNasc = dtNasc;
            Rg = rg;
            Cargo = cargo;
            NivelAcesso = nivelAcesso;
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
    }
}
