using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
            label1.Text = webBrowser1.StatusText.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
            label1.Text = webBrowser1.StatusText.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
            label1.Text = webBrowser1.StatusText.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://google.com");
            label1.Text = webBrowser1.StatusText.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
            label1.Text = webBrowser1.StatusText.ToString();
        }   

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Navigate("http://google.com");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = webBrowser1.StatusText.ToString();
            label1.Text = webBrowser1.StatusText.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string googleurl = "www.google.com/search?q=";
            webBrowser1.Navigate("www.google.com/search?q=" + textBox2.Text);
            label1.Text = webBrowser1.StatusText.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creddit PythonScratcher (github/pythonscratcher", "pythonscratcher.com", MessageBoxButtons.OK);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
