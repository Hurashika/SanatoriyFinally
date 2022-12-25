using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sanatoriy
{
    internal class Services
    {
        public List<string[]> listOfService = new List<string[]>();
        public Services()
        {
            DBase data = new DBase();
            MySqlCommand command = new MySqlCommand($"select name_of_service, doctor, coast, cabinet from service", data.GetConnection());
            data.OpenConnection();
            MySqlDataReader reader = command.ExecuteReader();
            string temp;
            while (reader.Read())
            {
                temp = reader[0].ToString() + "!"
                    + reader[1].ToString() + "!"
                    + reader[2].ToString() + "!"
                    + reader[3].ToString() + "!";
                listOfService.Add(temp.Split('!'));
            }
            reader.Close();
            data.CloseConnection();
        }
    }
}
