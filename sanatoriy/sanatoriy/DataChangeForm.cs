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
    public partial class ChangeForm : Form
    {
        long userid;
        public ChangeForm(long id)
        {
            userid = id;
            InitializeComponent();
        }

        private void autorisationButton_Click(object sender, EventArgs e)
        {
            string newlogin, newpass, newnumber, newname, newpolice;
            DBase data = new DBase();
            string sql = $"select login, pass, info from users where id = '{userid}'";
            MySqlCommand command = new MySqlCommand(sql, data.GetConnection());
            data.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            reader.Read();
            string oldlogin = reader[0].ToString();
            string oldpass = reader[1].ToString();
            string[] oldinfo = reader[2].ToString().Split('!');
            reader.Close();
            data.CloseConnection();

            if(oldpass != passBox.Text)
            {
                MessageBox.Show("Неверный пароль");
                return;
            }

            newlogin = this.newLoginBox.Text;
            newpass = this.newPassBox.Text;
            newnumber = this.newPhoneBox.Text;
            newpolice = this.newPoliceBox.Text;
            newname = this.newFullnameBox.Text;

            if(newlogin != "")
            {
                sql = $"select id from users where login = '{newlogin}'";
                command.CommandText = sql;
                data.OpenConnection();
                reader = command.ExecuteReader();
                reader.Read();
                if(reader != null)
                {
                    MessageBox.Show("Такой login уже существует");
                    return;
                }
                reader.Close();
                data.CloseConnection();

                sql = $"update users set login = '{newlogin}' where id = '{userid}'";
                command.CommandText = sql;
                data.OpenConnection();
                command.ExecuteNonQuery();
                data.CloseConnection();
            }

            if(newpass != "")
            {
                sql = $"update users set pass = '{newpass}' where id = '{userid}'";
                command.CommandText = sql;
                data.OpenConnection();
                command.ExecuteNonQuery();
                data.CloseConnection();
            }

            if (newname != "")
                oldinfo[0] = newname;
            if (newnumber != "")
                oldinfo[1] = newnumber;
            if (newpolice != "")
                oldinfo[2] = newpolice;
            string newinfo = oldinfo[0] + "!" + oldinfo[1] + "!" + oldinfo[2];
            sql = $"update users set info = '{newinfo}' where id = '{userid}'";
            command.CommandText = sql;
            data.OpenConnection();
            command.ExecuteNonQuery();
            data.CloseConnection();
            MessageBox.Show("Данные успешно изменены");
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
