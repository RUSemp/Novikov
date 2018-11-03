using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    class Program
    {
        static void Main(string[] args)
        {
            var Num = new Number();
            var check = new Check();
            int[] num = Num.Generate()/*,test = new int[2], testnum = new int[4]*/;
            int i;
            for (i=0;i<4;i++)
            {
                Console.Write(num[i]);
            }
            Console.WriteLine();
            //for (i = 0; i < 4; i++)
            //{
            //    testnum[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine();
            //for (i = 0; i < 4; i++)
            //{
            //    Console.Write(testnum[i]);
            //}

            //test = check.Checking(testnum, num);
            //Console.WriteLine($"{test[0]} bulls, {test[1]} cows");




            Console.ReadKey();
        }
    }
}
