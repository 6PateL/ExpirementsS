using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expirements.Executers
{
    public class ExecuteReverse<Tvalue> where Tvalue : IComparable 
    {
        public ExecuteReverse()
        {
            
        }

        public ExecuteReverse(Tvalue[] values)
        {
            ReverseArray(values); 
        }

        public Tvalue[] ReverseArray(Tvalue[] values)
        {
            var reverse = new StupidReverse<Tvalue>();
            reverse.Reverse();

            for (int i = 0; i < values.Length; i++) 
            {
                Tvalue[] tValueArray = { reverse.Items[i] };
                return tValueArray;
            }

            return default(Tvalue[]);
        }
    }
}
