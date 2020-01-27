using System;
using Contracts;
using Unity;

namespace ArdalisRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Rating System Starting...");

            var container = BootStrap.BootStrapper.OnStartup();
            var ratingMechanism = container.Resolve<IMechanism>();
            var rating = ratingMechanism.Rate();

            if (rating > 0)
            {
                Console.WriteLine($"Rating: {rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }

        }
    }
}
