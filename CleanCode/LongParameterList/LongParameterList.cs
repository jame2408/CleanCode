
using System;
using System.Collections.Generic;

namespace CleanCode.LongParameterList
{
    public class DateRange
    {
        public DateRange(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
        }

        public DateTime DateFrom { get; private set; }
        public DateTime DateTo { get; private set; }
    }

    public class ReservationsQuery
    {
        private int? _customerId;
        private LocationType _locationType;
        private int _locationId;
        private User _user;
        private DateRange _dateRange;

        public int? CustomerId { get { return _customerId; } }
        public LocationType LocationType { get { return _locationType; } }
        public int LocationId { get { return _locationId; } }
        public User User { get { return _user; } }
        public DateRange DateRange { get { return _dateRange; } }

        public ReservationsQuery(DateRange dateRange, User user, int locationId, LocationType locationType, int? customerId = null)
        {
            _dateRange = dateRange;
            _user = user;
            _locationId = locationId;
            _locationType = locationType;
            _customerId = customerId;
        }
    }

    public class LongParameterList
    {
        public IEnumerable<Reservation> GetReservations(ReservationsQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public IEnumerable<Reservation> GetUpcomingReservations(ReservationsQuery query)
        {
            if (query.DateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (query.DateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        private static Tuple<DateTime, DateTime> GetReservationDateRange(
            DateRange dateRange, ReservationDefinition sd)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }

        public void CreateReservation(DateRange dateRange, int locationId)
        {
            if (dateRange.DateFrom >= DateTime.Now)
                throw new ArgumentNullException("dateFrom");
            if (dateRange.DateTo <= DateTime.Now)
                throw new ArgumentNullException("dateTo");

            throw new NotImplementedException();
        }
    }

    internal class ReservationDefinition
    {
    }

    public class LocationType
    {
    }

    public class User
    {
        public object Id { get; set; }
    }

    public class Reservation
    {
    }
}
