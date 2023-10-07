using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SayGoodWords
{
    public class CensoredWords 
    {
        public List<string> _badWords = new List<string>();

        public CensoredWords()
        {
          
        }

        public void SetBadWords(string[] badWords)
        {
            _badWords.AddRange(badWords); 
        }

        public void SetBadWords(string badWord)
        {
            _badWords.Add(badWord);
        }

        public string Analyze(string text)
        {
            List<char[]> words = new List<char[]>();    
            DynamicArray currentWord = new DynamicArray(); 

            for(int i = 0; i < text.Length; i++)
            {
                currentWord.array[currentWord.currentSize] = text[i];
                currentWord.currentSize++; 

                if (text[i] == ' ')
                {
                    words.Add(currentWord.array);
                    words.Add(new char[] { ' ' });
                    currentWord = null;
                    continue; 
                }
            }

            for(int i = 0; i < words.Count; i++)
            {
                for(int j = 0; j < _badWords.Count; j++)
                {
                    if (words[i] == _badWords[j].ToCharArray())
                    {
                        words[i] = new char[] { '*' };
                        text = new string(words[i]);
                    }
                }
            }

            return text; 
        }
    }

    public class DynamicArray
    {
        public int maxSize;
        public int currentSize;
        public char[] array;

        public DynamicArray()
        {
             maxSize = 4000;
             currentSize = 0;
             array = new char[maxSize];
        }
    }
}
