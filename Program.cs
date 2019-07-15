using System;


namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building EliotTowers = new Building("420 Avenue")
            {
                Width = 60,
                Depth = 90,
                Stories = 3
            };

            EliotTowers.Construct();

            EliotTowers.Purchase("Shelly");

            Console.WriteLine(EliotTowers.Address);
            Console.WriteLine("-----------");

            Console.WriteLine($"Designed by {EliotTowers.Designer}");
            Console.WriteLine($"Constructed on {EliotTowers.DateConstructed}");
            Console.WriteLine($"Owned by {EliotTowers.Owner}");
            Console.WriteLine($"{EliotTowers.Volume} cubic meters of space");



            City NextCity = new City("")
            { };

            NextCity.ConstructEst();

            Console.WriteLine($"Name of city is {NextCity.nameCity}");

            // City Mayor = new City("")
            // { };
            Console.WriteLine($"Name of the mayor is {NextCity.Mayor}");

            // City DateEstablished = new City("");
            Console.WriteLine($"Constructed on {NextCity.dateEstablished}");

        }
    }
}

