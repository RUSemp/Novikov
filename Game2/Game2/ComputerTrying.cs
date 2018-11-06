using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game2
{
    public class ComputerTrying
    {
        public int[] TryNumber(int[] bulcow, int[] answer)
        {
            var r = new Random();
           
            if (bulcow[0] != 4)
            {
                answer[bulcow[0]]++;
            }

            return answer;


        }
    }
}
