using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz01
{
    class Customer
    {
        public string Name { get; private set; }
        public Car PurchasedCar { get; private set; }

        public Customer(string name)
        {
            Name = name;
            PurchasedCar = null;
        }

        public void AssignCar(Car car)
        {
            PurchasedCar = car;
        }

        public override string ToString()
        {
            return PurchasedCar == null
                ? $"Customer: {Name}, No car purchased"
                : $"Customer: {Name}, Purchased: {PurchasedCar}";
        }
    }
}
