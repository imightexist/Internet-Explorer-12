using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1(String url)
        {
            InitializeComponent();
            //Uri url2 = new Uri(url);
            textBox1.Text = url;
            webBrowser1.Navigate(url, null, null, "User-Agent:Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.99 Safari/537.36");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //''if (textBox1.Text =
            webBrowser1.Navigate(textBox1.Text, null, null, "User-Agent:Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.99 Safari/537.36");
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webBrowser1.Navigate(textBox1.Text, null, null, "User-Agent:Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.99 Safari/537.36");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //tabControl1.TabPages.Add(tabPage1);
            TabPage tabPage2 = new TabPage();
            tabPage2.Controls.Add(webBrowser1);
            tabPage2.Text = "Tab";
            tabControl1.TabPages.Add(tabPage2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new dotdotdot().Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tabControl1.Size = new Size(this.Width - 14, this.Height);//MessageBox.Show("h", "h");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("google.com", null, null, "User-Agent:Mozilla/5.0 (Windows NT 6.3; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/97.0.4692.99 Safari/537.36");
        }
    }
}
