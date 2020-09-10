using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternExercise
{
    public interface IVehicleProperties
    {
        public abstract int NumOfTires { get; }
        public abstract int NumSeats { get; }
        public abstract int SafetyRating { get; }
        public abstract int Price { get; }

          
    }
}
