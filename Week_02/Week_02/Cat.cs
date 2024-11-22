using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_02
{
    internal class Cat : Animal
    {
        public Cat()
        {
            Name = "Null";
        }

        public Cat(string name) : base(name)
        {
            Name = name;
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} is speaking meo meo");
        }
    }
}
