using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        public static void Main(string[] args)
        {
                var plants = new List<IForest>();

                var branch = new Branch(new List<IForest>() { new Tree(), new Tree() });
                var anotherBranch = new Branch(new List<IForest>() { new Tree(), new Tree(), new Tree(), new Tree() });

                plants.Add(new Branch(
                    new List<IForest>()
                        { branch, anotherBranch }
                ));

                plants.Add(new Tree());
                plants.Add(new Branch(new List<IForest>() { new Tree(), new Tree(), new Tree(), new Tree(), new Tree() }));
                plants.Add(new Tree());

                foreach (IForest plant in plants)
                {
                    plant.Cut();
                }
         


        }
    }
}
