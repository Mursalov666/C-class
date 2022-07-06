using System;
using System.Text;

namespace Task
{

    public class Task
    {
        static void Main()
        {
            BMW bmw = new BMW();
            Mercedes mercedes = new Mercedes();

            bmw.brand = "M5 F10";
            bmw.price = 35000;
            bmw.speed = 330;
            bmw.color = "Black";

            mercedes.brand = "S63 AMG";
            mercedes.price = 45000;
            mercedes.speed = 300;
            mercedes.color = "White";

            Console.WriteLine(bmw.GetDetails());
            Console.WriteLine(mercedes.GetDetails());

        }

    }

}