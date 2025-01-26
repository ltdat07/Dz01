using Dz02_kpo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo.Services
{
    public class CarService : ICarProvider
    {
        private List<Car> Cars { get; set; } = new List<Car>();

        public Car FindSuitableCar(Customer customer)
        {
            var car = Cars.FirstOrDefault(c => c.IsCompatible(customer));
            if (car != null)
            {
                Cars.Remove(car);
            }
            return car;
        }

        public void AddCar<TParams>(ICarFactory<TParams> factory, TParams parameters)
        {
            int serialNumber = Cars.Count + 1; // Генерация номера автомобиля
            Cars.Add(factory.CreateCar(parameters, serialNumber));
        }

        public void ShowInventory()
        {
            Console.WriteLine("Cars in inventory:");
            if (!Cars.Any())
            {
                Console.WriteLine("No cars available.");
            }
            else
            {
                foreach (var car in Cars)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
