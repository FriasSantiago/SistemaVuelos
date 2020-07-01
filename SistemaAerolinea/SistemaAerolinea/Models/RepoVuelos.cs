using SistemaAerolinea.Context;
using SQLitePCL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAerolinea.Models
{
    public class RepoVuelos : IRepoVuelos {


        private readonly AerolineaDbContext _context;

        public RepoVuelos(AerolineaDbContext context)
        {
            _context = context;
        }

        public List<Vuelo> BuscarVuelo(string origen, string destino, DateTime fechaSalida)
        {
            return _context.Vuelos
                .Where(vuelo => vuelo.Origen == origen && vuelo.Destino == destino && vuelo.HoraFechaSalida.Date == fechaSalida.Date)
                .ToList();
        }

        public Vuelo FindVueloById(int id)
        {
            return _context.Vuelos.Where(vuelo => vuelo.VueloId == id).FirstOrDefault();
        }

        public List<Vuelo> GetAllVuelos()
        {
            return _context.Vuelos.ToList();
        }



    }
}
