using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public abstract class Animals
    {
        public virtual bool IsInZoo { get; set; }

        public virtual string Eat()
        {
            Console.WriteLine("Animal eats.");
            string result = "Animal eats.";
            return result;
        }

        public virtual string Sleep()
        {
            Console.WriteLine("Animal sleeps.");
            string result = "Animal sleeps.";
            return result;
        }
    }
}
