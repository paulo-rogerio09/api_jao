using System.ComponentModel.DataAnnotations;

namespace api_teste.DTOs
{
    public class TarefaDtos
    {
        [Required]         
        [MinLength(5)]

        public string Descricao { get; set; }
        
        public bool Feito { get; set; } = false;
    }
}
