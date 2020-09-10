using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public static class VehicleFactory
    {

        public static Vehicle GetVehicle()
        {
            Console.WriteLine("Welcome to our car lot! We'd love to help you find the right vehicle for you.");
            Console.WriteLine("How many seats would you like your vehicle to have?");
            int numOfSeats = int.Parse(Console.ReadLine());
            Console.WriteLine("........................................................................");
            if (numOfSeats > 2)
            {
                return new Van();
            }
            else
            {
                Console.WriteLine("Sounds like you're looking for a fun vehicle! We have some options for you.");
                Console.WriteLine("Do you prefer 2 or 4 wheels?");
                int numWheels = int.Parse(Console.ReadLine());
                if(numWheels == 2)
                {
                    return new Motorcycle();
                }
                else
                {
                    return new SportCar();
                }
            }


        }



    }
}
