using chenx.BLL;
using chenx.Model;
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
    public partial class System_User_Add_Form : BasicSettingsForm
    {
        /// <summary>
        /// 用户名逻辑代码
        /// </summary>
        public System_User_BLL System_User { get; set; }

        public System_User_Add_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            system_User_Controls2.User_Entity = null;
            system_User_Controls2.Is_Enabled_LoginName = true;
            base.OnLoad(e);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (System_User != null)
            {
                var entity = system_User_Controls2.User_Entity;
                System_User.ConfirmPwd = system_User_Controls2.ConfirmPwd;
                if (System_User.RepeatVerify_Add(entity))
                {
                    if (System_User.Add(entity) > -1)
                    {
                        this.DialogResult = MessageBox.Show("添加用户成功!", "用户添加提示", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(System_User.Messages, "用户添加提示");
                }
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
