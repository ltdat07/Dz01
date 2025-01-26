using System;
using System.Collections.Generic;
using System.Linq;

namespace Dz01
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryAF factory = new FactoryAF();

            factory.AddCar(new Car(1, "Bolshoi"));
            factory.AddCar(new Car(2, "Sredni"));
            factory.AddCar(new Car(3, "Malenki"));

            factory.AddCustomer(new Customer("Denis"));
            factory.AddCustomer(new Customer("Tom"));
            factory.AddCustomer(new Customer("MJ"));

            Console.WriteLine("Initial state:");
            factory.ShowCars();
            factory.ShowCustomers();

            factory.SaleCar();

            Console.WriteLine("\nFinal state:");
            factory.ShowCars();
            factory.ShowCustomers();
        }
    }
}
