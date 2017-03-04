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
            var tuple = GetCustomers(1);
            totalCount = tuple.Item2;
            var customers = tuple.Item1;

            Console.WriteLine("Total customers: " + totalCount);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private Tuple<IEnumerable<Customer>, int> GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return Tuple.Create((IEnumerable<Customer>) new List<Customer>(), totalCount);
        }
    }

    public class Customer
    {
        public string name { get; set; }
        public string age { get; set; }
        public string phone { get; set; }
    }


}
