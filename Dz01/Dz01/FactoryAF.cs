using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz01
{
    class FactoryAF
    {
        private List<Car> Cars { get; set; } = new List<Car>();
        private List<Customer> CustomersQueue { get; set; } = new List<Customer>();

        public void AddCar(Car car)
        {
            Cars.Add(car);
        }

        public void AddCustomer(Customer customer)
        {
            CustomersQueue.Add(customer);
        }

        public void SaleCar()
        {
            foreach (var customer in CustomersQueue.Where(c => c.PurchasedCar == null))
            {
                if (Inventory.Any())
                {
                    customer.AssignCar(Inventory[0]);
                    Inventory.RemoveAt(0);
                }
                else
                {
                    break;
                }
            }

            if (Inventory.Any())
            {
                Inventory.Clear();
                Console.WriteLine("Remaining cars have been cleared from inventory.");
            }
        }

        public void ShowInventory()
        {
            Console.WriteLine("Current inventory of cars:");
            if (!Inventory.Any())
            {
                Console.WriteLine("No cars available.");
            }
            else
            {
                foreach (var car in Inventory)
                {
                    Console.WriteLine(car);
                }
            }
        }

        public void ShowCustomers()
        {
            Console.WriteLine("List of customers:");
            foreach (var customer in WaitingList)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
