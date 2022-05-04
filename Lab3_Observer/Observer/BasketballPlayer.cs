using System;
namespace Observer
{
    class BasketballPlayer : Player
    {
        public string Name;
        public int Points = 0;

        public BasketballPlayer(string name)
        {
            this.Name = name;
        }

        public void Score(int points)
        {
            this.Points += points;
            this.Notify();
        }
    }
}
