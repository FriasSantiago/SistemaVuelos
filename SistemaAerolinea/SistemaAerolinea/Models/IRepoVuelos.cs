using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAerolinea.Models
{
    public interface IRepoVuelos
    {
        List<Vuelo> GetAllVuelos();
        Vuelo FindVueloById(int id);
        List<Vuelo> BuscarVuelo(string origen, string destino, DateTime fechaSalida);
    }
}
