using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ConnectionScaffold.Dtos
{
    public class Libros
    {
        [Key]
        public int IdLibro { get; set; }

        public string TituloLibro { get; set; }

        public int IdAutor { get; set; }

        [ForeignKey("IdAutor")]
        [Display(Name = "Rel_Autores_Libros")]
        public Autores Autor { get; set; }

        public int IdEditorial { get; set; }

        [ForeignKey("IdEditorial")]
        public Editoriales Editorial { get; set; }

        public int IdColeccion { get; set; }

        [ForeignKey("IdColeccion")]
        public Colecciones Coleccion { get; set; }

        public int IdGenero {  get; set; }
        [ForeignKey("IdGenero")]

        public Generos genero { get; set; }
        public int IdEstadoPrestamo { get; set; }

        [ForeignKey("IdEstadoPrestamo")]
        [Display(Name = "Rel_Prestamos_Libros")]
        public Estados_Prestamos EstadoPrestamo { get; set; }

        public ICollection<Prestamos> Prestamos { get; set; }
    }
}