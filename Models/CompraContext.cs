using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pc03.Controllers;

namespace pc03.Models
{
    public class CompraContext : DbContext
    {
        // Entidades
        public DbSet<SolicitudCompra> SolicitudCompra {get; set;}
        public DbSet<Usuario> Clientes {get; set;}

        // Constructor
        public CompraContext(DbContextOptions dco) : base(dco){

        }
    }
}