using System.ComponentModel.DataAnnotations;

namespace ConnectionScaffold.Dtos
{
    public class Editoriales
    {
        [Key]
        public int IdEditorial { get; set; }

        public string NombreEditorial { get; set; }

        public ICollection<Libros> Libros { get; set; }
    }
}
