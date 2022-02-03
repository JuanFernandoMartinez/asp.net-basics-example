#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ejemplo.Models;

namespace Ejemplo.Data
{
    public class EjemploContext : DbContext
    {
        public EjemploContext (DbContextOptions<EjemploContext> options)
            : base(options)
        {
        }

        public DbSet<Ejemplo.Models.Item> Item { get; set; }
    }
}
