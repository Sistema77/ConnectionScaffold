using System.ComponentModel.DataAnnotations;

namespace ConnectionScaffold.Dtos
{
    public class Accesos
    {
        [Key]
        public int IdAcceso { get; set; }

        public string DescripcionAcceso { get; set; }
    }
}
