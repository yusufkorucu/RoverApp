using RoverApp.Classes.Plato.Interface;
using RoverApp.Classes.Position.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverApp.Classes.Plato
{
    public class Plato : IPlato
    {
        public Position.Position PlatoPosition { get; set; }

        public Plato(Position.Position platoPosition)
        {
            PlatoPosition = platoPosition;
        }
    }
}
