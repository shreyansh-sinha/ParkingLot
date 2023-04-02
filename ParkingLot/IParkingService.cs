namespace ParkingLot
{
    public interface IParkingService
    {
        public void CreateParkingLot(int level, int capacity);
        public int? Park(int level, Vehicle vehicle);
        public void UnPark(int level, int slotNumber);
        public void GetStatus(int level);
        public int? GetSlotsAvailableCount(int level);
        public void GetRegNumberForColor(int level, String color);
        public void GetSlotNumbersFromColor(int level, String colour);
        public int GetSlotNoFromRegistrationNo(int level, String registrationNo);
    }
}