﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Rectangle rect1;
            rect1.length = 100;
            rect1.width = 30;
            Console.WriteLine("rectangle length:{0}, widhth:{1}", rect1.length, rect1.width);

            Rectangle rect2 = new Rectangle(200, 50);

            Console.WriteLine("rectangle length:{0}, widhth:{1}, Area:{2}", rect2.length, rect2.width, rect2.Area());
            */
            Console.WriteLine("Class Animal");
            Console.WriteLine("===========================");
            Animal fox = new Animal("fox", "Paaww");
            fox.MakeSound();           

            Animal wolf = new Animal("wolf", "Auuu");
            wolf.MakeSound();

            Animal horse = new Animal("horse", "iehing");
            horse.MakeSound();

            Animal hwak = new Animal("hwak", "hwakhwak");
            hwak.MakeSound();

            Console.WriteLine ("NumofAnimals : {0}", Animal.GetNumofAnimals());
            Console.WriteLine(String.Empty);
            Console.WriteLine("ShpaeMath");
            Console.WriteLine("===========================");
            Console.WriteLine("Area of Rectangle = {0}", ShapeMath.GetArea("rectangle", 5, 6));
            Console.WriteLine("Area of Triangle = {0}", ShapeMath.GetArea("triangle", 5, 6));
            Console.WriteLine("Area of Circle = {0}", ShapeMath.GetArea("circle", 5, 6));
            Console.ReadLine();
        }

        struct Rectangle
        {
            public double length;
            public double width;

            public Rectangle(double l, double w)
            {
                length = l;
                width = w;
            }

            public double Area()
            {
                return length * width;
            }
        }
    }
}
