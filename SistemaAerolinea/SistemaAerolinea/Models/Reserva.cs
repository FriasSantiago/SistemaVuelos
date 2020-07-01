using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaAerolinea.Models
{
    [Table("Reservas")]
    public class Reserva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ReservaId { get; set; }
        [ForeignKey("Usuario")]
        public string UsuarioId { get; set; }
        [ForeignKey("Vuelo")]
        public int VueloId { get; set; }
        [Required]
        public string EstadoReserva { get; set; }

        public Vuelo Vuelo { get; set; }            
        public Usuario Usuario { get; set; }
        
    }
}
