using Dz02_kpo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo
{
    public class PedalEngine : IEngine
    {
        public string PedalSize { get; private set; }

        public PedalEngine(string pedalSize)
        {
            PedalSize = pedalSize;
        }

        public bool IsCompatible(Customer customer)
        {
            return customer.LegStrength > 5;
        }

        public string GetEngineType()
        {
            return "Pedal Engine";
        }

        public override string ToString()
        {
            return GetEngineType() + " (Pedal Size: " + PedalSize + ")";
        }
    }
}
