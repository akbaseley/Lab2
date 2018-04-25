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
            decimal RoomPerimeter = 0;
            decimal RoomArea = 0;
            decimal RoomVolume = 0;
            string restart;

            Console.WriteLine("Hello!  Let's run the Grand Circus Room Generator Program!");
            do
            { Console.WriteLine("Please enter the length of the room");
            decimal RoomLength = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the width of the room.");
            decimal RoomWidth = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the height the room.");
            decimal RoomHeight = decimal.Parse(Console.ReadLine());


            //Processing

            RoomArea = RoomLength * RoomWidth;
            RoomPerimeter = (RoomLength * 2) + (RoomWidth *2);
            RoomVolume = RoomArea * RoomHeight;
          
            //Output

            Console.WriteLine($"Area: {RoomArea}");
            Console.WriteLine($"Perimeter: {RoomPerimeter}");
            Console.WriteLine($"Volume: {RoomVolume}");

            Console.WriteLine("Would you like to continue measuring rooms? (y/n) : ");
            restart = Console.ReadLine();
            }

            while (restart.ToLower() == "y");

        }
    }
}
