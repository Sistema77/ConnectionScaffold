using System.ComponentModel.DataAnnotations;

namespace ConnectionScaffold.Dtos
{
    public class Generos
    {
        [Key]
        public int id_genero {  get; set; }
        public string nombre_genero { get; set; }
        public string descripcion_genero { get; set; }

        public ICollection<Libros> Libros { get; set; }
    }
}
