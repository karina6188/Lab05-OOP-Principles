using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles
{
    abstract class Mammal: Animals
    {
        abstract public int Weight { get; set; }
        abstract public int Age { get; set; }

        abstract public void Hunt();
    }
}
