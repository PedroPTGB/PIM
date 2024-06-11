using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FazendaSharpCity.Model
{
    public class ProdutoModel
    {
        public int idProduto {  get; set; }

        [Required(ErrorMessage = "Nome do Produto é obrigatório.")]
        [StringLength(20, ErrorMessage = "Nome do Produto deve ter no máximo 20 caracteres.")]
        public string nome {  get; set; }

        [Required(ErrorMessage = "Quantidade é obrigatória.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Quantidade somente aceita valores numéricos.")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantidade deve ser positiva.")]
        public int qtd {  get; set; }

        [Required(ErrorMessage = "Data de Validade é obrigatória.")]
        public DateTime validade { get; set; }

        [Required(ErrorMessage = "Preco do Produto é obrigatório.")]
        [RegularExpression("([0-9]+)", ErrorMessage = "Preco do Produto somente aceita valores numéricos.")]
        [Range(0, int.MaxValue, ErrorMessage = "Preco do Produto deve ser positivo.")]
        public decimal preco {  get; set; }

        [StringLength(200, ErrorMessage = "Descrição do Produto deve ter no máximo 200 caracteres.")]
        public string descricao { get; set; }

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
