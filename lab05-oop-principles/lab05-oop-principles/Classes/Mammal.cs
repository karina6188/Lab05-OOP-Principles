using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public abstract class Mammal: Animals, IFeed, IWater
    {
        abstract public int Weight { get; set; }
        abstract public int Age { get; set; }

        public Mammal(int weight, int age)
        {
            Weight = weight;
            Age = age;
        }

        abstract public string Hunt();

        public void FeedFood()
        {
            Console.WriteLine("Please feed me meat.");
        }

        public void GiveWater()
        {
            Console.WriteLine("Please give me water.");
        }
    }
}
