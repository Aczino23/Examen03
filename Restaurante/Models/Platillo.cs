using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurante.Models
{
    public class Platillo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Nombre Platillo")]
        public string Nombre { get; set; }
        public double? Precio { get; set; }
        [Display(Name = "Categoria")]
        public int IdCategoria { get; set; }
        [ForeignKey("IdCategoria")]
        public Categoria? Categoria { get; set; }
        [Required] 
        public string Descripcion { get; set; }
        [Display(Name = "Imagen del platillo")]
        public string? UrlImagen { get; set; }
    }
}