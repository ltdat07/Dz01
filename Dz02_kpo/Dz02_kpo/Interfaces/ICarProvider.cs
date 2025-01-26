using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo.Interfaces
{
    public interface ICarProvider
    {
        Car FindSuitableCar(Customer customer);
    }
}
