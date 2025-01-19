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

            factory.AddCar(new Car(1, "Large"));
            factory.AddCar(new Car(2, "Medium"));
            factory.AddCar(new Car(3, "Small"));

            factory.AddCustomer(new Customer("Alice"));
            factory.AddCustomer(new Customer("Bob"));
            factory.AddCustomer(new Customer("Charlie"));

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
