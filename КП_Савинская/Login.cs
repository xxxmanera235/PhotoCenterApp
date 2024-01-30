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

namespace КП_Савинская
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (loginBox.Text == "")
            {
                MessageBox.Show("Введите логин"); 
            }
            if (passBox.Text == "")
            {
                MessageBox.Show("Введите пароль");
            }
            if ((loginBox.Text != "") && (passBox.Text != ""))
            {
                if (CheckUser() == false)
                {
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Пользователь не найден!"); }
            }
   

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Зарегистрироваться(object sender, EventArgs e)
        {

            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
        Point lastPoint = new Point();
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        Boolean CheckUser()
        {
            string connectstring = "Data Source=.;Initial Catalog=PhotoCenter;Integrated Security=true";
            SqlConnection MyConnection = new SqlConnection(connectstring);
            string query1 = "SELECT * FROM Registration WHERE login = @ul AND password = @up";
            SqlParameter loginParam = new SqlParameter("@ul", loginBox.Text);
            SqlParameter PassParam = new SqlParameter("@up", passBox.Text);
            SqlCommand sqlCommand = new SqlCommand(query1, MyConnection);
            sqlCommand.Parameters.Add(loginParam);
            sqlCommand.Parameters.Add(PassParam);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable table = new DataTable();
            adapter.SelectCommand = sqlCommand;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else return true;
        }
    }
}
