using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles
{
    class Leopard : Mammal
    {
        public override int Weight { get; set; }
        public override int Age { get; set; }

        public Leopard(int weight, int age) : base(weight, age)
        {
            Weight = weight;
            Age = age;
        }

        public override void Hunt()
        {
            Console.WriteLine("I am a leopard and I hunt.");
        }
    }
}
