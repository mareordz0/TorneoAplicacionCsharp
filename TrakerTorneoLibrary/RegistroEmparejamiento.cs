using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrakerTorneoLibrary
{
    public class RegistroEmparejamiento
    {
        /// <summary>
        /// Representa un equipo en el enfrentamiento
        /// </summary>
        public EquipoTorneo EquipoRegistrado { get; set; }
        /// <summary>
        /// Resultado de un equipo en particular
        /// </summary>
        public double Puntaje { get; set; }
        /// <summary>
        /// El enfrentamiento del equipo
        /// </summary>
        public Emparejamiento VersusEmparejamiento { get; set; }
    }
}
