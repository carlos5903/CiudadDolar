using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UDEOExceptionless.Models
{
    public class Donaciones
    {

        public int IdDonacion{ get; set; }
        [Required]
        public string Monto { get; set; }
        [Required]
        public string TipoDonacion { get; set; }
        [Required]
       

    }
}