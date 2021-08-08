using AdaptersPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersPattern
{
    class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Gooble gobble");
        }

        public void Gobble()
        {
            Console.WriteLine("I'm flying a short distance");
        }
    }
}
