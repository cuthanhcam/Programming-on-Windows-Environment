using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week_02
{
    internal class Dog : Animal
    {
        public Dog()
        {
            Name = "Null";
        }

        public Dog(string name) : base(name)
        {
            Name = name;
        }

        public override void Speak()
        {
            Console.WriteLine($"{Name} is speaking gau gau");
        }
    }
}
