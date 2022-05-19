using System;
using System.IO;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            string path = "YoWords.txt";
            List<string> YoWords = new List<string>();
            List<string> NotYoWords = new List<string>();
            using (StreamReader stream = new StreamReader(path))
            {
                while (!stream.EndOfStream)
                {
                    string[] words = stream.ReadLine().Split(':');
                    NotYoWords.Add(words[0]);
                    YoWords.Add(words[1]);
                }
                
                
            }
            

        }
    }
}
