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
    public partial class ServiceForm : Form
    {
        int serviceid;
        int userid;
        public ServiceForm(int servid, long usrid)
        {
            serviceid = servid;
            userid = (int)usrid;
            InitializeComponent();
            LoadData();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void offButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void goServiceButton_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DBase data = new DBase();
            string sql = $"delete from service where id = '{serviceid}'";
            MySqlCommand command = new MySqlCommand(sql, data.GetConnection());
            data.OpenConnection();
            command.ExecuteNonQuery();
            data.CloseConnection();

            MessageBox.Show("Услуга удалена");
            this.Close();
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            if(userid == -1)
            {
                SignForm f = new SignForm();
                f.ShowDialog();
                return;
            }
            DBase data = new DBase();
            data.OpenConnection();
            string sql = $"select service from users where id = '{userid}'";
            MySqlCommand command = new MySqlCommand(sql, data.GetConnection());
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string[] services = reader[0].ToString().Split('!');
            reader.Close();

            for(int i = 0; i < services.Length; i++)
            {
                if (services[i] == serviceid.ToString())
                {
                    MessageBox.Show("Вы уже записаны на эту услугу");
                    return;
                }
            }
            string newinfo = serviceid.ToString() + "!";
            foreach (var i in services)
                if(i!="")
                    newinfo += i + "!";
            data.CloseConnection();
            data.OpenConnection();
            sql = $"update users set service = '{newinfo}' where id = '{userid}'";
            MySqlCommand upcommand = new MySqlCommand(sql, data.GetConnection());
            upcommand.ExecuteNonQuery();
            data.CloseConnection();
            MessageBox.Show("Вы успешно записались на услугу");
        }

        private void InfoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
