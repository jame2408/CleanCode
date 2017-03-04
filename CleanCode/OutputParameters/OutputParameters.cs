using System;
using System.Collections.Generic;

namespace CleanCode.OutputParameters
{
    public class OutputParameters
    {
        public class GetCustomersResult
        {
            public IEnumerable<Customer> Item1 { get; set; }
            public int Item2 { get; set; }
        }

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

        private GetCustomersResult GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return new GetCustomersResult() { Item1 = new List<Customer>(), Item2 = totalCount };
        }
    }

    public class Customer
    {
        public string name { get; set; }
        public string age { get; set; }
        public string phone { get; set; }
    }


}
