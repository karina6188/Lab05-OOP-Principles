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
            Console.WriteLine("I live in a zoo and I EAT.");
            string result = "I live in a zoo and I EAT.";
            return result;
        }

        public virtual string Sleep()
        {
            Console.WriteLine("I live in a zoo and I SLEEP.");
            string result = "I live in a zoo and I SLEEP.";
            return result;
        }
    }
}
