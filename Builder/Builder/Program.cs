using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            SpendingsBuilder builder = new SpendingsBuilder();

            SpendingsInfo spendings = builder
                .From("Wallet")
                .To("Food")
                .Amount("0")
                .About("Kebab")
                .Build();

            Console.ReadLine();
        }
    }
}
