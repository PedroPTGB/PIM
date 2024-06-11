using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FazendaSharpCity.Model
{
    public class FornecedorModel : EnvolvidosModel
    {
        public EnderecoModel Endereco { get; set; }


        public int idFornecedor { get; set; }

        [Required(ErrorMessage = "CNPJ obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "CNPJ somente aceita valores numéricos.")]
        [StringLength(14, MinimumLength = 14, ErrorMessage = "CNPJ deve ter 14 dígitos.")]
        public string cnpj {  get; set; }

        [Required(ErrorMessage = "Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "Nome deve ter no máximo 100 caracteres.")]   
        public string razaoSocial { get; set; }

        private string nomeFantasia;

        [Required(ErrorMessage = "Nome Fantasia é obrigatório.")]
        [StringLength(100, ErrorMessage = "Nome Fantasia deve ter no máximo 100 caracteres.")]
        public string NomeFantasia { get => Nome; set => Nome = value; }

        public void ValidaClasse()
        {
            ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (isValid == false)
            {
                StringBuilder sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
        }

        public FornecedorModel() 
        {
            EnderecoModel Endereco = new EnderecoModel();
        }

    }
}
