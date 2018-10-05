using System;

namespace CD1_Kyrkosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter temperature type: 1. Celsius, 2. Fahrenheit, 3. Reamur, 4. Kelvin]! Type a number");
            decimal sourceTemperatureType = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter temperature type to convert to:");
            decimal targetTemperatureType = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter temperature degrees");
            decimal sourceTemperatureDegrees =  decimal.Parse(Console.ReadLine());

            decimal targetTemperatureDegrees = 0;

            if (sourceTemperatureType == 1)
            {
                if (targetTemperatureType == 1)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees;
                }

                if (targetTemperatureType == 2)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees * 9 / 5 + 32;
                }

                if (targetTemperatureType == 3)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees * 4 / 5;
                }

                if (targetTemperatureType == 4)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees + (decimal)273.15;
                }
            }

            if (sourceTemperatureType == 2)
            {
                if (targetTemperatureType == 2)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees;
                }

                if (targetTemperatureType == 1)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees / (decimal)0.8000;
                }

                if (targetTemperatureType == 3)
                {
                    targetTemperatureDegrees = (sourceTemperatureDegrees - 32) * 4 / 9;
                }

                if (targetTemperatureType == 4)
                {
                    targetTemperatureDegrees = (sourceTemperatureDegrees + (decimal)459.67) * 5 / 9;
                }
            }

            if (sourceTemperatureType == 3)
            {
                if (targetTemperatureType == 3)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees;
                }

                if (targetTemperatureType == 1)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees * 5 / 4;
                }

                if (targetTemperatureType == 2)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees * 9 / 4 + 32;
                }

                if (targetTemperatureType == 4)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees * 5 / 4 + (decimal)273.15;
                }
            }

            if (sourceTemperatureType == 3)
            {
                if (targetTemperatureType == 4)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees;
                }

                if (targetTemperatureType == 1)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees - (decimal)273.15;
                }

                if (targetTemperatureType == 2)
                {
                    targetTemperatureDegrees = sourceTemperatureDegrees * 9 / 5 - (decimal)459.67;
                }

                if (targetTemperatureType == 3)
                {
                    targetTemperatureDegrees = (sourceTemperatureDegrees - (decimal)273.15) *4 / 5;
                }
            }

            Console.WriteLine(targetTemperatureDegrees);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
