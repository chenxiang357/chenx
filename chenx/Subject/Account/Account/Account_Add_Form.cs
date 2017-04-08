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
    public partial class Account_Add_Form : BasicSettingsForm
    {
        ///// <summary>
        ///// 接口
        ///// </summary>
        //public IAccountNumber AccountNumber { get; set; }

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

        public Account_Add_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            account_Control1.PasswordChar = '\u0000';
            base.OnLoad(e);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveButton_Click(object sender, EventArgs e)
        {
            var entity = account_Control1.AccountNumber_Entity;
            if (AccountBLL.RepeatVerify_Add(entity))
            {
                if (AccountBLL.Add(entity)>-1)
                {
                    DialogResult = MessageBox.Show("添加账号成功!", "账号添加提示", MessageBoxButtons.OK); //DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(AccountBLL.Messages, "账号添加提示");
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
