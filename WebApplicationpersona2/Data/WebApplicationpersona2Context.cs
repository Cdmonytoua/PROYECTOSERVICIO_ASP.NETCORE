using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationpersona2.Modelo;

namespace WebApplicationpersona2.Data
{
    public class WebApplicationpersona2Context : DbContext
    {
        public WebApplicationpersona2Context (DbContextOptions<WebApplicationpersona2Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationpersona2.Modelo.Persona> Persona { get; set; }
    }
}
