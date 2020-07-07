using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAerolinea.Models
{
    public interface IRepoReservas
    {
        bool RegistrarReserva(Reserva reserva);
        List<Reserva> GetReservasUsuario(String id);
        bool BorrarReserva(int idReserva);
        void UpdateAsientos(int idVuelo, bool esBorrar);
    }
}
