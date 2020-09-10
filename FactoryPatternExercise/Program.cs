using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle yourVehicle = VehicleFactory.GetVehicle();
            yourVehicle.BuildVehicle();
            yourVehicle.DownPayment();

        }
    }
}
