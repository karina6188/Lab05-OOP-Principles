using System;
using lab05_oop_principles.classes;

namespace lab05_oop_principles
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Mammal mammal = new Lion(320, 5);
            Fish fish = new Salmon(18);
            Bird bird = new Eagle();

            Tiger tiger = new Tiger(520, 9);
            Lion lion = new Lion(350, 6);
            Leopard leopard = new Leopard(68, 8);
            Salmon salmon = new Salmon(19);
            Eagle eagle = new Eagle();

            mammal.Hunt();
            mammal.FeedFood();
            mammal.GiveWater();
            mammal.MakeSound();
            Console.WriteLine($"Is is true that you live in a zoo? {mammal.IsInZoo}");
            mammal.Sleep();
            mammal.Eat();
            Console.WriteLine("----------------------------------------------------");

            fish.FeedFood();
            Console.WriteLine($"The length of the fish is {fish.Length}");
            Console.WriteLine($"Is is true that you live in a zoo? {fish.IsInZoo}");
            fish.Swim();
            fish.Sleep();
            fish.MakeSound();
            Console.WriteLine("----------------------------------------------------");

            bird.Eat();
            bird.Fly();
            bird.GiveWater();
            Console.WriteLine($"Is is true that you live in a zoo? {bird.IsInZoo}");
            bird.Sleep();
            Console.WriteLine("----------------------------------------------------");

            tiger.Eat();
            tiger.FeedFood();
            tiger.GiveWater();
            tiger.Hunt();
            tiger.MakeSound();
            tiger.Sleep();
            Console.WriteLine($"Is is true that you live in a zoo? {tiger.IsInZoo}");
            Console.WriteLine("----------------------------------------------------");

            lion.Hunt();
            lion.MakeSound();
            lion.FeedFood();
            lion.GiveWater();
            Console.WriteLine("----------------------------------------------------");

            leopard.Hunt();
            leopard.MakeSound();
            leopard.Sleep();
            leopard.FeedFood();
            Console.WriteLine("----------------------------------------------------");

            salmon.Sleep();
            salmon.Swim();
            salmon.MakeSound();
            salmon.FeedFood();
            salmon.Eat();
            Console.WriteLine($"Is is true that you live in a zoo? {salmon.IsInZoo}");
            Console.WriteLine("----------------------------------------------------");

        }
    }
}
