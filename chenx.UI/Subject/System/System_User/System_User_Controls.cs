using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chenx.Model;

namespace chenx.UI
{
    public partial class System_User_Controls : UserControl
    {
        /// <summary>
        /// 确认密码
        /// </summary>
        public string ConfirmPwd { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        private string Pwd { get; set; }

        /// <summary>
        /// 用户名是否可以对用户交互作出响应。
        /// </summary>
        public bool IsEnabledLoginName
        {
            set
            {
                LoginName_TextBox.Enabled = value;
            }
        }

        private System_User _User_Entity;

        /// <summary>
        /// 用户实体
        /// </summary>
        public System_User User_Entity
        {
            get
            {
                if (_User_Entity == null)
                {
                    _User_Entity = new System_User();
                }
                
                _User_Entity.LoginName = LoginName_TextBox.Text;
                _User_Entity.UserName = UserName_TextBox.Text;
                _User_Entity.Remarks = Remarks_TextBox.Text;

                if (Pwd_TextBox.Text.Length > 0)
                {
                    _User_Entity.Pwd = Pwd_TextBox.Text;
                }
                else
                {
                    _User_Entity.Pwd = Pwd;
                }

                ConfirmPwd = ConfirmPwd_TextBox.Text;
                return _User_Entity;
            }
            set
            {
                _User_Entity = value;
                if (_User_Entity != null)
                {
                    LoginName_TextBox.Text = _User_Entity.LoginName;
                    UserName_TextBox.Text = _User_Entity.UserName;
                    Remarks_TextBox.Text = _User_Entity.Remarks;
                    Pwd = _User_Entity.Pwd;
                }
                else
                {
                    LoginName_TextBox.Text = "";
                    UserName_TextBox.Text = "";
                    Remarks_TextBox.Text = "";
                    Pwd_TextBox.Text = "";
                    ConfirmPwd_TextBox.Text = "";
                }
            }
        }

        /// <summary>
        /// 是否可用
        /// </summary>
        public bool Is_Enabled_LoginName
        {
            set { LoginName_TextBox.Enabled = value; }
        }

        public System_User_Controls()
        {
            InitializeComponent();
        }

        private void UserControls_Load(object sender, EventArgs e)
        {
            
        }
    }
}
