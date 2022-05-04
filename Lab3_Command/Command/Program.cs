using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Trader trader = new Trader();
            trader.BuyCommand.Execute(100);
            trader.SellCommand.Execute(35);
        }
    }
}

