using System;
namespace Command
{
    public class ShareMarket
    {
        public void ConnectShareMarket()
        {
        }

        public void BuyShares(int sharesToBuy)
        {
            Console.WriteLine("Buy shares: " + sharesToBuy);
        }

        public void SellShares(int sharesToSell)
        {
            Console.WriteLine("Sell shares: " + sharesToSell);
        }

        public void DisconnectWithShareMarket()
        {
        }
    }
}
