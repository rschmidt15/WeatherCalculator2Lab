using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Weather Calculator 2 Roman Schmidt");

            int temperature;
            int windSpeed;
            double windChill;
            string input = "";
            int RH;
            double Heatindex;

            // Get the temperature from the user
            Console.WriteLine("Enter the temperature");

            input = Console.ReadLine();

            temperature = int.Parse(input);
            if (temperature < 50)
            {
                Console.WriteLine("you are cold");
                // Get the windspeed from the user
                Console.WriteLine("Enter the wind speed");

                input = Console.ReadLine();

                windSpeed = int.Parse(input);

                // Calculate the wind chill

                windChill = 35.74 + (0.6125 * temperature) - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * temperature * Math.Pow(windSpeed, 0.16);

                Console.WriteLine("The wind chill is " + windChill);
            }
            else if (temperature>=50)
            { Console.WriteLine("you are happy");
                Console.WriteLine("Enter the Relative humidity");

                input = Console.ReadLine();

                RH = int.Parse(input);

                // Calculate the wind chill

                Heatindex = 0.5*(temperature+61+((temperature-68)*1.2+(RH*0.094)));

                Console.WriteLine("The heatindex is " + Heatindex);
            }



           
            else { Console.WriteLine("your data is invalid"); }


        }
    }
}
