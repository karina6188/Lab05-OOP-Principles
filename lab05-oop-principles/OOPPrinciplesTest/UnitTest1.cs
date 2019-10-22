using System;
using Xunit;
using static lab05_oop_principles.Program;
using lab05_oop_principles.classes;

namespace OOPPrinciplesTest
{
    public class UnitTest1
    {
        [Fact]
        public void SalmonSwim()
        {
            Fish salmon = new Salmon(15);
            Assert.Equal("I am a salmon and I swim in the sea, and I am 15 inches long.", salmon.Swim());
        }

        [Fact]
        public void SalmonIsInZoo()
        {
            Fish salmon = new Salmon(15);
            bool isThisInZoo = salmon.IsInZoo;
            Assert.False(salmon.IsInZoo);
        }

        [Fact]
        public void LeopardHunt()
        {
            Mammal leopard = new Leopard(65, 5);
            Assert.Equal("I am a leopard and I hunt. I weigh 65 lbs and I am 5 years-old.", leopard.Hunt());
        }

        [Fact]
        public void LeopardSleep()
        {
            Mammal leopard = new Leopard(65, 5);
            Assert.Equal("I live in a zoo and I SLEEP.", leopard.Sleep());
        }

        [Fact]
        public void LionEat()
        {
            Mammal lion = new Lion(355, 7);
            Assert.Equal("I live in a zoo and I EAT.", lion.Eat());
        }

        [Fact]
        public void LionHunt()
        {
            Mammal lion = new Lion(355, 7);
            Assert.Equal("I am a lion and I hunt. I weigh 355 lbs and I am 7 years-old.", lion.Hunt());
        }

        [Fact]
        public void TigerEat()
        {
            Mammal tiger = new Lion(355, 7);
            Assert.Equal("I live in a zoo and I EAT.", tiger.Eat());
        }

        [Fact]
        public void TigerSleep()
        {
            Mammal tiger = new Lion(355, 7);
            Assert.Equal("I live in a zoo and I SLEEP.", tiger.Sleep());
        }

        [Fact]
        public void EagleFly()
        {
            Bird eagle = new Eagle();
            Assert.Equal("I am an eagle and I can fly in the sky.", eagle.Fly());
        }

        [Fact]
        public void EagleIsInZoo()
        {
            Bird eagle = new Eagle();
            bool isThisInZoo = eagle.IsInZoo;
            Assert.True(eagle.IsInZoo);
        }

        [Fact]
        public void FishSalmonFeed()
        {
            Fish salmon = new Salmon(15);
            Assert.Equal("Please feed me fish food.", salmon.FeedFood());
        }

        [Fact]
        public void MammalTigerFeed()
        {
            Mammal tiger = new Lion(355, 7);
            Assert.Equal("Please feed me meat.", tiger.FeedFood());
        }

        [Fact]
        public void MammalLionFeed()
        {
            Mammal lion = new Lion(355, 7);
            Assert.Equal("Please feed me meat.", lion.FeedFood());
        }

        [Fact]
        public void MammalLeopardFeed()
        {
            Mammal leopard = new Leopard(65, 5);
            Assert.Equal("Please feed me meat.", leopard.FeedFood());
        }

        [Fact]
        public void BirdEagleWater()
        {
            Bird eagle = new Eagle();
            Assert.Equal("Please give me water.", eagle.GiveWater());
        }

        [Fact]
        public void MammalLeopardWater()
        {
            Mammal leopard = new Leopard(65, 5);
            Assert.Equal("Please give me water.", leopard.GiveWater());
        }

        [Fact]
        public void MammalLionWater()
        {
            Mammal lion = new Lion(355, 7);
            Assert.Equal("Please give me water.", lion.GiveWater());
        }

        [Fact]
        public void MammalTigerWater()
        {
            Mammal tiger = new Lion(355, 7);
            Assert.Equal("Please give me water.", tiger.GiveWater());
        }
    }
}