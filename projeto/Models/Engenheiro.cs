using System.ComponentModel.DataAnnotations;

namespace Xablau.Models
{
    public class Engenheiro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cpf { get; set; }
        [Required]
        public DateTime dataNascimento { get; set; }
        [Required]
        public string RegistroCREA { get; set; }
        [Required]
        public string Contato { get; set; }
    }
}