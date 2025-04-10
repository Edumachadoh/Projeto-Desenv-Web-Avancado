using System.ComponentModel.DataAnnotations;

namespace Xablau.Models
{
    public class Manutencao

    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public int IdObra { get; set; }
        [Required]
        public Obra Obra { get; set; }
        
        [Required]
        public int IdMaterial { get; set; }
        [Required]
        public Material Material { get; set; }
        [Required]
        public string MaterialQtd { get; set; }

        [Required]
        public int IdEquipamento { get; set; }
        [Required]
        public Equipamento Equipamento { get; set; }
        [Required]
        public string EquipamentoQtd { get; set; }

        [Required]
        public string descricao { get; set; }
        [Required]
        public DateTime data { get; set; }
    }
}