using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public abstract class Vehicle 
    {
        public abstract int NumOfTires { get; }
        public abstract int NumSeats { get; }
        public abstract int SafetyRating { get; }
        public abstract int Price { get; }
        public abstract decimal DownPaymentPercent { get; }

        public virtual void BuildVehicle()
        {
            Console.WriteLine($"A {GetType().Name} is the right vehicle for you!\nThe {GetType().Name} has {NumOfTires} tires.\n" +
                $"It has {NumSeats} seats.\nIt has a safety rating of {SafetyRating}.\nIt costs ${Price}");
        }

        public void DownPayment()
        {
            decimal downPaymentDue = Price * DownPaymentPercent;
            Console.WriteLine($"We require a down payment of ${downPaymentDue} for this {GetType().Name}.");

        }
    }
}
