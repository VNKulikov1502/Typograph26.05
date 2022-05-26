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
        private void DoRule1(string str)
        {
            if ((str.Contains("*")))
            {
                str = str.Replace("*", "×");
            }
            if ((str.Contains(" *")))
            {
                str = str.Replace(" *", "×");
            }
        }

        [TestMethod]
        public void DoAbsurdRuleText()
        {
             string start = "бабушка потерялась";
             string expected = "барабара беребереабарабара беребереушка потёрялась";
            Form1 frm = new Form1();
            string result = DoAbsurdRule(start);
            Assert.AreEqual(expected, result);
        }
        public void DoRule
    } 
}
