using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            output1.Text = Task1();
            output2.Text = Task2();
            output3.Text = Task3();
        }

        private string Task1()
        {
            string strNews;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://localhost:3000/task1.php?a={input.Text}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            strNews = reader.ReadToEnd(); // считываем текст rss-ленты.
            return strNews;
        }
        
        private string Task2()
        {
            string strNews;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://localhost:3000/task2.php?a={input.Text}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            strNews = reader.ReadToEnd(); // считываем текст rss-ленты.
            return strNews;
        }
        
        private string Task3()
        {
            string strNews;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"http://localhost:3000/task3.php?a={input.Text}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            strNews = reader.ReadToEnd(); // считываем текст rss-ленты.
            return strNews;
        }
    }
}