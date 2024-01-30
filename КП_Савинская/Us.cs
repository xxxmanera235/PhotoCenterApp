using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КП_Савинская
{
    public partial class Us : Form
    {
        public Us()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu(); 
            mainMenu.Show();
            this.Hide();
        }
    }
}
