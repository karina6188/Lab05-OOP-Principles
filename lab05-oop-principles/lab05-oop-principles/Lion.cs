﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles
{
    class Lion : Mammal
    {
        public override int Weight { get; set; }
        public override int Age { get; set; }

        public override void Hunt()
        {
            Console.WriteLine("I am a lion and I hunt.");
        }
    }
}
