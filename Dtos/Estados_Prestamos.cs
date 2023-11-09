using System.ComponentModel.DataAnnotations;

namespace ConnectionScaffold.Dtos
{
    public class Estados_Prestamos
    {
        [Key]
        public int IdEstadoPrestamo { get; set; }

        public string DescripcionEstadoPrestamo { get; set; }

        public ICollection<Libros> Libros { get; set; }

        public ICollection<Prestamos> Prestamos { get; set; }
    }
}
