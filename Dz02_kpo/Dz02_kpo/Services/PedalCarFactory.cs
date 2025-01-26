using Dz02_kpo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo.Services
{
    public class PedalCarFactory : ICarFactory<PedalEngineParams>
    {
        public Car CreateCar(PedalEngineParams parameters, int serialNumber)
        {
            return new Car(serialNumber, new PedalEngine(parameters.PedalSize));
        }
    }
}
