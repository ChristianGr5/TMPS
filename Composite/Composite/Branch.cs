using System;
using System.Collections.Generic;

namespace Composite
{
    public class Branch : Tree
    {
        private readonly IList<IForest> children;

        public Branch(IList<IForest> children)
        {
            this.children = children;
        }

        public void Eat()
        {
            foreach (var child in children)
            {
                child.Cut();
            }
        }
    }
}
