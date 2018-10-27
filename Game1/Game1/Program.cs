using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Num = new Number();
            var trying = new Trying();
            int[] num = Num.Generate();
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write(num[i]);
            }
            Console.WriteLine();
            string f = "да", result= "";
            int number;
            while ((f != "нет")||(result!= "Вы угадали число!"))
            {
                Console.Write("Введите число: ");
                number = Convert.ToInt32(Console.ReadLine());
                result = trying.Check(number, num);
                Console.WriteLine(result);
                Console.WriteLine("Продолжить?");
                f = Console.ReadLine();
            }


            Console.ReadKey();
        }
    }
}
