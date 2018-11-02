using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeBatl
{
    public class Pole2
    {
        public string[,] pole2()
        {
            var Onep = new Onepalub();
            const int one = 4;
            const int two = 3;
            const int three = 2;
            const int fore = 1;
            string[,] pole22 = new string[10, 10];
            string onep = Onep.Onepalub1();
            for (int i = 0; i<10;i++)
            {
                for (int j = 0; j<10;j++)
                {
                    pole22[i,j] = "+";
                }
            }
            Console.Write("Введите координаты однопалубных кораблей: ");
            int gor = Convert.ToInt32(Console.ReadLine());
            int ver = Convert.ToInt32(Console.ReadLine());
            for (int q = 0; q < one; q++)
            {
                for (int i = 0; i < pole22.GetLength(0); i++)
                {
                    for (int j = 0; j < pole22.GetLength(1); j++)
                    {
                        if((gor == i)&&(ver == j))
                        {
                            Console.Write(onep);
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.Write(pole22);
            return pole22;
        }
    }
}
