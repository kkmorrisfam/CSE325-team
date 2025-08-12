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

        public void Reset()
        {
            VehicleId = 0;
            VehicleDisplay = string.Empty;
            DailyRate = 0;
            PickupDate = DateTime.MinValue;
            DropOffDate = DateTime.MinValue;
            PaymentMethod = string.Empty;
            CustomerName = string.Empty;
            TotalPrice = 0;
            Subtotal = 0;
            Tax = 0;
        }
        public string? UserId { get; set; }
    }
}