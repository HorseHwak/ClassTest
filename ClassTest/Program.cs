using System;
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
            Console.WriteLine(String.Empty);
            Console.WriteLine("Class Animal");
            Console.WriteLine("===========================");

            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("fox", "Paaww"));
            animals.Add(new Animal("wolf", "Auuu"));
            animals.Add(new Animal("horse", "iehing"));
            animals.Add(new Animal("hwak", "hwakhwak"));

            foreach(var animal in animals)
            {
                animal.MakeSound();
            }

            Dictionary<enAnimalType, Animal> dicAnimals = new Dictionary<enAnimalType, Animal>();
            dicAnimals.Add(enAnimalType.fox, new Animal("red", "Paaww"));
            dicAnimals.Add(enAnimalType.wolf, new Animal("blue", "Auuu"));
            dicAnimals.Add(enAnimalType.horse, new Animal("pink", "iehing"));
            dicAnimals.Add(enAnimalType.hwak, new Animal("green", "hwakhwak"));

            foreach(KeyValuePair<enAnimalType, Animal> item in dicAnimals)
            {
                var key = item.Key;
                var value = item.Value;

                value.MakeSound();
            }

            foreach(var item in dicAnimals.Values)
            {
                item.MakeSound();
            }

            Animal outAnimal;
            if (dicAnimals.TryGetValue(enAnimalType.tiger, out outAnimal))
            {
                outAnimal.MakeSound();
            }
            else
            {
                Console.WriteLine("[E] tiger not found");
            }

            Console.WriteLine ("NumofAnimals : {0}", Animal.GetNumofAnimals());
            Console.WriteLine(String.Empty);
            Console.WriteLine("ShpaeMath");
            Console.WriteLine("===========================");

            Console.WriteLine("Rectangle Area = {0}", ShapeMath.GetArea(enShape.Rectangle, 5, 6));
            Console.WriteLine("Triangle Area = {0}", ShapeMath.GetArea(enShape.Triangle, 5, 6));
            Console.WriteLine("Circle Area = {0}", ShapeMath.GetArea(enShape.Circle, 5, 6));


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
