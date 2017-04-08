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
    public partial class Account_Update_Form : BasicSettingsForm
    {
        /// <summary>
        /// 账号管理逻辑代码
        /// </summary>
        public Account_BLL AccountBLL { get; set; }

        /// <summary>
        /// 账号分类
        /// </summary>
        public IEnumerable<IGrouping<string, string>> AccountType_Data
        {
            set
            {
                account_Control1.AccountType_Data = value;
            }
        }

        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }

        public Account_Update_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            account_Control1.PasswordChar = '\u0000';
            var entity = AccountBLL.Get_Entity(Id);
            AccountBLL.OriginalInfo(entity);
            account_Control1.AccountNumber_Entity = entity;
            base.OnLoad(e);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var entity= account_Control1.AccountNumber_Entity;
            if (AccountBLL.RepeatVerify_Update(entity))
            {
                if (AccountBLL.Update(entity) > -1)
                {
                    DialogResult = MessageBox.Show("更新账号成功!", "账号更新提示", MessageBoxButtons.OK); //DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(AccountBLL.Messages, "账号更新提示");
            }
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
