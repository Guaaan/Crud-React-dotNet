using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dotnetApi.Models
{
    public class Ciudad_Bd
    {
        [Key]

        public int RegionCodigo { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }
}