using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx
{
    public partial class Role_Manage_Form : Form
    {
        public Role_Manage_Form()
        {
            InitializeComponent();
        }

        private void Role_Manage_Form_Load(object sender, EventArgs e)
        {

        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            Role_Add_Form add = new Role_Add_Form();
            add.ShowDialog();
        }
    }
}
