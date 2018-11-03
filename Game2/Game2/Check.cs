using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class Check
    {
        public int[] Checking(int[] number, int[] gennum)
        {
            int[]result=new int[2];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if ((number[i] == gennum[j]) && (i == j))
                    {
                        result[0]++;
                    }
                    if ((number[i] == gennum[j]) && (i != j))
                    {
                        result[1]++;
                    }

                }

            }

            return result;
        }
    }
}
