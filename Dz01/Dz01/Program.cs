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

            // Добавляем автомобили на склад
            factory.AddCar(new Car(1, "Large"));
            factory.AddCar(new Car(2, "Medium"));
            factory.AddCar(new Car(3, "Small"));

            // Добавляем клиентов
            factory.AddCustomer(new Customer("Alice"));
            factory.AddCustomer(new Customer("Bob"));
            factory.AddCustomer(new Customer("Charlie"));

            // Отображаем начальное состояние
            Console.WriteLine("Initial state:");
            factory.ShowInventory();
            factory.ShowCustomers();

            // Обрабатываем продажи
            factory.ProcessSales();

            // Отображаем финальное состояние
            Console.WriteLine("\nFinal state:");
            factory.ShowInventory();
            factory.ShowCustomers();
        }
    }
}
