using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FazendaSharpCity.Model
{
    public class FornecedorModel : EnvolvidosModel
    {
        private int idFornecedor;
        private int cnpj;
        private int inscricaoEstadual;
        private int inscricaoMunicipal;
        private string nomeFantasia;

        public int IdFornecedor { get => idFornecedor; set => idFornecedor = value; }
        public int Cnpj { get => cnpj; set => cnpj = value; }
        public int InscricaoEstadual { get => inscricaoEstadual; set => inscricaoEstadual = value; }
        public int InscricaoMunicipal { get => inscricaoMunicipal; set => inscricaoMunicipal = value; }
        public string NomeFantasia { get => Nome; set => Nome = value; }

        public FornecedorModel(string email, string telefone, int idFornecedor, int cnpj, int inscricaoEstadual, int inscriaoMunicipal, string nome) : base (nome, telefone, email)
        {
            IdFornecedor = idFornecedor;
            Cnpj = cnpj;
            InscricaoEstadual = inscricaoEstadual;
            InscricaoMunicipal = inscricaoMunicipal;
            NomeFantasia = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}
