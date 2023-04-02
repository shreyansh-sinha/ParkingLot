using Microsoft.VisualBasic;

namespace ParkingLot
{
    public class RequestProcessor
    {
        private readonly IParkingService parkingService;
        public RequestProcessor(IParkingService parkingService)
        {
            this.parkingService = parkingService;
        }
        public void execute(string input)
        {
            int level = 1;
            string[] inputs = input.Split(" ");
            string key = inputs[0];
            switch(key)
            {
                case "create_parking_lot":
                    try
                    {
                        int capacity = int.Parse(inputs[1]);
                        Console.WriteLine(capacity);
                        parkingService.CreateParkingLot(level, capacity);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "park":
                    try
                    {
                        string regNumber = inputs[1];
                        string color = inputs[2];
                        Vehicle vehicle = new(regNumber, color);
                        parkingService.Park(level, vehicle);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "leave":
                    try
                    {
                        int slotNumber = int.Parse(inputs[1]);
                        parkingService.UnPark(level, slotNumber);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "status":
                    try
                    {
                        parkingService.GetStatus(level);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "registration_numbers_for_cars_with_colour":
                    parkingService.GetRegNumberForColor(level, inputs[1]);
                    break;
                case "slot_numbers_for_cars_with_colour":
                    parkingService.GetSlotNumbersFromColor(level, inputs[1]);
                    break;
                case "slot_number_for_registration_number":
                    parkingService.GetSlotNoFromRegistrationNo(level, inputs[1]);
                    break;
                default:
                    break;
            }
        }
    }
}
