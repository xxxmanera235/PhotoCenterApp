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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void reglabel_Click(object sender, EventArgs e)
        {
            if ((loginBox.Text != "") && (passBox.Text != "") && (nameBox.Text != "") && (surnameBox.Text != "") && (fatherBox.Text != ""))
            {
                if (passBox2.Text == passBox.Text)
                {
                    string connectstring = "Data Source=.;Initial Catalog=PhotoCenter;Integrated Security=true";
                    SqlConnection MyConnection = new SqlConnection(connectstring);
                    MyConnection.Open();
                    if (CheckUser() == false)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует!");
                    }
                    else
                    {
                        SqlParameter nameParam = new SqlParameter("@name", nameBox.Text);
                        SqlParameter surnameParam = new SqlParameter("@surname", surnameBox.Text);
                        SqlParameter loginParam = new SqlParameter("@login", loginBox.Text);
                        SqlParameter passParam = new SqlParameter("@pass", passBox.Text);
                        SqlParameter fatherParam = new SqlParameter("@father", fatherBox.Text);
                        string query1 = "INSERT INTO Registration VALUES(@login,@pass,@name,@surname,@father)";
                        SqlCommand sqlCommand = new SqlCommand(query1, MyConnection);
                        sqlCommand.Parameters.Add(nameParam);
                        sqlCommand.Parameters.Add(surnameParam);
                        sqlCommand.Parameters.Add(loginParam);
                        sqlCommand.Parameters.Add(passParam);
                        sqlCommand.Parameters.Add(fatherParam);
                        sqlCommand.ExecuteNonQuery();
                        MyConnection.Close();
                        MessageBox.Show("Вы зарегистрированы!");
                        // MainForm mainForm = new MainForm();
                        // mainForm.Show();
                  
                    }
                }
                else { MessageBox.Show("Неверно повторен пароль!"); }
            }
            else MessageBox.Show("Введите все данные!");
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        Point lastPoint;

        private void Registration_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Registration_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint=new Point(e.X,e.Y);
        }
        Boolean CheckUser()
        {
            string connectstring = "Data Source=.;Initial Catalog=PhotoCenter;Integrated Security=true";
            SqlConnection MyConnection = new SqlConnection(connectstring);
            string query1 = "SELECT * FROM Registration WHERE login = @ul";
            SqlParameter loginParam = new SqlParameter("@ul", loginBox.Text);
            SqlCommand sqlCommand = new SqlCommand(query1, MyConnection);
            sqlCommand.Parameters.Add(loginParam);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable table = new DataTable();
            adapter.SelectCommand=sqlCommand;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else return true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
