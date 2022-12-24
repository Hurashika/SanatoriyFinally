namespace sanatoriy
{
    public partial class LoginForm : Form
    {
        string userLogin;
        string userpassword;
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
            userLogin = loginBox.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}