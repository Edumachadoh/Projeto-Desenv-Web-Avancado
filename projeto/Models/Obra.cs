using System.ComponentModel.DataAnnotations;

namespace Xablau.Models
{
    public class Obra
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int IdUsuario { get; set; }
        [Required]
        public Usuario Usuario { get; set; }
        [Required]
        public int IdEngenheiro { get; set; }
        [Required]
        public Engenheiro Engenheiro { get; set; }
        public int IdStatus { get; set; }
        [Required]
        public Status Status { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Localização { get; set; }
        [Required]
        public DateTime DataInicio { get; set; }
        [Required]
        public DateTime DataFim { get; set; }
        [Required]
        public double CustoPrevisto { get; set; }
        [Required]
        public double CustoReal { get; set; }
        [Required]
        public string Complexidade { get; set; }
        [Required]
        public string ImpactoAmbiental { get; set; }
    }
}