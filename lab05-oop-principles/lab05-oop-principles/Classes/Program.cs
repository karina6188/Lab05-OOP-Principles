﻿using System;
using lab05_oop_principles.classes;

namespace lab05_oop_principles
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fish salmon = new Salmon(18);
            Bird eagle = new Eagle();
            Mammal tiger = new Tiger(520, 9);
            Mammal lion = new Lion(350, 6);
            Mammal leopard = new Leopard(68, 8);
            Animals leopard2 = new Leopard(70, 10);

            salmon.Swim();
            salmon.FeedFood();
            tiger.Sleep();
            tiger.FeedFood();
            eagle.Fly();
            eagle.GiveWater();
            bool isThisInZoo = salmon.IsInZoo;
            Console.WriteLine(isThisInZoo);
            leopard.Hunt();
            lion.Eat();
        }
    }
}
