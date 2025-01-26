using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo
{
    public class Customer
    {
        public string Name { get; private set; }
        public int LegStrength { get; private set; }
        public int ArmStrength { get; private set; }
        public Car PurchasedCar { get; private set; }

        public Customer(string name, int legStrength, int armStrength)
        {
            Name = name;
            LegStrength = legStrength;
            ArmStrength = armStrength;
            PurchasedCar = null;
        }

        public void AssignCar(Car car)
        {
            PurchasedCar = car;
        }

        public override string ToString()
        {
            return PurchasedCar == null
                ? $"Customer: {Name}, Leg Strength: {LegStrength}, Arm Strength: {ArmStrength}, No car purchased"
                : $"Customer: {Name}, Leg Strength: {LegStrength}, Arm Strength: {ArmStrength}, Purchased: {PurchasedCar}";
        }
    }
}
