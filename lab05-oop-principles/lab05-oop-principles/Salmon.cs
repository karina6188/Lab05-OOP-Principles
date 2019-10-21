using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles
{
    class Salmon : Fish
    {
        public override decimal Length { get => base.Length; set => base.Length = value; }

        public override void Sleep()
        {
            base.Sleep();
        }
        public override void Swim()
        {
            Console.WriteLine("I am a salmon and I swim in the sea.");
        }
    }
}
