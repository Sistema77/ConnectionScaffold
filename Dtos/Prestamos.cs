using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConnectionScaffold.Dtos
{
    public class Prestamos
    {
        [Key]
        public int IdPrestamo { get; set; }

        public int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuarios Usuario { get; set; }

        public int IdLibro { get; set; }

        [ForeignKey("IdLibro")]
        public Libros Libro { get; set; }

        public DateTime FechaPrestamo { get; set; }

        public DateTime FechaDevolucion { get; set; }
    }
}
