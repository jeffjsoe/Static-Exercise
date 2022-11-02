
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double answer)
        {
            return (answer - 32) * .5556;

        }


        public static double CelsiusToFahrenheit(double input)
        {
            return (input * 1.8) + 32;

        }




    }
}
