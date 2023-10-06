using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expirements
{
    public abstract class Compare<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>(); 
        
        protected void Swap(int posA, int posB)
        {
            if (posA < Items.Count && posB < Items.Count)
            {
                var temp = Items[posA];
                Items[posA] = Items[posB];
                Items[posB] = temp; 
            }
        }

        protected virtual void Sort()
        {
            Items.Sort();   
        }

        public virtual void Reverse()
        {
            Items.Reverse(); 
        }
    }
}
