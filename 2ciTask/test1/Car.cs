using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Car
    {
        public string brand;
        public ushort price;
        public short speed;
        public string color;

        public Car()
        {

        }

        public Car(string brand, ushort price, short speed, string color)
        {
            this.brand = brand;
            this.price = price;
            this.speed = speed;
            this.color = color;
        }

        public string GetDetails()
        {
            return $"{brand} {price} {speed} {color}";
        }
    }
}
