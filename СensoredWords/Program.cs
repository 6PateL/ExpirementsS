using System;
using SayGoodWords; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СensoredWords
{
    public class Program
    {
        static void Main(string[] args)
        {
            var censored = new CensoredWords();
            censored.SetBadWords(new string[] { "suka", "blyat", "Xui" }); 
            Console.WriteLine(censored.Analyze("ax ti suka"));
        }
    }
}
