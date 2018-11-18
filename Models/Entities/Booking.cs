using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

        public int TableGroupId { get; set; }
        public Link TableGroup { get; set; }

        public DateTime Date { get; set; }

        public int ExpectedlHour { get; set; }
        public int ExpectedTime { get; set; }

        public int ArrivalHour { get; set; }
        public int ArrivalTime { get; set; }

        public bool DidShow { get; set; }
        public bool WasLate { get; set; }

        public int ExpectedGuests { get; set; }
        public int ActualGuests { get; set; }
    }
}