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
        public ServiceForm(int servid)
        {
            serviceid = servid;
            InitializeComponent();
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
            this.Close();
        }
    }
}
