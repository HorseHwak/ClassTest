using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public static class PracticeCalss
    {

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
        public static void practice1()
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
            animals.Add(new Animal("pig", "GgulGgul"));

            /* var findanimals = animals[2];

             findanimals.MakeSound();*/

            bool bFound = false;

            foreach (var animal in animals)
            {
                var animalName = animal.GetName();
                if (animalName == "pig")
                {
                    bFound = true;
                    break;
                }
            }
            if (bFound)
            {
                Console.WriteLine("Find pig");
            }
            else
            {
                Console.WriteLine("Not Found pig");
            }

            Animal findPig = animals.Find(item => item.GetName().Equals("pig"));
            if (findPig != null)
            {
                Console.WriteLine("Found my pig again");
                Console.Write(">> ");
                findPig.MakeSound();
            }
            else
                Console.WriteLine("Not Found Pig");

            Animal myhorse = animals.Find(item => item.GetName().Equals("horse"));
            if (myhorse != null)
            {
                Console.WriteLine("Found my horse again");
                Console.Write(">> ");
                myhorse.MakeSound();
            }


            Dictionary<enAnimalType, Animal> dicAnimals = new Dictionary<enAnimalType, Animal>();
            dicAnimals.Add(enAnimalType.fox, new Animal("red", "Paaww"));
            dicAnimals.Add(enAnimalType.wolf, new Animal("blue", "Auuu"));
            dicAnimals.Add(enAnimalType.horse, new Animal("pink", "iehing"));
            dicAnimals.Add(enAnimalType.hwak, new Animal("green", "hwakhwak"));

            var someAnimal = dicAnimals[enAnimalType.horse];

            foreach (KeyValuePair<enAnimalType, Animal> item in dicAnimals)
            {
                var key = item.Key;
                var value = item.Value;

                value.MakeSound();
            }

            foreach (var item in dicAnimals.Values)
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

            Console.WriteLine("NumofAnimals : {0}", Animal.GetNumofAnimals());
            Console.WriteLine(String.Empty);
            Console.WriteLine("ShpaeMath");
            Console.WriteLine("===========================");

            Console.WriteLine("Rectangle Area = {0}", ShapeMath.GetArea(enShape.Rectangle, 5, 6));
            Console.WriteLine("Triangle Area = {0}", ShapeMath.GetArea(enShape.Triangle, 5, 6));
            Console.WriteLine("Circle Area = {0}", ShapeMath.GetArea(enShape.Circle, 5, 6));


            Console.ReadLine();
        }

        public static void practice2()
        {
            string str = "Kunsan University" + " " + "is jjang";
            //Console.WriteLine(str.Substring(str.IndexOf("University")));

            //example 1
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i).Append(" ");
            }

            Console.WriteLine(sb.ToString());

            //example 2
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("The list starts here.");
            sb2.AppendLine();
            sb2.Append("1 cat").AppendLine();

            string str2 = sb2.ToString();
            Console.WriteLine(str2);

            //example 3
            StringBuilder sb3 = new StringBuilder("Korea University");
            sb3.Replace("Korea", "Kunsan");
            Console.WriteLine(sb3.ToString());

            string[] items = { "Cat", "Dog", "Fox", "Pig" };
            //example 4
            StringBuilder sb4 = new StringBuilder("These animals are requird:").AppendLine();

            foreach (string item in items)
            {
                sb4.Append(item).AppendLine();
            }
            Console.WriteLine(sb4.ToString());

            //example 5
            StringBuilder sb5 = new StringBuilder("Knsan is University");
            sb5.Remove(6, 3);
            Console.WriteLine(sb5.ToString());

            //example 6
            StringBuilder sb6 = new StringBuilder();
            sb6.Append("Kunsan University.");

            TrimEnd(sb6, '.');
            Console.WriteLine(sb6.ToString());
        }

        private static void TrimEnd(StringBuilder value, char a)
        {
            if (value.Length == 0) return;

            if (value[value.Length - 1] == a)
            {
                value.Length -= 1;
            }
        }

        public static void practice3()
        {
           // Console.WriteLine(Math.Sqrt(10.2));

            Tuple<string, double>[] areas =
                     { Tuple.Create("Sitka, Alaska", 2870.3),
                       Tuple.Create("New York City", 302.6),
                       Tuple.Create("Los Angeles", 468.7),
                       Tuple.Create("Detroit", 138.8),
                       Tuple.Create("Chicago", 227.1),
                       Tuple.Create("San Diego", 325.2) };

            Console.WriteLine("{0,-18} {1,14:N1} {2,30}\n", "City", "Area (mi.)",
                              "Equivalent to a square with:");

            foreach (var area in areas)
                Console.WriteLine("{0,-18} {1,14:N1} {2,14:N2} miles per side",
                                  area.Item1, area.Item2, Math.Round(Math.Sqrt(area.Item2), 2));
           // Console.WriteLine(Math.Max(1,2));
        }

        public static void practice4()
        {
            string strID1 = "Gwak";
            string strPW1 = "1234";

            while (true)
            {
                Console.Write("Enter your ID : ");
                string strID2 = Console.ReadLine();

                if (strID1.ToLower() == strID2.ToLower())
                {
                    Console.Write("Enter your PW : ");
                    string strPW2 = Console.ReadLine();

                    if (strPW1 == strPW2)
                    {
                        Console.WriteLine("로그인 성공!");
                        return;
                    }
                    else
                        Console.WriteLine("비밀번호가 일치하지 않습니다.");
                }
                else
                    Console.WriteLine("아이디가 일치하지 않습니다.");

            }
        }
    }
}
