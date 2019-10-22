using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public abstract class Bird : Animals, IWater
    {
        abstract public string Fly();

        public override bool IsInZoo
        {
            get => base.IsInZoo = true;
            set => base.IsInZoo = value;
        }

        public string GiveWater()
        {
            Console.WriteLine("Please give me water.");
            string result = "Please give me water.";
            return result;
        }
    }
}
