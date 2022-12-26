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
    public partial class AddServiceForm : Form
    {
        public AddServiceForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text;
            string doctor = doctorBox.Text;
            string coast = coastBox.Text;
            string cabinet = cabinetBox.Text;
            string info = descriptionRichBox.Text;
            DBase data = new DBase();
            string sql = $"insert into service(name_of_service, doctor, coast, cabinet, info) values('{name}', '{doctor}', '{coast}', '{cabinet}', '{info}')";
            MySqlCommand insertcommand = new MySqlCommand(sql, data.GetConnection());
            data.OpenConnection();
            if(insertcommand.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Услуга успешно добавлена");
                this.Hide();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
