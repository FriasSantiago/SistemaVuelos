using System;
using System.Collections.Generic;
using System.Linq;
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
    public class ReservaController : Controller
    {
        private readonly UserManager<Usuario> userManager;
        private readonly IRepoReservas repoReservas;
        private readonly IRepoVuelos repoVuelo;

        public ReservaController(UserManager<Usuario> userManager, IRepoReservas repoReservas,
                                    IRepoVuelos repoVuelo)
        {
            this.userManager = userManager;
            this.repoReservas = repoReservas;
            this.repoVuelo = repoVuelo;
        }

        [HttpPost]
        [Authorize]
        public IActionResult Reservar()
        {
            var datosReserva = JsonConvert.DeserializeObject<VueloViewModel>(HttpContext.Session.GetString("datos"));

            var model = new Reserva()
            {
                UsuarioId = datosReserva.Usuario.Id,
                VueloId = datosReserva.Vuelo.VueloId,
                EstadoReserva = "Reservado"
            };

            if (repoReservas.RegistrarReserva(model))
            {
                return RedirectToAction("Reserva", model);
            } else
            {
                return View("Error");
            }

            
        }

        [Authorize]
        public async Task<IActionResult> Reserva()
        {

            var usuario = await userManager.FindByNameAsync(User.Identity.Name);

            List<Reserva> reservas = repoReservas.GetReservasUsuario(usuario.Id);
            reservas.ForEach(res =>
            {
                res.Vuelo = repoVuelo.FindVueloById(res.VueloId);
            });
            return View(reservas);

        }

        [Authorize]
        [HttpPost]
        public IActionResult Borrar(int reservaId)
        {
            bool result = repoReservas.BorrarReserva(reservaId);

            if (result)
            {
                return RedirectToAction("Reserva");
            }

            return RedirectToAction("Error", "Home");
        }

    }
}