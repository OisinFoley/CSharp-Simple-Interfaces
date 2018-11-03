using System;
using NUnit.Framework;

namespace BasicInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args[0] + " is your args[0] value");
            try {
                Console.WriteLine((args[1] ?? "no index 1 for args"));
            }
            catch {
                Console.WriteLine("Index 1 is out of bounds, lower search index or increase array size\n");
            }

            Mammal mammal = new Mammal(2, 2);
            mammal.KickLegs();
            mammal.WaveArms();
            Person Oisín = new Person("Oisín", mammal);
            Console.WriteLine($"Oisín's name is {Oisín.Name}, he has {Oisín.HumansLimbs.ArmsCount} arms and {Oisín.HumansLimbs.LegCount} legs. He is of type {Oisín.GetType()}");

            Person p = new Person("Jim");
            p.shout();
            Ant antie = new Ant("Antie", "'Crawling in a colony'");
            

            // DoesCreatureShout(antie);
            //2 types of casting with a check before calling the func that requires the specified interface in its signature
            if (antie is ICrawlable)
            {
                ICrawlable castedAnt = (ICrawlable)antie;
                DoesCreatureShout(castedAnt);
            }

            Cat kittie = new Cat("Kittie", "Meow");
            ICrawlable castedCat = kittie as ICrawlable;
            if (castedCat != null)
            {
                DoesCreatureShout(kittie);
            }
            Console.WriteLine();
            Nissan primera = new Nissan();
            primera.Accelerate();
            primera.ActivateAirConditioning();
            primera.ActivateBrakeLight();
            
            Console.ReadLine();
        }

        public static void DoesCreatureShout(ICrawlable creature)
        {
            Console.WriteLine($"The creature's shout is {creature.Sound} and it's type is {creature.GetType()}");
        }
    }

    [TestFixture]
    class ProgramTest
    {
        [TestCase(1, 2, 1)]
        [TestCase(2, 2, 2)]
        [TestCase(3, 3, 3)]
        public void Should_Pass_Regardless(int x, int y, int z)
        {
            Assert.AreEqual(x, y, z);
        }
    }
}