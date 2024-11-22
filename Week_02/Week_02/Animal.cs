using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_02
{
    internal class Animal
    {
        public string Name { get; set; }

        public Animal()
        {
            Name = "Null";
        }
        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal is speaking");
        }
    }
}
