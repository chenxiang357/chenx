using chenx.BLL;
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
    public partial class System_User_Update_Form : BasicSettingsForm
    {
        /// <summary>
        /// 用户名逻辑代码
        /// </summary>
        public System_User_BLL System_User { get; set; }

        /// <summary>
        /// 用户名主键
        /// </summary>
        public string UserId
        {
            set
            {
                if (System_User!=null)
                {
                    var entity = System_User.Get_Entity(value);
                    System_User.OriginalInfo(entity);
                    system_User_Controls1.User_Entity = entity;
                }
            }
        }

        public System_User_Update_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            system_User_Controls1.Is_Enabled_LoginName = false;
            base.OnLoad(e);
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (System_User != null)
            {
                var entity = system_User_Controls1.User_Entity;
                System_User.ConfirmPwd = system_User_Controls1.ConfirmPwd;
                if (System_User.RepeatVerify_Update(entity))
                {
                    if (System_User.Update(entity) > -1)
                    {
                       this.DialogResult = MessageBox.Show("更新用户成功!", "用户更新提示", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(System_User.Messages, "用户更新提示");
                }
            }
        }
    }
}
