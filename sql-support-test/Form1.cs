using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sql_support_test
{
    public partial class Form1 : Form
    {
        static int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("button1_Click");
            counter++;
            String html = "<html><body>Hello, World! Counter == " + counter 
                + "<a href=\"qweqweqwe\">sss</a>" 
                + "</body></html>";
            DisplayHtml(html);
        }
        
        private void DisplayHtml(string html)
        {
            //Console.WriteLine("DisplayHtml " + html);
            webBrowser1.Navigate("about:blank");
            if (webBrowser1.Document != null)
            {
                webBrowser1.Document.Write(string.Empty);
            }
            webBrowser1.DocumentText = html;
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //Console.WriteLine("webBrowser1_Navigating");
            Console.WriteLine("webBrowser1_Navigating" + webBrowser1.Url);
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            Console.WriteLine("webBrowser1_Navigated" + webBrowser1.Url.LocalPath);
            if (webBrowser1.Url == null || "about:blank".Equals(webBrowser1.Url.ToString()))
            {
                return;
            }
            String html = "<html><head><meta charset=\"utf-8\"><title>" + webBrowser1.Url + "</title></head>"
                + "<body><h2>" + webBrowser1.Url.LocalPath + "</h2>"
                + "Hello, World! Counter == " + counter
                + "<p><a href=\"sss111\">sss1</a></p>"
                + "<p><a href=\"sss222\">sss2</a></p>"
                + "<p><a href=\"sss333\">sss3</a></p>"
                + "</body></html>";
            DisplayHtml(html);
            //Console.WriteLine("webBrowser1_Navigated");
        }
    }
}
