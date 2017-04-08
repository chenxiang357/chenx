using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx.UI
{
    public partial class Role_Manage_Controls : UserControl
    {
        /// <summary>
        /// 添加按钮单机事件
        /// </summary>
        public event EventHandler AddClick;

        public Role_Manage_Controls()
        {
            InitializeComponent();
        }

        private void Role_Manage_Controls_Load(object sender, EventArgs e)
        {

        }

        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            AddClick(sender, e);
        }


    }
}
