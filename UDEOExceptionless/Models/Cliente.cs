using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CiudadDollar.Models
{
    public class Cliente
    {
        public int CLienteId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public string Departamento { get; set; }
        [Required]
        public string Ciudad { get; set; }
        [Required]
        public string Tipodonacion { get; set; }
        
        
    }
}
