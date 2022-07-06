using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P228
{

    public class Cat
    {
        public string name;
        public string color;
        public byte age;

        public Cat()
        {

        }

        public Cat(string name, string color, byte age)
        {
            this.name = name;
            this.color = color;
            this.age = age;

            Console.WriteLine("Custom constructor worked");

        }

        public string GetDetails()
        {
            return $"{name} {color} {age}";
        }
    }
}

