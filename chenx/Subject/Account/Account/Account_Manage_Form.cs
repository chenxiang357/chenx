using chenx.BLL;
using chenx.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx
{
    public partial class Account_Manage_Form : BasicSettingsForm
    {
        /// <summary>
        /// 
        /// </summary>
        private Account_BLL AccountBLL;

        public Account_Manage_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            account_Control1.Is_ReadOnly_Control = true;        //文本框只读
            account_Menu_Control1.AccountNumber_Entity = Read_AccountNumber_Entity; //点击显示详细信息委托
            account_Menu_Control1.UpdateClick = UpdateClick;    //更新委托
            account_Menu_Control1.DeleteClick = DeleteClick;    //删除委托

            AccountBLL = new Account_BLL();
            BingdingData();
            base.OnLoad(e);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Account_Add_Click(object sender, EventArgs e)
        {
            Account_Add_Form add = new Account_Add_Form();
            add.AccountBLL = AccountBLL;
            add.AccountType_Data = AccountBLL.QueryData().Select(s => s.AccountType).GroupBy(g => g);
            if (add.ShowDialog() == DialogResult.OK)
            {
                BingdingData();
            }    
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id">主键</param>
        private void UpdateClick(string id)
        {
            Account_Update_Form update = new Account_Update_Form();
            update.AccountBLL = AccountBLL;
            update.AccountType_Data= AccountBLL.QueryData().Select(s => s.AccountType).GroupBy(g => g);
            update.Id = id;
            if (update.ShowDialog() == DialogResult.OK)
            {
                BingdingData();
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        private void DeleteClick(string id)
        {
            if (MessageBox.Show("请确定要删除此账号吗?", "删除提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                AccountBLL.Delete(id);
                BingdingData();
            }
        }

        /// <summary>
        /// 委托_点击节点查看实体信息
        /// </summary>
        /// <param name="id">主键</param>
        public void Read_AccountNumber_Entity(string id)
        {
            account_Control1.AccountNumber_Entity = AccountBLL.Get_Entity(id);
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        private void BingdingData()
        {
            //读取所有账号信息
            account_Menu_Control1.TreeViewData = AccountBLL.QueryData();    //AccountNumber_Entity_List;
        }

        /// <summary>
        /// 显示密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Show_Paw_Button_Click(object sender, EventArgs e)
        {
            if (Show_Paw_Button.Text == "显示密码")
            {
                account_Control1.PasswordChar = '\u0000';
                Show_Paw_Button.Text = "隐藏密码";
            }
            else
            {
                account_Control1.PasswordChar = '\u002a';
                Show_Paw_Button.Text = "显示密码";
            }
        }
    }
}
