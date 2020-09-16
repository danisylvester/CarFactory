using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public class SportCar : Vehicle
    {
        private int numOfTires = 4;
        private int numOfSeats = 2;
        private int safetyRating = 3;
        private int price = 50000;
        private decimal downPaymentPercent = 0.3m;

        public override int NumOfTires { get { return numOfTires; } }
        public override int NumSeats { get { return numOfSeats; } }
        public override int SafetyRating { get { return safetyRating; } }
        public override int Price { get { return price; } }
        public override decimal DownPaymentPercent { get { return downPaymentPercent; } }


    }
}
