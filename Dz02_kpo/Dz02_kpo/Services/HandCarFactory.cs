using Dz02_kpo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo.Services
{
    public class HandCarFactory : ICarFactory<EmptyEngineParams>
    {
        public Car CreateCar(EmptyEngineParams parameters, int serialNumber)
        {
            return new Car(serialNumber, new HandEngine());
        }
    }
}
