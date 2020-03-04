using System;

namespace Week8enum
{
    enum Months
    {
        January = 1, February, March, April, May, June, July, August, September, October, Novermber, December

    }
    enum Seasons
    {
        Spring = 1, Summer, Fall, Winter
    }
    class Program
    {
        static void Main(string[] args)
        {
            string month_string;
            string repeat_check;
            int month_num;

            Console.WriteLine("Please enter the month in numerical value (1-12): ");
            month_string = Console.ReadLine();
            month_num = Convert.ToInt16(month_string);

            if (month_num < 1 || month_num > 12)
            Console.WriteLine("Please close program, run the program again, and input number between 1-12");
            else 
                switch (month_num)
                {
                    case 1: 
                        Console.WriteLine("Today is Winter season");
                        break;
                    case 2: 
                        Console.WriteLine("Today is Winter season.");
                        break;
                    case 3: 
                        Console.WriteLine("Today is Spring.");
                        break;
                    case 4: 
                        Console.WriteLine("Today is Spring.");
                        break;
                    case 5: 
                        Console.WriteLine("Today Summer.");
                        break;
                    case 6: 
                        Console.WriteLine("Today is Summer.");
                        break;
                    case 7: 
                        Console.WriteLine("Today is Summer.");
                        break;
                    case 8: 
                        Console.WriteLine("Today is Fall.");
                        break;
                    case 9: 
                        Console.WriteLine("Today is Fall.");
                        break;
                    case 10: 
                        Console.WriteLine("Today is Fall.");
                        break;
                    case 11: 
                        Console.WriteLine("Today is Winter.");
                        break;
                    case 12: 
                        Console.WriteLine("Today is Winter.");
                        break;

                }
            {
                Console.WriteLine("Do you wish to continue?");
                repeat_check = Console.ReadLine();
            } while (repeat_check == "y");

        }
    }
}
