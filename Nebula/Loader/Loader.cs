using Microsoft.SqlServer.Server;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nebula
{
    public partial class Nebula : Form
    {
        private Form activeForm = null;

        
        
        


        public Nebula()
        {
            InitializeComponent();
        }

        private void btnlimbo_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            timer1.Start();
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
            
        {
            SendKeys.Send(richTextBox1.Text);
            SendKeys.Send("{ENTER}");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = true;
            timer1.Stop();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            label2.Text = "Delay:" + trackBar1.Value;
        }

        private void Nebula_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://growdice.is");

        }
    }
}
