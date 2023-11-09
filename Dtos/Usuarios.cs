using System.ComponentModel.DataAnnotations;

namespace ConnectionScaffold.Dtos
{
    public class Usuarios
    {
        [Key]
        public int IdUsuario { get; set; }

        public string NombreUsuario { get; set; }

        public string ApellidosUsuario { get; set; }

        public int EdadUsuario { get; set; }

        public ICollection<Prestamos> Prestamos { get; set; }
    }
}
