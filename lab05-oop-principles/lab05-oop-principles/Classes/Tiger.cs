using System;
using System.Collections.Generic;
using System.Text;

namespace lab05_oop_principles.classes
{
    public class Tiger : Mammal
    {
        public override int Weight { get; set; }
        public override int Age { get; set; }

        public Tiger(int weight, int age): base(weight, age)
        {
            Weight = weight;
            Age = age;
        }

        public override string Hunt()
        {
            Console.WriteLine($"I am a tiger and I hunt. I weigh {Weight} lbs and I am {Age} years-old.");
            string result = $"I am a tiger and I hunt. I weigh {Weight} lbs and I am {Age} years-old.";
            return result;
        }

        public new string MakeSound()
        {
            Console.WriteLine("Tiger growls.");
            string result = "Tiger growls.";
            return result;
        }
    }
}
