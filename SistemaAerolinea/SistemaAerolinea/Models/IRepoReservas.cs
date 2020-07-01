using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAerolinea.Models
{
    public interface IRepoReservas
    {
        void RegistrarReserva(Reserva reserva);
        List<Reserva> GetReservasUsuario(String id);
        bool BorrarReserva(int idReserva);
    }
}
