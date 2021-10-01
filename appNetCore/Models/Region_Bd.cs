using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotnetApi.Models
{
    public class Region_Bd
    {
        [Key]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreOficial { get; set; }
        public int CodigoLibroClaseElectrónico { get; set; }
    }
}