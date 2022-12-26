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
    public partial class MainForm : Form
    {
        long idUser;
        string roleUser;
        int total = 0;
        public MainForm(long id)
        {
            idUser = id;
            InitializeComponent();
            Edit();
            LoadGrid();
            LoadData();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (e.ClipRectangle.Width == (sender as Panel).Width && e.ClipRectangle.Height == (sender as Panel).Height)
            {
                Pen p = new Pen(Brushes.Red, 10);
                e.Graphics.DrawRectangle(p, e.ClipRectangle);
            }
        }

        private void offButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addServiceButton_Click(object sender, EventArgs e)
        {
            AddServiceForm f = new AddServiceForm();
            f.ShowDialog();
            this.LoadData();
        }

        private void dataService_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = e.RowIndex;
            ServiceForm f = new ServiceForm(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            ProfileForm f = new ProfileForm(idUser);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
