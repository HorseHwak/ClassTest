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
                    Primefactor = Primefactor / i;
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
            int[] PrimeNumber = new int[10005];
            int j, k = 0;

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

        public static void Quiz6()
        {
            int RepHorizontal = 0, RepVertical = 0, RepDigonal1 = 0, RepDigonal2 = 0;
            int result = 0;
            int[,] Lattice = new int[20,20] { { 08, 02, 22, 97, 38, 15, 00, 40, 00, 75, 04, 05, 07, 78, 52, 12, 50, 77, 91, 08 },
                                              { 49, 49, 99, 40, 17, 81, 18, 57, 60, 87, 17, 40, 98, 43, 69, 48, 04, 56, 62, 00 },
                                              { 81, 49, 31, 73, 55, 79, 14, 29, 93, 71, 40, 67, 53, 88, 30, 03, 49, 13, 36, 65 },
                                              { 52, 70, 95, 23, 04, 60, 11, 42, 69, 24, 68, 56, 01, 32, 56, 71, 37, 02, 36, 91 },
                                              { 22, 31, 16, 71, 51, 67, 63, 89, 41, 92, 36, 54, 22, 40, 40, 28, 66, 33, 13, 80 },
                                              { 24, 47, 32, 60, 99, 03, 45, 02, 44, 75, 33, 53, 78, 36, 84, 20, 35, 17, 12, 50 },
                                              { 32, 98, 81, 28, 64, 23, 67, 10, 26, 38, 40, 67, 59, 54, 70, 66, 18, 38, 64, 70 },
                                              { 67, 26, 20, 68, 02, 62, 12, 20, 95, 63, 94, 39, 63, 08, 40, 91, 66, 49, 94, 21 },
                                              { 24, 55, 58, 05, 66, 73, 99, 26, 97, 17, 78, 78, 96, 83, 14, 88, 34, 89, 63, 72 },
                                              { 21, 36, 23, 09, 75, 00, 76, 44, 20, 45, 35, 14, 00, 61, 33, 97, 34, 31, 33, 95 },
                                              { 78, 17, 53, 28, 22, 75, 31, 67, 15, 94, 03, 80, 04, 62, 16, 14, 09, 53, 56, 92 },
                                              { 16, 39, 05, 42, 96, 35, 31, 47, 55, 58, 88, 24, 00, 17, 54, 24, 36, 29, 85, 57 },
                                              { 86, 56, 00, 48, 35, 71, 89, 07, 05, 44, 44, 37, 44, 60, 21, 58, 51, 54, 17, 58 },
                                              { 19, 80, 81, 68, 05, 94, 47, 69, 28, 73, 92, 13, 86, 52, 17, 77, 04, 89, 55, 40 },
                                              { 04, 52, 08, 83, 97, 35, 99, 16, 07, 97, 57, 32, 16, 26, 26, 79, 33, 27, 98, 66 },
                                              { 88, 36, 68, 87, 57, 62, 20, 72, 03, 46, 33, 67, 46, 55, 12, 32, 63, 93, 53, 69 },
                                              { 04, 42, 16, 73, 38, 25, 39, 11, 24, 94, 72, 18, 08, 46, 29, 32, 40, 62, 76, 36 },
                                              { 20, 69, 36, 41, 72, 30, 23, 88, 34, 62, 99, 69, 82, 67, 59, 85, 74, 04, 36, 16 },
                                              { 20, 73, 35, 29, 78, 31, 90, 01, 74, 31, 49, 71, 48, 86, 81, 16, 23, 57, 05, 54 },
                                              { 01, 70, 54, 71, 83, 51, 54, 69, 16, 92, 33, 48, 61, 43, 52, 01, 89, 19, 67, 48 } };

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (i <= 16)
                        RepHorizontal =  Lattice[i, j] * Lattice[i + 1, j] * Lattice[i + 2, j] * Lattice[i + 3, j];
                    if (j <= 16)
                        RepVertical = Lattice[i, j] * Lattice[i, j + 1] * Lattice[i, j + 2] * Lattice[i, j + 3];
                    if (i <= 16 && j <= 16)
                        RepDigonal1 = Lattice[i, j] * Lattice[i + 1, j + 1] * Lattice[i + 2, j + 2] * Lattice[i + 3, j + 3];
                    if (i <= 16 && j >= 3)
                        RepDigonal2 = Lattice[i, j] * Lattice[i + 1, j - 1] * Lattice[i + 2, j - 2] * Lattice[i + 3, j - 3];

                    if (RepHorizontal > result)
                    { result = RepHorizontal; }
                    if(RepVertical > result)
                    { result = RepVertical; }
                    if(RepDigonal1 > result)
                    { result = RepDigonal1; }
                    if(RepDigonal2 > result)
                    { result = RepDigonal2; }
                }
            }
            Console.WriteLine("수평, 수직, 또는 대각선 방향으로 연속된 숫자 네 개의 곱 중 최대값은 {0}입니다.", result);
        }
    }
}
