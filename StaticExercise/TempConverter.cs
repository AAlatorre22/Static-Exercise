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

        public static double CelsiusToFahrenheit(double temp)
        {
            
            
            double fahrenheit = Math.Round((temp * 1.8) + 32);
            return fahrenheit;
            


        }

        public static double FahrenheitToCelsius(double temp)
        {
            double celsius =Math.Round((temp - 32) * .5556);
            return celsius;
        }
        



        
    }

















}
