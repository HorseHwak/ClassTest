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
        
    }
}
