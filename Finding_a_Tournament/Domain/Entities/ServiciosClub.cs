using System;
using System.Collections.Generic;

#nullable disable

namespace Finding_a_Tournament.Domain.Entities
{
    public partial class ServiciosClub
    {
        public int IdServicio { get; set; }
        public string Diciplina { get; set; }
        public string HorarioDiciplina { get; set; }
        public int CantidadPer { get; set; }
        public bool PersHabilidadesDiferentes { get; set; }
        public int IdClub { get; set; }
    }
}
