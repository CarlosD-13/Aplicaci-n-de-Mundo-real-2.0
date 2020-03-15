using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AeroLinea_Futuro.Models
{
    public class AvionesContext : DbContext
    {
        public AvionesContext(DbContextOptions<AvionesContext> options):base(options)
        {
        }
        public DbSet<Aviones> Aviones { get; set; }
    }
}
