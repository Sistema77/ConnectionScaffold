using System.ComponentModel.DataAnnotations;

namespace ConnectionScaffold.Dtos
{
    public class Colecciones
    {
        [Key]
        public int IdColeccion { get; set; }

        public string NombreColeccion { get; set; }

        public ICollection<Libros> Libros { get; set; }
    }
}
