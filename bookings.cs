using System;

public class HotelBooking
{
    private static bool CheckIn(int actual_ch_in, int actual_ch_out, out int check_in, out int check_out)
    {
        Console.WriteLine("Please enter check-in date:");
        check_in = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter check-out date:");
        check_out = int.Parse(Console.ReadLine());

        if (actual_ch_in < check_in && check_in < actual_ch_out)
        {
            Console.WriteLine("Check-in date is not available.");
            return false;
        }
        else if (actual_ch_out < check_out && check_out < actual_ch_in)
        {
            Console.WriteLine("Successfully booked!");
            return true;
        }

        return false;
    }

    public static void Main()
    {
        // I have assumed example variables
        int actual_ch_in = 2023_08_15; // Replace with the actual value (year_month_day format, e.g., 2023-08-15)
        int actual_ch_out = 2023_08_20; // Replace with the actual value (year_month_day format, e.g., 2023-08-20)
        int usr_balance = 500; // Replace with the actual user balance
        int room_price = 300; // Replace with the actual room price

        int check_in, check_out;
        if (CheckIn(actual_ch_in, actual_ch_out, out check_in, out check_out))
        {
            if (usr_balance >= room_price)
            {
                Console.WriteLine("Payment Successful");
            }
            else
            {
                Console.WriteLine("Sorry, balance too low...");
            }
        }
    }
}
