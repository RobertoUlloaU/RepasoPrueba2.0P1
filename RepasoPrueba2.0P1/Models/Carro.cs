using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepasoPrueba2._0P1.Models
{
    public class Carro
    {
        [Key]
        [MaxLength(7)]
        public string Placa { get; set; }
        public double Cilindraje { get; set; }
        [MaxLength(50)]
        public string Modelo { get; set; }
        public string PropietarioIdentificacion { get; set; }

        [ForeignKey("PropietarioIdentificacion")]
        public string? Propietario {  get; set; }

    }
}
