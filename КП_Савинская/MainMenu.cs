
using Aspose.Html;
using Microsoft.VisualBasic.ApplicationServices;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Security.Policy;

namespace КП_Савинская
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Services aboutUs = new Services();
            aboutUs.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Us us = new Us();
            us.Show();
            this.Hide();
        }

 
    }

}

