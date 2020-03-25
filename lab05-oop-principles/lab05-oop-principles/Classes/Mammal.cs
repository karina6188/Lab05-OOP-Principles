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
            IsInZoo = true;
        }

        abstract public string Hunt();

        public string FeedFood()
        {
            Console.WriteLine("Some mammals are carnivorous some are herbivorous.");
            string result = "Some mammals are carnivorous some are herbivorous.";
            return result;
        }

        public string GiveWater()
        {
            Console.WriteLine("Mammals drink water.");
            string result = "Mammals drink water.";
            return result;
        }

        public string MakeSound()
        {
            Console.WriteLine("Some mammals make sound.");
            string result = "Some mammals make sound.";
            return result;
        }
    }
}
