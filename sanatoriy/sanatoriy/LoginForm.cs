using MySqlConnector;
using System.Data;

namespace sanatoriy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guestButton_click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm f = new MainForm(-1);
            f.ShowDialog();
            this.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void autorisationButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginBox.Text;
            string passUser = passBox.Text;
            DBase data = new DBase();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string querystring = $"select id, login, pass, role from users where login = '{loginUser}' and pass = '{passUser}'";
            MySqlCommand command = new MySqlCommand(querystring, data.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Добро пожаловать!");
                this.Hide();
                data.OpenConnection();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                long id = Int64.Parse(reader[0].ToString());
                reader.Close();
                data.CloseConnection();
                MainForm f = new MainForm(id);
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Введенные данные некоректны. Попробуйте еще раз.");
                return;
            }
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}