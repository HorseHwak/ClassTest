using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTest
{
    public static class QuizClass
    {
        public static void Quiz1()
        {
            int sum = 0;

            for (int i = 1; i < 1000; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                    sum += i;
            }
            Console.WriteLine("1~1000사이 3과5의 배수의 합은 : {0} 입니다", sum);
        }

        public static void Quiz2()
        {
            int[] fibo = new int[100];
            int sum = 0;

            //피보나치수열 
            for (int i = 0; i < fibo.Length; i++)
            {
                if (i == 0 || i == 1)
                    fibo[i] = 1;

                else if (fibo[i - 1] < 4000000 && fibo[i - 2] < 4000000)
                    fibo[i] = fibo[i - 1] + fibo[i - 2];
            }

            //짝수판별
            for (int i = 0; i < fibo.Length; i++)
            {
                if (fibo[i] < 4000000 && fibo[i] % 2 == 0)
                    sum += fibo[i];
            }

            Console.WriteLine("피보나치 수열 : {0}\n", string.Join<int>(",", fibo));
            Console.WriteLine("짝수의 합 : {0}", sum);
        }

        public static void Quiz3()
        {
            long Decimal = 600851475143;
            long Primefactor = Decimal;

            for (long i = 2; i < Primefactor; i++)
            {
                if (Primefactor % i == 0)
                     Primefactor =  Primefactor / i;
            }
            Console.WriteLine("{0}의 최대 소인수는 {1}입니다.", Decimal, Primefactor);
        }

        public static void Quiz4()
        {
            int value = 0;

            while (true)
            {
                value++;
                if (value % 1 == 0 && value % 2 == 0 && value % 3 == 0 && value % 4 == 0 && value % 5 == 0 &&
                   value % 6 == 0 && value % 7 == 0 && value % 8 == 0 && value % 9 == 0 && value % 10 == 0 &&
                   value % 11 == 0 && value % 12 == 0 && value % 13 == 0 && value % 14 == 0 && value % 15 == 0 &&
                   value % 16 == 0 && value % 17 == 0 && value % 18 == 0 && value % 19 == 0 && value % 20 == 0)
                    break;  
            }
            Console.WriteLine("1부터 20까지의 숫자로 모두 나눠지는 최소의 수는 {0}입니다.", value);
        }

        public static void Quiz5()
        {
            int[] PrimeNumber= new int[10005];
            int j,k = 0;

            for (int i = 0; i < 105000; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        break;
                }
                if (j == i)
                {
                    PrimeNumber[k] = i;
                    if (k < 10001)
                    {
                        k++;
                    }
                }                      
            }

            Console.WriteLine("소수 배열 : {0}\n", string.Join<int>(",", PrimeNumber));
            Console.WriteLine("10001번째 소수 : {0}\n", PrimeNumber[10000]);







        }
    }
}
