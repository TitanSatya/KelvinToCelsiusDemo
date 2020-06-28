using System;


namespace TempConverter.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TemperatureConverter temperatureConverter = new TemperatureConverter();
                Console.WriteLine("Please enter temp value in Kelvin");
                var value = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{value} kelvin is {temperatureConverter.ConvertKelvinToCelsius(value)} degree Celsius");

            }
            catch (Exception x)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine($"Type of exception is {x.GetType()} and Exception is {x.Message}");

            }
            Console.Read();
        }
    }
    public class TemperatureConverter
    {
        public double ConvertCelsiusToKelvin(string celsius)
        {

            double celsiusValue = 0;

            if (!double.TryParse(celsius, out celsiusValue))
            {
                throw new ArgumentException("Argument value is  not valid");
            }

            return Convert.ToInt32(celsius) + 273.15;
        }

        public double ConvertKelvinToCelsius(string kelvin)
        {
            double kelvinValue = 0;
            if(!Double.TryParse(kelvin, out kelvinValue))
            {
                throw new ArgumentException("Argument is not valid");
            }
            return Math.Round((kelvinValue - 273.15),2);
        }
    }
}
