using System;
namespace Command
{
    public class Trader
    {
        private ShareMarket shareMarket;

        private DelegateCommand<int> buyCommand;
        private DelegateCommand<int> sellCommand;

        public Trader()
        {
            this.shareMarket = new ShareMarket();
        }

        public DelegateCommand<int> BuyCommand
        {
            get
            {
                if (this.buyCommand == null)
                {
                    this.buyCommand = new DelegateCommand<int>(w => this.OnBuyCommand(w));
                }
                return buyCommand;
            }
        }

        public DelegateCommand<int> SellCommand
        {
            get
            {
                if (this.sellCommand == null)
                {
                    this.sellCommand = new DelegateCommand<int>(w => this.OnSellCommand(w));
                }
                return this.sellCommand;
            }
        }

        private void OnBuyCommand(int parameter)
        {
            shareMarket.ConnectShareMarket();
            shareMarket.BuyShares(parameter);
            shareMarket.DisconnectWithShareMarket();
        }

        private void OnSellCommand(int parameter)
        {
            shareMarket.ConnectShareMarket();
            shareMarket.SellShares(parameter);
            shareMarket.DisconnectWithShareMarket();
        }
    }
}
