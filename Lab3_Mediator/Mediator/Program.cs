using System;

namespace Mediator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ConcessionsMediator mediator = new ConcessionsMediator();

            NorthConcessionStand leftKitchen = new NorthConcessionStand(mediator);
            SouthConcessionStand rightKitchen = new SouthConcessionStand(mediator);

            mediator.NorthConcessions = leftKitchen;
            mediator.SouthConcessions = rightKitchen;

            leftKitchen.Send("Can you send some pizza?");
            rightKitchen.Send("Sure, John from Glovo is on his way.");

            rightKitchen.Send("Do you have any sauces?");
            leftKitchen.Send("Just a couple, we'll send John back with them.");

            Console.ReadKey();
        }
    }
}
