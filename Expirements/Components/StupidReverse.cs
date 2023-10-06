using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expirements
{
    public class StupidReverse<T> : Compare<T> where T : IComparable
    {
        public override void Reverse()
        {
            for(int i = 0; i < Items.Count; i++)
            {
                Swap(i, i - 1); 
            }
        }
    }
}
