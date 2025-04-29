using System.ComponentModel.DataAnnotations;

namespace RepasoPrueba2._0P1.Models
{
    public class Propietario
    {
        [Key]
        [MaxLength(15)]
        public int Identificacion { get; set; }
        [MaxLength(100)]
        public string Nombre { get; set; }
        [MaxLength(10)]
        public string Telefono { get; set; }
        [MaxLength(200)]
        public string Direccion { get; set; }
        
    }
}
