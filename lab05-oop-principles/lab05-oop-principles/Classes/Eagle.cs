using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public class Eagle: Bird
    {
        public override string Fly()
        {
            Console.WriteLine("I am an eagle and I can fly in the sky.");
            string result = "I am an eagle and I can fly in the sky.";
            return result;
        }
    }
}
