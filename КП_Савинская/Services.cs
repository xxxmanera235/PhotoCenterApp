using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace КП_Савинская
{
    public partial class Services : Form
    {
        public Services()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectstring = "Data Source=.;Initial Catalog=PhotoCenter;Integrated Security=true";
            SqlConnection MyConnection = new SqlConnection(connectstring);
            MyConnection.Open();
            SqlParameter ServiceParam = new SqlParameter("@Service", comboBox1.Text);
            SqlParameter dateParam = new SqlParameter("@date", comboBox2.Text);
            SqlParameter timeParam = new SqlParameter("@time", comboBox3.Text);

            string query1 = "INSERT INTO Uslugi VALUES(@Service,@date,@time)";
            SqlCommand sqlCommand = new SqlCommand(query1, MyConnection);
            sqlCommand.Parameters.Add(ServiceParam);
            sqlCommand.Parameters.Add(dateParam);
            sqlCommand.Parameters.Add(timeParam);
            sqlCommand.ExecuteNonQuery();
            MyConnection.Close();
            MessageBox.Show("Вы записаны!");
        }
    }
}
