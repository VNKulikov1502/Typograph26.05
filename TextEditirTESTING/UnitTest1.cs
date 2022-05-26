using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextEditor;
using System.IO;
using System.Collections.Generic;



namespace TextEditirTESTING
{
    [TestClass]
    public class UnitTest1
    {
        public string DoAbsurdRule(string input)
        {
            if (input.Contains("б"))
            {
                input = input.Replace("б", "барабара беребере");

            }
            if (input.Contains("Б"))
            {
                input = input.Replace("Б", "барабара беребере");

            }
            return input;
        }
        public string DoRule1(string str)
        {
            if ((str.Contains("*")))
            {
                str = str.Replace("*", "×");
            }
            if ((str.Contains(" *")))
            {
                str = str.Replace(" *", "×");
            }
            return str;
        }
        public string DoRule2(string input)
        {

            if (input.Contains("..."))
            {
                input = input.Replace("...", "…");
            }
            return input;
        }
        private string DoRule3(string input)
        {
            if ((input.Contains("—")))
            {
                input = input.Replace("—", (char)(160) + "—");
            }
            if ((input.Contains(" —")))
            {
                input = input.Replace(" —", (char)(160) + "—");
            }
            if ((input.Contains("-")))
            {
                input = input.Replace("-", (char)(160) + "—");
            }
            if ((input.Contains("-")))
            {
                input = input.Replace("-", (char)(160) + "—");
            }
            return input;
        }
        private string DoRule4(string str)
        {
            string path = "YoWords.txt";
            var YoWords = new Dictionary<string, string>();
            using (StreamReader stream = new StreamReader(path))
            {
                while (!stream.EndOfStream)
                {
                    string allwords = stream.ReadLine();
                    string[] words = allwords.Split(':');
                    YoWords.Add(words[0], words[1]);
                }
                foreach (var word in YoWords)
                {
                    if (str.ToLower().Contains(word.Key))
                    {
                        str = str.ToLower().Replace(word.Key, word.Value);
                    }
                }
            }
            return str;
        }

        [TestMethod]
        public void DoAbsurdRuleText()
        {
             string start = "бабушка потерялась";
             string expected = "барабара беребереабарабара беребереушка потёрялась";
            string result = DoAbsurdRule(start);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DoRule1Test_3parametres()
        {
            string start = "26*46*27";
            string expected = "25x46x27";
            string result = DoRule1(start);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DoRule1Test_2parametres()
        {
            string start = "26*46";
            string expected = "25x46";
            string result = DoRule1(start);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DoRule2Test()
        {
            string start = "а мы мешали любовь с табаком..."; 
            string expected = "а мы мешали любовь с табаком…";
            string result = DoRule2(start);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DoRule2Test_failedparametr()
        {
            string start = "а мы мешали любовь с табаком.  ..";
            string expected = "а мы мешали любовь с табаком…";
            string result = DoRule2(start);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void DoRule3Test()
        {
            string start = "голландия - страна тюльпанов";
            string expected = "голландия - страна тюльпанов";
            string result = DoRule3(start);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DoRule4Test()
        {
            string start = "матвей получил чапалах от Родиона";
            string expected = "Матвей получил чаполах от Родиона";
            string result = DoRule4(start);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void DoRule4Test_anothername()
        {
            string start = "саша - лучшая девочка";
            string expected = "Саша - лучшая девочка";
            string result = DoRule4(start);
            Assert.AreEqual(expected, result);
        }
    } 
}
