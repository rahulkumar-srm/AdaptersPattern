﻿using AdaptersPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaptersPattern
{
    class MallardDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying");
        }

        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
