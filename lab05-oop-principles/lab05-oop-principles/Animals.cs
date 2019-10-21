using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles
{
    abstract class Animals
    {
        public virtual bool IsAlive { get; set; }

        public virtual void Eat()
        {
            Console.WriteLine("I live in a zoo and I EAT.");
        }

        public virtual void Sleep()
        {
            Console.WriteLine("I live in a zoo and I SLEEP.");
        }
    }
}
