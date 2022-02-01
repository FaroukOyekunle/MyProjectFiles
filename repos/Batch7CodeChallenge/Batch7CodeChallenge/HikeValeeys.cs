using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch7CodeChallenge
{
    class HikeValeeys
    {
      public static void countingValleys(int steps, string path)
        {
            int VALLEYS = 0;
            int ELEVATION = 0;
          //  Array steps = s.ToArray();
            foreach(char step in path)
            {
                Console.WriteLine(step);
                if (step == 'U')
                  ELEVATION++;
                else if(step == 'D')
                {
                    ELEVATION--;

                    if (ELEVATION == -1)
                        VALLEYS++;
                }
                Console.WriteLine(VALLEYS);

                 
                
            }
            
        } 
    }
}
