using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anna_Baseley_Lab2
{
    class Program
    {
        static void Main(string[] args) 
        {
            //Input


            Console.WriteLine("Hello!  Let's run the Grand Circus Room Generator Program!");

            while (true)
            {
                //input 
                decimal RoomLength = GetNumbers("Enter the length of the room.");
                decimal RoomWidth = GetNumbers("Enter the width of the room.");
                decimal RoomHeight = GetNumbers("Enter the height of the room.");

                //Processing & Output
                 
                Console.WriteLine($"Area: {RoomArea(RoomLength, RoomWidth)}");
                Console.WriteLine($"Perimeter: {RoomPerimeter(RoomLength, RoomWidth)}");
                Console.WriteLine($"Volume: {RoomVolume(RoomLength, RoomWidth)}");

                //Continue?
                if (UserContinue() == false)
                {
                    break;            
                }
            }
           
        }

        public static decimal GetNumbers(string Message)
        {
            Console.WriteLine(Message);
            decimal UserInput = decimal.Parse(Console.ReadLine());
            return UserInput;
        }

        public static decimal RoomArea(decimal RoomLength, decimal RoomWidth)
        {
            decimal Area = RoomLength * RoomWidth;
            return Area;
        }

        public static decimal RoomPerimeter(decimal RoomLength, decimal RoomWidth)
        {
            decimal Perimeter = (RoomLength * 2) + (RoomWidth * 2);
            return Perimeter;
        }

        public static decimal RoomVolume(decimal RoomArea, decimal RoomHeight)
        {
            decimal volume = RoomArea * RoomHeight;
            return volume;
        }
        
        public static bool UserContinue()
        {
            Console.WriteLine("Would you like to continue measuring rooms? (y/n) : ");
            string restart = Console.ReadLine();
            while (true)
            {
                while (restart.ToLower() != "y" && restart.ToLower() != "n")
                {
                    Console.WriteLine("Oops! I didn't get that.  Would you like to go again? y/n");
                    restart = Console.ReadLine();

                }

                if (restart.ToLower() == "n")
                {
                    Console.WriteLine("Okay!  See you next time.");
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
    }
}
