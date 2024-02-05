using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakerTorneoLibrary
{
    public class EquipoTorneo
    {
        public List<PersonaTorneo> EquipoMiembros { get; set; } = new List<PersonaTorneo>();
        public string NombreEquipo { get; set; }

    }
}
