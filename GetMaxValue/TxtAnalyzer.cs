using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace GetValue
{
    public class TxtAnalyzer
    {
        private string _path; 

        public TxtAnalyzer(string path)
        {
            _path = path;
        }
        public TxtAnalyzer()
        {

        }
        public void SetPath(string  path)
        {
            _path = path;   
        }
        
        public int[] GetInformationArray()
        {
            string content;
            int[] convertedContent = { }; 

            using(FileStream file = new FileStream(_path, FileMode.Open))
            {
                using(StreamReader sr = new StreamReader(file))
                {
                    content = sr.ReadToEnd(); 
                }
            }

            for(int i = 0; i < content.Length; i++)
            {
                convertedContent = new int[] { content[i] };
            }

            return convertedContent; 
        }
        public int GetMax() 
        {
            int[] result = GetInformationArray();
            int max = result[0]; 

            for(int i = 0; i < result.Length; i++)
            {
                if(max < result[i])
                {
                    max = result[i]; 
                }
            }

            return max; 
        }
        public int GetMin()
        {
            int[] result = GetInformationArray();
            int min = result[0]; 

            for(int i = 0; i < result.Length; i++)
            {
                if(min > result[i])
                {
                    min = result[i]; 
                }
            }

            return min; 
        }

        public int GetLast()
        {
            int[] result = GetInformationArray();
            return result[result.Length - 1]; 
        }
        public int GetCurrent()
        {
            int[] result = GetInformationArray();
            return result[0]; 
        }
        
        public int? GetCurrentIndex(int Index)
        {
            int[] result = GetInformationArray();
            
            for(int i = 0; i < result.Length; i++)
            {
                if (result[i] == result[Index])
                {
                    return Index; 
                }
            }

            throw new Exception("Index was not found"); 
        }
        public int? FindElement(int target)
        {
            int[] result = GetInformationArray(); 

            for(int i = 0; i < result.Length; i++)
            {
                if (result[i] == target)
                {
                    return target; 
                }
            }

            throw new Exception("Element was not found"); 
        }
    }
}
