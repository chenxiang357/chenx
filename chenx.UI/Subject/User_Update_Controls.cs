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
    public partial class User_Update_Controls : UserControl
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string LoginName
        {
            set { LoginNameLabel.Text = value; }
        }

        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            get { return PasswordTextBox.Text; }
        }

        /// <summary>
        /// 确认密码
        /// </summary>
        public string ConfirmPaw
        {
            get { return ConfirmPawTextBox.Text; }
        }

        public User_Update_Controls()
        {
            InitializeComponent();
        }
    }
}
