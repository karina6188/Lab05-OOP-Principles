using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public abstract class Bird : Animals, IWater
    {
        abstract public string Fly();

        public void GiveWater()
        {
            Console.WriteLine("Please give me water.");
        }
    }
}
