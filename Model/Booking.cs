using System;
using CSE325_team.Data;

namespace CSE325_team.Model
{
    public class Booking
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int CarId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal TotalPrice { get; set; }

        public ApplicationUser User { get; set; }
        public Car Car { get; set; }
    }
}
