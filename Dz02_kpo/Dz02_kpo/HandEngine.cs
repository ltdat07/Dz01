using Dz02_kpo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo
{
    public class HandEngine : IEngine
    {
        public bool IsCompatible(Customer customer)
        {
            return customer.ArmStrength > 5;
        }

        public string GetEngineType()
        {
            return "Hand Engine";
        }

        public override string ToString()
        {
            return GetEngineType();
        }
    }
}
