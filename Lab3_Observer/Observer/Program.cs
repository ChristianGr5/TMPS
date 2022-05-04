using System;
using System.Collections.Generic;
namespace Observer
{

    public class Program
    {
        public static void Main()
        {
            BasketballPlayer christianGr = new BasketballPlayer("Christian Gr");
            BasketballFan basketballFan1 = new BasketballFan(christianGr);
            christianGr.Attach(basketballFan1);
            christianGr.Score(3);
            BasketballFan basketballFan2 = new BasketballFan(christianGr);
            christianGr.Attach(basketballFan2);
            christianGr.Score(2);
        }
    }

}