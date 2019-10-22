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

        public string FeedFood()
        {
            Console.WriteLine("Please feed me meat.");
            string result = "Please feed me meat.";
            return result;
        }

        public string GiveWater()
        {
            Console.WriteLine("Please give me water.");
            string result = "Please give me water.";
            return result;
        }
    }
}
