using System;

namespace CSE325_team.Services
{
    public class BookingState
    {
        public int VehicleId { get; set; }
        public DateTime? PickUpDate { get; set; }
        public DateTime? DropOffDate { get; set; }

        public void Set(int vehicleId, DateTime? pickUp, DateTime? dropOff)
        {
            VehicleId = vehicleId;
            PickUpDate = pickUp;
            DropOffDate = dropOff;
        }

        public void Clear()
        {
            VehicleId = 0;
            PickUpDate = null;
            DropOffDate = null;
        }
    }
}