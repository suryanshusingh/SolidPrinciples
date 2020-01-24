using ArdalisRating.Inputs;
using ArdalisRating.Logger;
using System;

namespace ArdalisRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Siemens Insurance Rating System Starting...");
            IContext ratingMechanism = new RatingMechanism();
            var rating = ratingMechanism.Rate();
            var engine = new RatingEngine(new ConsoleLogger(), new FilePolicyInput(), new RaterFactory());
            engine.Rate();
            if (engine.Rating > 0)
            {
                Console.WriteLine($"Rating: {engine.Rating}");
            }
            else
            {
                Console.WriteLine("No rating produced.");
            }

        }
    }
}
