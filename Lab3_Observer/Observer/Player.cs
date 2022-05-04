using System;
using System.Collections.Generic;

namespace Observer
{
    abstract class Player
    {
        List<Fan> fans = new List<Fan>();

        public void Attach(Fan f)
        {
            fans.Add(f);
        }

        public void Detach(Fan f)
        {
            fans.Remove(f);
        }

        public void Notify()
        {
            foreach (Fan f in fans)
            {
                f.Update();
            }
        }
    }
}
