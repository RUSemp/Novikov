using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class ComputerTrying
    {
        public int[] TryNumber(int[] bulcow)
        {
            int[] num = new int[4], save=new int[4];
            int i, j;
            var r = new Random();
            if((bulcow[0]==0)&&(bulcow[1]==0))
            {
                for(i=0;i<4;i++)
                {
                    num[i] = r.Next(0, 9);
                }
            }
            

        }
    }
}
