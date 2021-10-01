using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotnetApi.Models
{
    public class Comuna
    {
        [Key]
        public int RegionCodigo { get; set; }
        public int CiudadCodigo { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int CodigoPostal { get; set; }
        public int COdigoLibroClaseElectronico { get; set; }
    }
}