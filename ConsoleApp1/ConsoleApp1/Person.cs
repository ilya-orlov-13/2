using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string Name { get; set; }
        public int Height { get; set; }

        public Person(string name, int height)
        {
            Name = name;
            Height = height;
        }

        public override string ToString()
        {
            return $"{Name}, рост: {Height}";
        }
    }
}
