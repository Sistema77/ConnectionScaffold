using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConnectionScaffold.Dtos
{
    [Table("Autores")]
    public class Autores
    {
        [Key]
        public int IdAutor { get; set; }

        public string NombreAutor { get; set; }

        public string ApellidosAutor { get; set; }

        public ICollection<Libros> Libros { get; set; }

    }
}
