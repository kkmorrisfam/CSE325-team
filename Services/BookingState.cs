using CSE325_team.Models;

namespace CSE325_team.Services
{
    public class BookingState
    {
        public Vehicle? SelectedVehicle { get; set; }
        public int VehicleId { get; set; }
        public DateTime PickupDate { get; set; }
        public DateTime DropOffDate { get; set; }
        public decimal TotalPrice { get; set; }

        public void Clear()
        {
            SelectedVehicle = null;
            VehicleId = 0;
            PickupDate = default;
            DropOffDate = default;
            TotalPrice = 0;
        }
    }
}