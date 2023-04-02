namespace ParkingLot
{
    public class Vehicle
    {
        private readonly string RegNumber;
        private readonly string Color;
        public Vehicle(string regNumber, string color)
        {
            this.RegNumber = regNumber;
            this.Color = color;
        }
        public string GetRegNumber()
        {
            return this.RegNumber;
        }
        public string GetColor()
        {
            return this.Color;
        }
    }
}