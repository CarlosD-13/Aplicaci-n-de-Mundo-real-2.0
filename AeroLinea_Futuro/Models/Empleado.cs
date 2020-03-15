using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AeroLinea_Futuro.Models
{
    public class Empleado
    {
        [Key]
        public int EmpleadoID  { get; set; }

        [Column (TypeName= "Varchar(40)")]
        [Required]
        public string Nombre { get; set; }

        [Column(TypeName = "Varchar(20)")]
        [Required]
        public string Cargo { get; set; }

        [Column(TypeName = "Varchar(10)")]
        [Required]
        public string Sueldo { get; set; }
    }
}
