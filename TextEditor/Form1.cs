using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = null;
        }
        private void DoRule2()
        {
            
            if (richTextBox1.Text.Contains("..."))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("...", "…");
            }
        }
        private void DoTire()
        {
            if ((richTextBox1.Text.Contains(" —")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace(" —", (char)(160) + "—");
            }
        }
        private void DoMinus_()
        {
            if ((richTextBox1.Text.Contains("-")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("-", (char)(160) + "—");
            }
        }
        private void DoMinus()
        {
            if ((richTextBox1.Text.Contains(" -")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace(" -", (char)(160) + "—");
            }
        }
        private void DoRule3()
        {
            if ((richTextBox1.Text.Contains("—")))
            {
                richTextBox1.Text = richTextBox1.Text.Replace("—", (char)(160) + "—");
            }
            DoTire();
            DoMinus();
            DoMinus_();
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
            DoRule2();
            DoRule3();
            DuAbsurdRule();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Любовь как дым - сегодня есть, а завтра мы не курим...";
        }
    }
}
