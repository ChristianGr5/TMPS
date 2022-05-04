using System;
namespace Observer
{
    class BasketballFan : Fan
    {
        BasketballPlayer FavoritePlayer;
        int FavoritePlayerPoints;

        public BasketballFan(BasketballPlayer player)
        {
            this.FavoritePlayer = player;
            this.FavoritePlayerPoints = this.FavoritePlayer.Points;
        }

        public override void Update()
        {
            this.FavoritePlayerPoints = this.FavoritePlayer.Points;
            Console.WriteLine(this.FavoritePlayer.Name + " has " + this.FavoritePlayerPoints + " points!");
        }
    }
}
