using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public abstract class Bird : Animals
    {
        public override bool IsInZoo
        {
            get => base.IsInZoo = true;
            set => base.IsInZoo = value;
        }

        abstract public string Fly(); 
    }
}
