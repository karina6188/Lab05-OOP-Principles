using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public abstract class Fish : Animals
    {
        public virtual decimal Length { get; set; }

        public override bool IsInZoo
        {
            get => base.IsInZoo = false;
            set => base.IsInZoo = value;
        }

        private string _isInZoo = "Fishes are not available in zoo now.";

        abstract public string Swim();
    }
}
