using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz01
{
    class Car
    {
        public int SerialNumber { get; private set; }
        public Engine Engine { get; private set; }

        public Car(int serialNumber, string pedalSize)
        {
            SerialNumber = serialNumber;
            Engine = new Engine(pedalSize);
        }

        public override string ToString()
        {
            return $"Car ID: {SerialNumber}, Engine Pedal Size: {Engine.PedalSize}";
        }
    }
}
