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
        public MainForm(long id)
        {
            idUser = id;
            InitializeComponent();
            Edit();
            LoadData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            if (e.ClipRectangle.Width == (sender as Panel).Width && e.ClipRectangle.Height == (sender as Panel).Height)
            {
                Pen p = new Pen(Brushes.Red, 10);
                e.Graphics.DrawRectangle(p, e.ClipRectangle);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void offButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void profileButton_Click(object sender, EventArgs e)
        {

        }
    }
}
