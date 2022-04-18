using System;
namespace Composite
{
    public class Tree : IForest
    {
        public bool IsCut { get; private set; } = false;

        public void Cut()
        {
            IsCut = true;
            Console.WriteLine("Tree Cut Down :(");
        }
    }
}
