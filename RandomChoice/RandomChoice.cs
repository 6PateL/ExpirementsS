using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomChoice
{
    public class RandomChoice
    {
        private List<int> _exceptedNumbers = new List<int>();
        private Random rnd = new Random(); 

        public RandomChoice()
        {
            
        }

        public void SetExceptedNumbers(int[] numbers) 
        {
            _exceptedNumbers.AddRange(numbers);
        }
        public void SetExceptedNumber(int number)
        {
            _exceptedNumbers.Add(number); 
        }

        public int GetRandom(int min, int max)
        {
            return rnd.Next(min, max); 
        }
        public int GetRandomWithExceptedNumbers(int min, int max)
        {
            int random = rnd.Next(min, max);
            do
            {
                random = rnd.Next(min, max);
            }
            while(_exceptedNumbers.Contains(random));
            return random; 
        }
    }
}
