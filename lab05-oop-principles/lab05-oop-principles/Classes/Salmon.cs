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
            IsInZoo = false;
        }

        public override string Sleep()
        {
            base.Sleep();
            Console.WriteLine($"I am a salmon and I sleep with my eyes open.");
            string result = $"I am a salmon and I sleep with my eyes open.";
            return result;
        }
        public override string Swim()
        {
            Console.WriteLine($"I swim in the sea.");
            string result = $"I swim in the sea.";
            return result;
        }

        public new string FeedFood()
        {
            Console.WriteLine("Please feed me fish food.");
            string result = "Please feed me fish food.";
            return result;
        }

        public new string MakeSound()
        {
            return "Salmon does not make sound.";
        }
    }
}
