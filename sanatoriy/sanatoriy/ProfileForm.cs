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
    }
}
