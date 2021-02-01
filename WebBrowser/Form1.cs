using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void IdiButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(AdresaText.Text);
        }

        private void NaprijedButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            webBrowser1.GoForward();
        }

        private void NatragButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void GmailButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("gmail.com");
        }

        private void WebmailButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("ocjene.skole.hr");
        }

        private void IspisButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }
    }
}
