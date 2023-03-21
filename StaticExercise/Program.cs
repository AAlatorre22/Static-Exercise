namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {



            Console.Write("We are going to convert your celsius temperature" +
                " to fahrenheit.\nPlease enter your temperature: ");
            var userInput = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your temperature in fahreheit is {TempConverter.CelsiusToFahrenheit(userInput)}°");

            Console.WriteLine();

            Console.Write("We are now going to convert your fahrenheit temperature" +
                " to celsius.\nPlease enter your temperature: ");
            var userInput2 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Your temperature in celsius is {TempConverter.FahrenheitToCelsius(userInput2)}°");


        }


    }
}
