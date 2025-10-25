using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            dictionary.Add("blue", new List<string>() { "я" });
            dictionary.Add("green", new List<string>() { "трава", "мяч" });
            dictionary.Add("red", new List<string>() { "яблоко", "мясо", "велосипед" });
        }
    }
}
