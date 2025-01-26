using Dz02_kpo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz02_kpo.Services
{
    public class CustomerStorage : ICustomersProvider
    {
        private List<Customer> Customers { get; set; } = new List<Customer>();

        public void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }

        public List<Customer> GetCustomers()
        {
            return Customers;
        }
    }
}
