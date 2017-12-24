using System;

namespace CleanCode.NestedConditionals
{
    public class Customer
    {
        public int LoyaltyPoints { get; set; }
    }

    public class Reservation
    {
        public Reservation(Customer customer, DateTime dateTime)
        {
            From = dateTime;
            Customer = customer;
        }

        public DateTime From { get; set; }
        public Customer Customer { get; set; }
        public bool IsCanceled { get; set; }

        public void Cancel()
        {
            if (DateTime.Now > From)
            {
                throw new InvalidOperationException("It's too late to cancel.");
            }

            // Gold customers can cancel up to 24 hours before

            if (Customer.LoyaltyPoints > 100 && LessThen(maxHours: 24))
            {
                // If reservation already started throw exception
                    throw new InvalidOperationException("It's too late to cancel.");
            }
            // Regular customers can cancel up to 48 hours before

            // If reservation already started throw exception
            if (Customer.LoyaltyPoints <= 100 && LessThen(maxHours: 48))
            {
                throw new InvalidOperationException("It's too late to cancel.");
            }

            IsCanceled = true;
        }

        private bool LessThen(int maxHours)
        {
            return (From - DateTime.Now).TotalHours < maxHours;
        }
    }
}
