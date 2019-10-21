using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles
{
    abstract class Fish: Animals
    {
        public virtual decimal Length { get; set; }

        abstract public void Swim();
    }
}
