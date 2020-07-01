using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SistemaAerolinea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAerolinea.Context
{
    // Extiende al DbContext de Identity y registra el modelo de usuario que se va a guardar
    public class AerolineaDbContext : IdentityDbContext<Usuario>
    {
        public AerolineaDbContext(DbContextOptions<AerolineaDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Vuelo>().HasData(
                new Vuelo()
                {
                    VueloId = 1,
                    Origen = "Buenos Aires",
                    Destino = "Barcelona",
                    HoraFechaSalida = DateTime.Now,
                    HoraFechaLlegada = DateTime.Now,
                    Duracion = 100,
                    CostoPasaje = 20000,
                    AsientosDisponibles = 200

                },

                new Vuelo()
                {
                    VueloId = 2,
                    Origen = "Buenos Aires",
                    Destino = "Berlin",
                    HoraFechaSalida = DateTime.Now,
                    HoraFechaLlegada = DateTime.Now,
                    Duracion = 100,
                    CostoPasaje = 50000,
                    AsientosDisponibles = 200
                },

                new Vuelo()
                {
                    VueloId = 3,
                    Origen = "Buenos Aires",
                    Destino = "Nueva York",
                    HoraFechaSalida = DateTime.Now,
                    HoraFechaLlegada = DateTime.Now,
                    Duracion = 100,
                    CostoPasaje = 22000,
                    AsientosDisponibles = 200

                },

                new Vuelo()
                {
                    VueloId = 4,
                    Origen = "Buenos Aires",
                    Destino = "San Diego",
                    HoraFechaSalida = DateTime.Now,
                    HoraFechaLlegada = DateTime.Now,
                    Duracion = 100,
                    CostoPasaje = 18000,
                    AsientosDisponibles = 200

                }

            );
        }

        // Representa una tabla de la BBDD
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vuelo> Vuelos { get; set; }
        public DbSet<Reserva> Reservas { get; set; }

    }
}
