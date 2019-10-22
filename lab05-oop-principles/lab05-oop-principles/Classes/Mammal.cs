using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public abstract class Mammal: Animals
    {
        abstract public int Weight { get; set; }
        abstract public int Age { get; set; }

        public override bool IsInZoo
        {
            get => base.IsInZoo = true;
            set => base.IsInZoo = value;
        }

        public Mammal(int weight, int age)
        {
            Weight = weight;
            Age = age;
        }

        abstract public string Hunt();
    }
}
