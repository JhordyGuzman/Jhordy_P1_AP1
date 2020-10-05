using System;
using System.ComponentModel.DataAnnotations;

namespace Jhordy_P1_AP1.Entidades
{
    public class Ciudades
    {
        [Key]
        public int CiudadId { get; set; }

        public String Nombre { get; set; }

        
    }
}