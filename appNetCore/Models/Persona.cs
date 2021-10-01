using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace dotnetApi.Models
{
        [Table("Persona")]
    public class Persona
    {
        [Key]
        public Guid Id { get; set; }
#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public string? Run { get; }
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
        public int? RunCuerpo { get; set; }
        public string? RunDigito { get; set; }
        public string? Nombre { get; }
        public string? Nombres { get; set; }
        public string? ApellidoPaterno { get; set; }
        public string? ApellidoMaterno { get; set; }
        public string? Email { get; set; }
        public Int16? SexoCodigo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public Int16? RegionCodigo { get; set; }
        public Int16? CiudadCodigo { get; set; }
        public Int16? ComunaCodigo { get; set; }
        public string? Direccion { get; set; }
        public int? Telefono { get; set; }
        public string? Observaciones { get; set; }
    }
}