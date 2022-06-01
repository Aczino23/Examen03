using System.ComponentModel.DataAnnotations;

namespace Restaurante.Models
{
    public class Categoria
    {
        [Key]
       public int Id { get; set; }
       [Required]
       [Display(Name = "Nombre De La Categoría")]
       public string Nombre { get; set; }
    }
}