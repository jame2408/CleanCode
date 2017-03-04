using System;
using System.Collections.Generic;

namespace CleanCode.OutputParameters
{
    public class OutputParameters
    {
        public class GetCustomersResult
        {
            public IEnumerable<Customer> Customers { get; set; }
            public int TotalCount { get; set; }
        }

        public void DisplayCustomers()
        {
            int totalCount = 0;
            var result = GetCustomers(1);
            totalCount = result.TotalCount;
            var customers = result.Customers;

            Console.WriteLine("Total customers: " + totalCount);
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        private GetCustomersResult GetCustomers(int pageIndex)
        {
            var totalCount = 100;
            return new GetCustomersResult() { Customers = new List<Customer>(), TotalCount = totalCount };
        }
    }

    public class Customer
    {
        public string name { get; set; }
        public string age { get; set; }
        public string phone { get; set; }
    }


}
