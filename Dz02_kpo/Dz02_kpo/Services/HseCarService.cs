using Dz02_kpo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo.Services
{
    public class HseCarService
    {
        private readonly ICarProvider _carProvider;
        private readonly ICustomersProvider _customersProvider;

        public HseCarService(ICarProvider carProvider, ICustomersProvider customersProvider)
        {
            _carProvider = carProvider;
            _customersProvider = customersProvider;
        }

        public void SellCars()
        {
            var customers = _customersProvider.GetCustomers();
            foreach (var customer in customers)
            {
                if (customer.PurchasedCar == null)
                {
                    var car = _carProvider.FindSuitableCar(customer);
                    if (car != null)
                    {
                        customer.AssignCar(car);
                        Console.WriteLine($"{customer.Name} purchased {car}");
                    }
                    else
                    {
                        Console.WriteLine($"{customer.Name} could not find a suitable car.");
                    }
                }
            }
        }
    }
}
