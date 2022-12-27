using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sanatoriy
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fullnameLabel_Click(object sender, EventArgs e)
        {

        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fullnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginBox.Text;
            string passUser = passBox.Text;
            string infoUser = fullnameBox.Text + "!" + phoneBox.Text + "!" + policeBox.Text;
            string roleUser = "user";
            DBase data = new DBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string querystring = $"select id, login, pass, role from users where login = '{loginUser}'";
            MySqlCommand command = new MySqlCommand(querystring, data.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Этот login уже используется");
                return;
            }
            if (passBox.Text != tryPassBox.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }
            querystring = $"insert into users(login, pass, role, info, service) values('{loginUser}', '{passUser}', '{roleUser}', '{infoUser}', '{""}')";
            MySqlCommand insertcommand = new MySqlCommand(querystring, data.GetConnection());
            data.OpenConnection();
            if (insertcommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан");
                this.Close();
            }
        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
