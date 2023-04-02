using ParkingLot;
using System;

public class Program
{
    public static void Main(String[] args)
    {
        IParkingService parkingService = new ParkingService();
        RequestProcessor requestProcessor = new(parkingService);
        while(true)
        {
            string input = Console.ReadLine();
            if (input.Equals("exit"))
                break;
            else
                requestProcessor.execute(input);
        }
    }
}