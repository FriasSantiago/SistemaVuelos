using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SistemaAerolinea.Models;
using SistemaAerolinea.ViewModels;

namespace SistemaAerolinea.Controllers
{

    public class VueloController : Controller
    {
        private readonly IRepoVuelos repo;
        private readonly UserManager<Usuario> userManager;

        public VueloController(IRepoVuelos repo, UserManager<Usuario> userManager)
        {
            this.repo = repo;
            this.userManager = userManager;
        }

        public IActionResult Index(string origen, string destino, DateTime fechaSalida)    
        {
            List<Vuelo> vuelos = repo.BuscarVuelo(origen, destino, fechaSalida);
            
            if (vuelos.Count > 0)
            {
                return View(vuelos);
            }

            return View("VueloNoEncontrado");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Comprar(int idVuelo)
        {

            var vuelo = repo.FindVueloById(idVuelo);

            if (idVuelo > 0 && vuelo != null)
            {

                var usuario = await userManager.GetUserAsync(User);

                var model = new VueloViewModel()
                {
                    Usuario = usuario,
                    Vuelo = vuelo
                };

                HttpContext.Session.SetString("datos", JsonConvert.SerializeObject(model));
                return View(model);
            }

            return View("VueloNoEncontrado");
        }
    }
}