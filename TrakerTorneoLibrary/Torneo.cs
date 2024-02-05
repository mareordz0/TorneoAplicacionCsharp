using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakerTorneoLibrary
{
    class Torneo
    {
        public string NombreTorneo { get; set; }
        public decimal EntradaFree { get; set; }
        public List<EquipoTorneo> AsigEquipos { get; set; } = new List<EquipoTorneo>();
        public List<Premio> Premios { get; set; } = new List<Premio>();
        public List<List<Emparejamiento>> Rounds { get; set; } = new List<List<Emparejamiento>>();
    }
}
