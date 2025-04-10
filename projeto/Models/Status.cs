using System.ComponentModel.DataAnnotations;

namespace Xablau.Models
{
    public class Status
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}