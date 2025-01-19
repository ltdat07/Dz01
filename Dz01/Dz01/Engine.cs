using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz01
{
    class Engine
    {
        public string PedalSize { get; private set; }

        public Engine(string pedalSize)
        {
            PedalSize = pedalSize;
        }
    }
}
