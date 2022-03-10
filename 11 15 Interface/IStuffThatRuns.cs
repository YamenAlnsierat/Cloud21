using System;
using System.Collections.Generic;
using System.Text;

namespace _11_15_Interface
{
    internal interface IStuffThatRuns
    {
        public string Name { get; set; }
        public void Run();
    }

    internal interface IStuffThatEats
    {
        public string Name { get; set; }
        public void Eat();
    }
}
