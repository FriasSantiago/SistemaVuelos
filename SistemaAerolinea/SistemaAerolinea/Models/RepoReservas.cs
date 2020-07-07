using SistemaAerolinea.Context;
using SistemaAerolinea.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAerolinea.Models
{
    public class RepoReservas : IRepoReservas
    {

        private readonly AerolineaDbContext _context;
        private readonly IRepoVuelos repoVuelos;

        public RepoReservas(AerolineaDbContext context, IRepoVuelos repoVuelos)
        {
            _context = context;
            this.repoVuelos = repoVuelos;
        }

        public bool BorrarReserva(int idReserva)
        {
            bool borrado = false;

            Reserva res = _context.Reservas.Where(reserva => reserva.ReservaId == idReserva).FirstOrDefault<Reserva>();

            if (res != null)
            {
                _context.Reservas.Remove(res);
                UpdateAsientos(res.VueloId, true);
                _context.SaveChanges();
                borrado = true;
            }

            return borrado;
        }

        public List<Reserva> GetReservasUsuario(string id)
        {
            return _context.Reservas
             .Where(usuario => id == usuario.UsuarioId)
             .ToList();
        }

        public bool RegistrarReserva(Reserva reserva)
        {

            var vuelo = repoVuelos.FindVueloById(reserva.VueloId);

            if (vuelo.AsientosDisponibles > 0)
            {
                _context.Add(reserva);
                UpdateAsientos(reserva.VueloId, false);
                _context.SaveChanges();
                return true;
            }
            
            return false;
        }

        public void UpdateAsientos(int idVuelo, bool esBorrar)
        {
            var vuelo = _context.Vuelos.FirstOrDefault(vuelo => vuelo.VueloId == idVuelo);

            if (esBorrar)
            {
                vuelo.AsientosDisponibles++;
            } else
            {
                vuelo.AsientosDisponibles--;
            }

            _context.Vuelos.Update(vuelo);
        }

    }
}
