using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SistemaAerolinea.Models;
using SistemaAerolinea.ViewModels;

namespace SistemaAerolinea.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<Usuario> userManager;
        private readonly SignInManager<Usuario> signInManager;

        public AccountController(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Registrar(RegistrarViewModel model)
        {
            // Valida los datos ingresados
            if (ModelState.IsValid)
            {
                // Crea una nueva instancia de usuario y le asigna los valores pasados en el modelo
                var usuario = new Usuario()
                {
                    UserName = model.Usuario,
                    Nombre = model.Nombre,
                    Apellido = model.Apellido,
                    Email = model.Email,
                    PhoneNumber = model.Telefono
                };

                // Usa userManager para crear un nuevo usuario y guardarlo en la BBDD
                var resultado = await userManager.CreateAsync(usuario, model.Pwd);

                // Evalua el resultado del registro del nuevo usuario
                if (resultado.Succeeded)
                {
                    // Si es valido lo loguea (isPersistent es para las cookies)
                    await signInManager.SignInAsync(usuario, isPersistent: false);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // En caso de haber error, los agrega al ModelState antes de volver a la vista
                    foreach (var error in resultado.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                }
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            TempData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            // Log In del usuario en base a los datos del modelo
            var resultado = await signInManager.PasswordSignInAsync(model.Usuario, model.Pwd, isPersistent: false, false);

            var url = TempData["returnUrl"];

            if (url != null)
            {
                return LocalRedirect(TempData["returnUrl"].ToString());
            }

            if (resultado.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                // Si no se pudo loguear devuelve este error
                ModelState.AddModelError("", "Los datos ingresados son incorrectos");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}