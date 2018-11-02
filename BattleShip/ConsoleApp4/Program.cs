using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeBatl
{
    public class Game
    {
        static void Main(string[] args)
        {
            var Polee1 = new Pole1();
            var Polee2 = new Pole2();
            string[,] pole22 = Polee2.pole2();
            for (int i = 0; i < pole22.GetLength(0); i++)
            {
                for (int j = 0; j < pole22.GetLength(1); j++)
                {
                    Console.Write(pole22[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            string[,] pole11 = Polee1.pole1();
            for (int i = 0; i < pole11.GetLength(0); i++)
            {
                for (int j = 0; j < pole11.GetLength(1); j++)
                {
                    Console.Write(pole11[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        
    }
}
