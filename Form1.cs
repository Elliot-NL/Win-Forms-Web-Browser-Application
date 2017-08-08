using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_WebBrowser_Application
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Browser Porgram Test");
        }

        private void Search_Click(object sender, EventArgs e)
        {
            //Allow case for enter
            navigateToPage();
            
        }

        private void navigateToPage()
        {
            toolStripStatusLabel1.Text = "Naviagation has started";
            webBrowser1.Navigate(textBox1.Text);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //KeyPress Event for Enter
            if(e.KeyChar == (char)ConsoleKey.Enter)
            {
                navigateToPage();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            Search.Enabled = true;
            textBox1.Enabled = true;
            toolStripStatusLabel1.Text = "Naviagation is complete";

        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            //Show progress in progressbar
            if(e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                toolStripProgressBar1.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);

            }
        }
    }
}


