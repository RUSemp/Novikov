using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    public class Trying
    {

        public string Check(int number, int[] num)
        {
            int cows=0, bulls=0;
            int[] trynum = new int[4];
            for(int i=3;i>-1;i--)
            {
                trynum[i] = number % 10;
                number = number / 10;
                for (int j=0;j<4;j++)
                {
                    if ((trynum[i]==num[j])&&(i==j))
                    {
                        bulls++;
                    }
                    if ((trynum[i]==num[j])&&(i!=j))
                    {
                        cows++;
                    }

                }
                
            }

            if (bulls<4)
            {
                return ($"{bulls} Быков, {cows} Коров");
            }
            else
            {
                return ("Вы угадали число!");
            }
            
            
        }

    }
}
