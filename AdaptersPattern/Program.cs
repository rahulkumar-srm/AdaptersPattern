using AdaptersPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IDuck duck = new MallardDuck();

            ITurkey turkey = new WildTurkey();
            TurkeyAdapter turkeyAdapter= new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\nThe duck says...");
            TestDuck(duck);

            Console.WriteLine("\nThe turkey says...");
            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
