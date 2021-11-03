using System;
using System.Collections.Generic;

#nullable disable

namespace Finding_a_Tournament.Domain.Entities
{
    public partial class Club
    {
        public int IdClub { get; set; }
        public string NombreClub { get; set; }
        public string Direccion { get; set; }
        public string TelefonoContacto { get; set; }
        public double Geoubicacion { get; set; }
        public string Logotipo { get; set; }
    }
}
