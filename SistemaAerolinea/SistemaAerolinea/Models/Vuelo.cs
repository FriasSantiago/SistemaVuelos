using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaAerolinea.Models
{
    [Table("Vuelos")]
    public class Vuelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VueloId { get; set; }
        [Required]
        public string Origen { get; set; }
        [Required]
        public string Destino { get; set; }
        [Required] //Display format
        public DateTime HoraFechaSalida { get; set; }
        [Required]
        public DateTime HoraFechaLlegada { get; set; }
        [Required]
        public int Duracion { get; set; }
        [Required]
        public int AsientosDisponibles { get; set; }
        [Required]
        public float CostoPasaje { get; set; }

    }
}