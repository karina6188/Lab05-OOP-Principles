using System;

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

            salmon.Swim();
            tiger.Sleep();
            eagle.Fly();
            leopard.Hunt();
            lion.Eat();
        }
    }
}
