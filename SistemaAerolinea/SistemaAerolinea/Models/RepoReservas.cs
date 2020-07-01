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

        public RepoReservas(AerolineaDbContext context)
        {
            _context = context;
        }

        public bool BorrarReserva(int idReserva)
        {
            bool borrado = false;

            Reserva res = _context.Reservas.Where(reserva => reserva.ReservaId == idReserva).FirstOrDefault<Reserva>();

            if (res != null)
            {
                _context.Reservas.Remove(res);
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

        public void RegistrarReserva(Reserva reserva)
        {
            _context.Add(reserva);
            _context.SaveChanges();
        }
    }
}
