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
        
    }
}
