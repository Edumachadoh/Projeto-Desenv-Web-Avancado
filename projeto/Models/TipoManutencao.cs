using System.ComponentModel.DataAnnotations;

namespace Xablau.Models
{
    public class TipoManutencao

    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}