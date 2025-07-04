using System.ComponentModel.DataAnnotations.Schema;

namespace ExamenPractico.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }
        public string? imagen { get; set; } 

        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria? Categoria { get; set; }
    }
}
