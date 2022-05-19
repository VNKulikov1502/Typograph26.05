using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void DoRule4()
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
                    if (richTextBox1.Text.Contains(word.Key))
                    {
                        richTextBox1.Text = richTextBox1.Text.Replace(word.Key, word.Value);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }
        private void DoRule1()
        {
            if ((richTextBox1.Text.Contains("*")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("*", "×");
            }
            if ((richTextBox1.Text.Contains(" *")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace(" *", "×");
            }
        }
        private void DoRule2()
        {
            
            if (richTextBox1.Text.Contains("..."))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("...", "…");
            }
        }
        private void DoRule3()
        {
            if ((richTextBox1.Text.Contains("—")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("—", (char)(160) + "—");
            }
            if ((richTextBox1.Text.Contains(" —")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace(" —", (char)(160) + "—");
            }
            if ((richTextBox1.Text.Contains("-")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("-", (char)(160) + "—");
            }
            if ((richTextBox1.Text.Contains("-")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("-", (char)(160) + "—");
            }
        }
        private void DuAbsurdRule()
        {
            if (richTextBox1.Text.Contains("б"))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("б", "барабара беребере");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoRule1();
            DoRule2();
            DoRule3();
            DoRule4();
            DuAbsurdRule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Любовь как дым - сегодня есть, а завтра мы не курим...";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
