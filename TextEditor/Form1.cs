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
        private static string FirstUpper(string str)
        {
            string[] s = str.Split(' ');

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i].Length > 1)
                    s[i] = s[i].Substring(0, 1).ToUpper() + s[i].Substring(1, s[i].Length - 1).ToLower();
                else s[i] = s[i].ToUpper();
            }
            return string.Join(" ", s);
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
                        richTextBox1.Text = str.ToLower().Replace(word.Key, word.Value);
                    }
                }
            }
            return str;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
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
        private void DoRule2(string input)
        {
            
            if (input.Contains("..."))
            {
                richTextBox1.Text = input.Replace("...", "…");
            }
        }
        private void DoRule3(string input)
        {
            if ((input.Contains("—")))
            {
                richTextBox1.Text = input.Replace("—", (char)(160) + "—");
            }
            if ((input.Contains(" —")))
            {
                richTextBox1.Text = input.Replace(" —", (char)(160) + "—");
            }
            if ((input.Contains("-")))
            {
                richTextBox1.Text = input.Replace("-", (char)(160) + "—");
            }
            if ((input.Contains("-")))
            {
                richTextBox1.Text = input.Replace("-", (char)(160) + "—");
            }
        }
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
        private void button1_Click(object sender, EventArgs e)
        {
            DoRule1(richTextBox1.Text);
            DoRule2(richTextBox1.Text);
            DoRule3(richTextBox1.Text);
            DoRule4(richTextBox1.Text);
            DoRule5(richTextBox1.Text);
            richTextBox1.Text = DoAbsurdRule(richTextBox1.Text);
            richTextBox1.Text = DoRule4(richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Любовь как дым - сегодня есть, а завтра мы не курим...";
        }
        public void DoRule5(string input)
        {
            List<string> names = new List<string>();
            using (StreamReader reader = new StreamReader("Names.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] arrayNames = reader.ReadLine().Split(' ');
                    names.Add(arrayNames[0]);
                }
                foreach (var name in names)
                {
                    if (input.Contains(name.ToLower()))
                    {
                        richTextBox1.Text = input.Replace(name.ToLower(), name);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(richTextBox1.Text);
                streamWriter.Close();
            }
        }
    }
}
