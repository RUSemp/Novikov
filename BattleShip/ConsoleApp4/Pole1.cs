using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeBatl
{
    public class Pole1
    {
        public string[,] pole1()
        {
            const int one = 1;
            const int two = 2;
            const int three = 3;
            const int fore = 4;
            string[,] pole11 = new string[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    pole11[i, j] = "+";
                }
            }
            Console.Write(pole11);
            return pole11;
        }
    }
}
