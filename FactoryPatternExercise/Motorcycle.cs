using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace FactoryPatternExercise
{
    public class Motorcycle : Vehicle, IVehicleProperties
    {
        private int numOfTires = 2;
        private int numOfSeats = 1;
        private int safetyRating = 1;
        private int price = 10000;
        private decimal downPaymentPercent = 0.2m;

        public override int NumOfTires { get { return numOfTires; } }
        public override int NumSeats { get { return numOfSeats; } }
        public override int SafetyRating { get { return safetyRating; } }
        public override int Price { get { return price; } }
        public override decimal DownPaymentPercent { get { return downPaymentPercent; }
}
    }
}
