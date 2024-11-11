using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX2D.Cars;
using EX2D.Cars.EX2.Cars;

public class Chapter_EXR
{
    public static void Main(string[] args)
    {
        Car vehicle;

        while (true)
        {
            Console.WriteLine("Choose your car type: \n1 - Renault Clio\n2 - Amphibia");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                vehicle = new RenaultClio();
                break;
            }
            else if (choice == "2")
            {
                vehicle = new Amphibia();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose 1 or 2");
            }
        }


        while (true)
        {
            Console.Write("Enter acceleration increment (max 50): ");
            if (int.TryParse(Console.ReadLine(), out int increment) && increment > 0)
            {
                int maxIncrement = 50;
                if (increment > maxIncrement)
                {
                    Console.WriteLine($"Increment is too high! The maximum allowed is {maxIncrement}.");
                }
                else
                {
                    vehicle.Accelerate(increment);
                    break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }
}
