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
            var comp = new ComputerTrying();
            int[] answer = new int[4], bulcow=new int[2];
            int[] num = Num.Generate();
            int i;
            
            for (i=0;i<4;i++)
            {
                Console.Write(num[i]);
                answer[i] = -1;
            }
            Console.WriteLine();

            while (bulcow[0] != 4)
            {
                answer = comp.TryNumber(bulcow,answer);
                for (i = 0; i < 4; i++)
                {
                    Console.Write(answer[i]);
                }
                Console.WriteLine();
                bulcow = check.Checking(answer, num);
                Console.WriteLine($"{bulcow[0]} быков {bulcow[1]} коров");
                if (bulcow[0] == 4)
                {
                    Console.Write("Заданное число: ");
                    for (i = 0; i < 4; i++)
                    {
                        Console.Write(answer[i]);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
