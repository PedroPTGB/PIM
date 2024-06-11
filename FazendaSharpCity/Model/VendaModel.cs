using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FazendaSharpCity.Model
{
    internal class VendaModel
    {
        public int IdVenda {  get; set; }

        [Required(ErrorMessage = "Preco Unitário é obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Preco Unitário somente aceita valores numéricos.")]
        [Range(0, int.MaxValue, ErrorMessage = "Preco Unitário deve ser positivo.")]
        public float PrecoUnit { get; set; }

        [Required(ErrorMessage = "Data da Venda é obrigatória.")]
        public DateTime DtVenda { get; set; }

        [Required(ErrorMessage = "Forma de Pagamento é obrigatória.")]
        [StringLength(20, ErrorMessage = "Forma de Pagamento deve ter no máximo 20 caracteres.")]
        public string FormaPag {  get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatória.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Quantidade somente aceita valores numéricos.")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantidade deve ser positiva.")]
        public int Qtd {  get; set; }

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

    }
}
