using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FazendaSharpCity.Model
{
    public class FuncionarioModel : EnvolvidosModel
    {
        public EnderecoModel Endereco {  get; set; }
        public int idFuncionario{ get; set;}

        [Required(ErrorMessage = "CPF obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "CPF somente aceita valores numéricos.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 dígitos.")]
        public string cpf  { get; set;}

        [Required(ErrorMessage = "Data de Nascimento obrigatória.")]
        public DateTime dtNasc { get; set;}


        [Required(ErrorMessage = "Cargo é obrigatório.")]
        public int gerente { get; set; }


        [Required(ErrorMessage = "Login é obrigatório.")]
        public string login { get; set;}


        [Required(ErrorMessage = "Senha é obrigatória.")]
        public string senha { get; set; }

        [Required(ErrorMessage = "Salário é obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Salário somente aceita valores numéricos.")]
        [Range(0, double.MaxValue, ErrorMessage = "Salário deve ser positivo.")]
        public decimal salario {  get; set; }

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

        public FuncionarioModel()
        {
            Endereco = new EnderecoModel();
        }
    }
}
