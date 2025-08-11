using System;

namespace CSE325_team.Services
{
    public class BookingState
    {
        public int VehicleId { get; set; }
        public string? VehicleDisplay { get; set; }
        public decimal DailyRate { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public string? PaymentMethod { get; set; }
        public string? CustomerName { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Tax { get; set; }
        public string? UserId { get; set; }
    }
}