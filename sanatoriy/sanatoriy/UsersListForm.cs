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
    public partial class UsersListForm : Form
    {
        public UsersListForm()
        {
            InitializeComponent();
            LoadData();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            string login = this.dataUser.SelectedCells[0].Value.ToString();
            string newrole = this.roleBox.Text;
            DBase data = new DBase();
            string sql = $"update users set role = '{newrole}' where login = '{login}'";
            MySqlCommand command = new MySqlCommand(sql, data.GetConnection());
            data.OpenConnection();
            command.ExecuteNonQuery();
            data.CloseConnection();
            LoadData();
        }

        private void UsersListForm_Load(object sender, EventArgs e)
        {

        }
    }
}
