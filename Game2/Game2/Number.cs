using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Number
    {
        public int[] Generate()
        {
            int[] num = new int[4];
            var r = new Random();
            int i = 1, f = 0;
            num[0] = r.Next(1, 9);
            while (i < 4)
            {
                int rnd = r.Next(0, 9);
                for (int j = 0; j < i; j++)
                {
                    if (num[j] == rnd)
                    {
                        f = 1;
                    }
                }
                if (f == 0)
                {
                    num[i] = rnd;
                    i++;
                }
                f = 0;
            }
            return num;
        }
    }
}
