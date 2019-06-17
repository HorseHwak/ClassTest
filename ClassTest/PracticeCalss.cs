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

        public static void practice5()
        {
            /*Console.WriteLine(31.50 * 9 / 5 + 32);

            int a;

            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine("*** {0}단 ***", i);
                for (int k = 1; k < 10; k++)
                {
                    a = i * k;
                    Console.WriteLine("{0} x {1} = {2}", i,k, a);
                }
                Console.WriteLine("\n");
            }
            

            Console.Write("Enter line number : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            string text = "*";

            for (int i = 0; i < Number; i++)
            {                          
                for (int j = 0; j < Number; j++)
                {
                    Console.WriteLine(text);
                    text += "*";
                }
            }
            Console.Write("점수입력 : ");
            string input = Console.ReadLine();

            int score = int.Parse(input);

            if (score >= 90) { Console.WriteLine("학점 : A");}
            else if (score >= 80) { Console.WriteLine("학점 : B"); }
            else if (score >= 70) { Console.WriteLine("학점 : C"); }
            else if (score >= 60) { Console.WriteLine("학점 : D"); }
            else if (score < 60) { Console.WriteLine("학점 : F"); }
            */

            int[] value = { 90, 75, 85, 95, 70, 75, 85, 85, 95, 72 };

            double sum = 0;
            for (int i = 0; i < value.Length; i++)
            {
                sum += value[i];
            }
            double avg = sum / value.Length;

            Console.WriteLine("점수 : {0}", string.Join<int>(",", value));
            Console.WriteLine("합계 : {0}", sum);
            Console.WriteLine("평균 : {0}", avg);
        }

        public static void practice6()
        {
            /*
            int[,] student = new int[5,3] { { 90, 80, 90 }, { 85, 85, 85 }, { 95, 70, 75 }, { 80, 80, 90 }, { 90, 75, 80 } };
                        
            //Console.WriteLine(student.Length);
            for (int i = 0; i < student.GetLength(0) ; i++)
            {
                double sum = 0;
                for (int j = 0; j < student.GetLength(1) ; j++)
                {
                    sum += student[i,j];
                }
                double avg = sum / student.GetLength(1);
                Console.WriteLine("ID={0} : 합계={1}, 평균={2:N2}", i, sum, avg);  
            }
            
            string Hel = "Hello World";
            string result = string.Empty;

            for (int i = 0; i < Hel.Length; i++)
            {
                char t = Hel[i];
                if (char.IsLower(t))
                {
                    t = char.ToUpper(t);
                }
                else if (char.IsUpper(t))
                {
                    t = char.ToLower(t);
                }
                result = result + t;
            }
            Console.WriteLine(result);
            
            */
            string Hel = "Hello World";
            string result = string.Empty;

            for (int i = 0; i < Hel.Length; i++)
            {
                char T = Hel[i];
                if ((T >= 'A' && T <= 'Z') || (T >= 'a' && T <= 'z'))
                {
                    T = (char)(T + 3);
                }
                result = result + T;
            }
            Console.WriteLine(result);


            int[] array = new int[] { 80, 90, 95, 75, 70 };
            int[] array1 = new int[] { 90, 85, 85, 85, 80 };

            Console.WriteLine("A : {0}", string.Join<int>(",", array));
            Console.WriteLine("Sum(A) = {0}", Sum(array));
            Console.WriteLine("B : {0}", string.Join<int>(",", array1));
            Console.WriteLine("Sum(B) = {0}", Sum(array1));


            Console.WriteLine("(3 + 5 - 2) x 2 / = {0}", dev(mul(minus(plus(3, 5), 2), 2), 3));


        }

        static int Sum(int[] data)
        {
            int sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }

            return sum;
        }

        static int plus(int data, int data1)
        {
            return data + data1;
        }
        static int minus(int data, int data1)
        {
            return data - data1;
        }
        static int mul(int data, int data1)
        {
            return data * data1;
        }
        static int dev(int data, int data1)
        {
            return data / data1;
        }

        public static void practice12()
        {
            // A : 3, 4, 5
            // B : 3, 3, 3

            //Triangle triA = new Triangle(3, 4, 5);

            List<Triangle> triangles = new List<Triangle>();
            triangles.Add(new Triangle(3, 4, 5));
            triangles.Add(new Triangle(3, 3, 3));
            triangles.Add(new Triangle(5, 4, 3));

            int index = 1;
            foreach (Triangle shape in triangles)
            {
                shape.Draw(index);
                index++;
            }

            /*
            index = 1;
            for (int i = 0; i < triangles.Count; i++)
            {
                Triangle shape = triangles[i];
                shape.Draw(index);
                index++;
            }
            */

            // Output
            // 삼각형1: A-3, B-4, C-5
            // 둘레길이: 12
            // 삼각형2: A-3, B-3, C-3
            // 둘레길이: 9
        }

        class Triangle
        {
            private int A, B, C;

            public Triangle(int a, int b, int c)
            {
                A = a;
                B = b;
                C = c;
            }
            public void Draw(int index)
            {
                int sum = A + B + C;
                Console.WriteLine("삼각형{0} : A={1}, B={2}, C={3}", index, A, B, C);
                Console.WriteLine("둘레길이:{0}", sum);
            }

        }

        public static void Quiz1()
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                     sum += i; 
            }
            Console.WriteLine("1~1000사이 3과5의 배수의 합은 : {0} 입니다", sum);
        }
        public static void Quiz2()
        {
            int[] fibo = new int[33];
            int sum = 0;

            //피보나치수열 
            for (int i = 0; i < fibo.Length; i++)
            {
                if(i == 0 || i == 1)
                fibo[i] = 1;
       
                else
                fibo[i] = fibo[i-1] + fibo[i-2];
            }

            //짝수판별
            for (int i = 0; i < fibo.Length; i++)
            {
                if (fibo[i] % 2 == 0)
                    sum += fibo[i];
            }
          
            Console.WriteLine("피보나치 수열 : {0}", string.Join<int>(",", fibo));
            Console.WriteLine("짝수의 합 : {0}", sum);
        }

        
    }
 }
