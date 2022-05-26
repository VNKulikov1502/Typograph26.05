using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TextEditor;

namespace TextEditorTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DoAbsurdRuleTest()
        {
            //Arrange
            string beginning = "Бабушка заблудилась";
            string expected = " барабара беребере абушка заблудилась";
            Form1 frm = new Form1();
          
            
            //private void DoAbsurdRule(string input)
            //{
            //    if (input.Contains("б"))
            //    {
            //        richTextBox1.Text = input.Replace("б", " барабара беребере ");
            //    }
            //    if (input.Contains("Б"))
            //    {
            //        richTextBox1.Text = input.Replace("Б", " барабара беребере ");
            //    }
            //}
        }
    }
}
