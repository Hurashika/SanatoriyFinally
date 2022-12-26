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
    public partial class ProfileForm : Form
    {
        long idUser;
        public ProfileForm(long id)
        {
            idUser = id;
            InitializeComponent();
            LoadInfo();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void goServiceButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void userService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userViewButton_Click(object sender, EventArgs e)
        {
            UsersListForm f = new UsersListForm();
            f.ShowDialog();
        }
    }
}
