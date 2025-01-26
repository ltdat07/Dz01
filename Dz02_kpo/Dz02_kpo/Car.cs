using Dz02_kpo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo
{
    public class Car
    {
        public int SerialNumber { get; private set; }
        public IEngine Engine { get; private set; }

        public Car(int serialNumber, IEngine engine)
        {
            SerialNumber = serialNumber;
            Engine = engine;
        }

        public bool IsCompatible(Customer customer)
        {
            return Engine.IsCompatible(customer);
        }

        public override string ToString()
        {
            return $"Car #{SerialNumber}, Engine: {Engine}";
        }
    }
}
