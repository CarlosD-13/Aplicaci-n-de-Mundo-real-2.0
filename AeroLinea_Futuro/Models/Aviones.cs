using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AeroLinea_Futuro.Models
{
    public class Aviones
    {
        [Key]
        public int AvionID { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        public string Fabricante { get; set; }

        [Column(TypeName = "varchar(20)")]
        [Required]
        public string Modelo { get; set; }

        [Column(TypeName = "int")]
        [Required]
        public int Capacidad { get; set; }
    }
}
