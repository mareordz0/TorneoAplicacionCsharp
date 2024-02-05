using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakerTorneoLibrary
{
    public class Emparejamiento
    {
        public List<RegistroEmparejamiento> Registros { get; set; } = new List<RegistroEmparejamiento>();
        public EquipoTorneo Ganador { get; set; }
        public int EmparejamientoRound { get; set; }

    }
}
