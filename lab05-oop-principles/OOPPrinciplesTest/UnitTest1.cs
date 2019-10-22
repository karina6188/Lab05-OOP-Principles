using System;
using Xunit;
using static lab05_oop_principles.Program;
using lab05_oop_principles.classes;

namespace OOPPrinciplesTest
{
    public class UnitTest1
    {
        [Fact]
        public void Leopard()
        {
            Mammal leopard = new Leopard(65, 5);
            Assert.Equal("I am a leopard and I hunt. I weigh 65 lbs and I am 5 years-old.", leopard.Hunt());
        }

        [Fact]
        public void Salmon()
        {
            Fish salmon = new Salmon(15);
            Assert.Equal("I am a salmon and I swim in the sea, and I am 15 inches long.", salmon.Swim());
        }

        [Fact]
        public void Eagle()
        {
            Bird eagle = new Eagle();
            Assert.Equal("I am an eagle and I can fly in the sky.", eagle.Fly());
        }

        [Fact]
        public void Lion()
        {
            Mammal lion = new Lion(355, 7);
            Assert.Equal("I live in a zoo and I SLEEP.", lion.Sleep());
        }
    }
}
