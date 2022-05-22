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

        private void DoRule4()
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
                    if (richTextBox1.Text.ToLower().Contains(word.Key))
                    {
                        richTextBox1.Text = richTextBox1.Text.ToLower().Replace(word.Key, word.Value);
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
                richTextBox1.Text = richTextBox1.Text.Replace("б", " барабара беребере ");
            }
            if (richTextBox1.Text.Contains("Б"))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("Б", " барабара беребере ");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DoRule1();
            DoRule2();
            DoRule3();
            DoRule4();
            DoRule5();
            DuAbsurdRule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Любовь как дым - сегодня есть, а завтра мы не курим...";
        }
        private void DoRule5()
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
                    if (richTextBox1.Text.Contains(name.ToLower()))
                    {
                        richTextBox1.Text = richTextBox1.Text.Replace(name.ToLower(), name);
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
