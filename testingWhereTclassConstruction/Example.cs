using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testingWhereTclassConstruction
{
    public class Example<T> where T : class  
    {
        public List<T> values = new List<T>();
        T[] arrValues;
        T value; 

        public Example(T value)
        {
            values.Add(value);
        }
        public Example()
        {
            
        }

        public void AddPerson(T value)
        {
            values.Add(value);
        }

        public T ShowFirstPerson()
        {
            return values[0];   
        }

        public T ShowLastPerson()
        {
            return values[values.Count - 1];
        }

        public T ShowPersonForIndex(int target)
        {
            return values[target];  
        }
    }
}
