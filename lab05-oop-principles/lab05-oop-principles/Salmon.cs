using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles
{
    class Salmon : Fish
    {
        private decimal _length = 18;
        public override decimal Length
        {
            get
            {
                return _length;
            }
            set
            {
                _length = value;     
            }
        }

        public Salmon(decimal length)
        {
            Length = length;
        }

        public override void Sleep()
        {
            base.Sleep();
            Console.WriteLine("I am a salmon and I do not sleep.");
        }
        public override void Swim()
        {
            Console.WriteLine("I am a salmon and I swim in the sea.");
        }
    }
}
