using Dz02_kpo;
using Dz02_kpo.Services;
using Dz02_kpo.Services;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        CarService carService = new CarService();
        CustomerStorage customerStorage = new CustomerStorage();
        HseCarService hseCarService = new HseCarService(carService, customerStorage);
        PedalCarFactory pedalFactory = new PedalCarFactory();
        HandCarFactory handFactory = new HandCarFactory();

        // Добавляем покупателей
        customerStorage.AddCustomer(new Customer("Alicia", 6, 4));
        customerStorage.AddCustomer(new Customer("Bobop", 4, 6));
        customerStorage.AddCustomer(new Customer("MJ", 6, 6));
        customerStorage.AddCustomer(new Customer("Dav", 4, 4));

        // Добавляем автомобили
        carService.AddCar(pedalFactory, new PedalEngineParams { PedalSize = "Large" });
        carService.AddCar(pedalFactory, new PedalEngineParams { PedalSize = "Medium" });
        carService.AddCar(handFactory, EmptyEngineParams.DEFAULT);
        carService.AddCar(handFactory, EmptyEngineParams.DEFAULT);

        // Вывод информации о покупателях и их автомобилях
        Console.WriteLine("Initial Customers State:");
        foreach (var customer in customerStorage.GetCustomers())
        {
            Console.WriteLine(customer);
        }

        // Реализация процесса продажи автомобилей
        hseCarService.SellCars();

        // Вывод информации о покупателях и их автомобилях после продажи
        Console.WriteLine("\nFinal Customers State:");
        foreach (var customer in customerStorage.GetCustomers())
        {
            Console.WriteLine(customer);
        }
    }
}
