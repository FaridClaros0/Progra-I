using System.ComponentModel.DataAnnotations;

namespace sistema_academica.Models
{
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }
        public string Codigo { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
    }
}
