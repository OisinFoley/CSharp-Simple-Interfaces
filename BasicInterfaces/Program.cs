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
                Console.WriteLine("Index 1 is out of bounds, lower search index or increase array size");
            }
            
            //we ultimately want to be able to define an interface as a class member in person,
            //and in person's ctor.
            //may need to use an abstract class(see mammal), but not entirely sure
            //using interface as class member is worth knowing
            // Mammal genericMammal = new Mammal(2, 2);

            //to have an interface as part of a class' ctor,
            //just pass an object that implements the interface into the ctor
            //that's what you ultimately need to do
            //read up on abstraction and inheritance again

            //just switch the mebers of Mammal and Person around,
            //we should be calling the Person ctor after instantiateing a Mammal,
            //not the other way around, as is the case at the time of writing this text ...

            Person p = new Person("Jim");
            p.shout();
            Ant antie = new Ant("Antie", "'Crawling in a colony'");
            // DoesCreatureShout(antie);

//2 types of casting with a check before calling the func who requires the interface in its signature
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
        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 2)]
        [TestCase(3, 3, 3)]
        public void Should_Pass_Regardless(int x, int y, int z)
        {
            Assert.AreEqual(x, y, z);
        }
    }
}