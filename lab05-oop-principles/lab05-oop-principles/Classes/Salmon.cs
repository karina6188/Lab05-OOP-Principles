using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public class Salmon : Fish
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

        public override string Sleep()
        {
            base.Sleep();
            Console.WriteLine($"I am a salmon and I do not sleep, and I am {Length} inches long.");
            string result = $"I am a salmon and I do not sleep, and I am {Length} inches long.";
            return result;
        }
        public override string Swim()
        {
            Console.WriteLine($"I am a salmon and I swim in the sea, and I am {Length} inches long.");
            string result = $"I am a salmon and I swim in the sea, and I am {Length} inches long.";
            return result;
        }

        public new string FeedFood()
        {
            Console.WriteLine("Please feed me fish food.");
            string result = "Please feed me fish food.";
            return result;
        }
    }
}
