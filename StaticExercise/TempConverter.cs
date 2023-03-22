using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    static class TempConverter
    {
        static TempConverter()
        {
            
        }

        public static double CelsiusToFahrenheit(double fTemp)
        {
            
            
            double fahrenheit = Math.Round(((fTemp * 1.8) + 32), 4);
            return fahrenheit;
            


        }

        public static double FahrenheitToCelsius(double cTemp)
        {
            double celsius =Math.Round(((cTemp - 32) * .5556), 2);
            return celsius;
        }
        



        
    }

















}
