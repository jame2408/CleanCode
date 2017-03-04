using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.OutputParameters
{
    public class OutputParameters
    {
        public void DisplayCustomers()
        {
            int totalCount = 0;
            var customers = GetCustomers(1, out totalCount);

            Console.WriteLine("Total customers: " + totalCount);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private IEnumerable<Customer> GetCustomers(int pageIndex, out int totalCount)
        {
            totalCount = 100;
            return new List<Customer>();
        }
    }

    public class Customer
    {
        public string name { get; set; }
        public string age { get; set; }
        public string phone { get; set; }
    }


}
