using chenx.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chenx.Config;

namespace chenx
{
    public partial class User_Update_Form : BasicSettingsForm
    {
        /// <summary>
        /// 用户名逻辑代码
        /// </summary>
        public User_Update_BLL user_Update { get; set; }

        public User_Update_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            user_Update_Controls1.LoginName = ReadConfigFile.UserLongInfo.LoginName;
            base.OnLoad(e);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (user_Update == null)
            {
                user_Update = new User_Update_BLL();
            }

            if (user_Update.RepeatVerify_Data(user_Update_Controls1.Password, user_Update_Controls1.ConfirmPaw))
            {
                if (user_Update.Update_Pwd(user_Update_Controls1.Password,ReadConfigFile.UserLongInfo.Id.ToString())>-1)
                {
                    this.DialogResult = MessageBox.Show("更新密码成功!", "修改密码", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(user_Update.Messages, "修改密码");
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
