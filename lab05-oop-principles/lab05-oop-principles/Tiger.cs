using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles
{
    class Tiger: Mammal
    {
        public override int Weight { get; set; }
        public override int Age { get; set; }

        public override void Hunt()
        {
            Console.WriteLine("I am a tiger and I hunt.");
        }
    }
}
