using SistemaAerolinea.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAerolinea.ViewModels
{
    public class VueloViewModel
    {
        public Usuario Usuario { get; set; }
        public Vuelo Vuelo { get; set; }
    }
}
