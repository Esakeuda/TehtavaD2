using System;

namespace CelsiusToFahrenheit
{
    class Program
    {
        // Funktio muuntaa Celsius-asteet Fahrenheiteiksi
        static double CelsiusToFahrenheit(double celsius)
        {
            // Muunnoskaava: Fahrenheit = (Celsius * 1.8) + 32
            double fahrenheit = celsius * 1.8 + 32;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            Console.Write("Syötä lämpötila Celsius-asteina: ");
            double celsiusInput = Convert.ToDouble(Console.ReadLine());

            // Kutsutaan muuntamisfunktiota
            double fahrenheitOutput = CelsiusToFahrenheit(celsiusInput);

            // Tulostetaan muunnettu lämpötila
            Console.WriteLine($"{celsiusInput} Celsius-astetta on {fahrenheitOutput:F2} Fahrenheit-astetta.");
        }
    }
}
