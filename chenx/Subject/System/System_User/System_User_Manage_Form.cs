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
    public partial class System_User_Manage_Form : BasicSettingsForm
    {
        private System_User_BLL SystemUserBLL;

        private System_User_Add_Form user_Add;

        public System_User_Manage_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            SystemUserBLL = new System_User_BLL();
            system_User_Manage_Controls1.QueryImages = "/Shared/Images/query.png";
            system_User_Manage_Controls1.ResetImages = "/Shared/Images/reset.png";
            system_User_Manage_Controls1.AddImages = "/Shared/Images/user/user_add.png";
            system_User_Manage_Controls1.UpdateImages = "/Shared/Images/edit.png";
            system_User_Manage_Controls1.DeleteImages = "/Shared/Images/delete.png";
            system_User_Manage_Controls1.System_User_Entity_List = SystemUserBLL.Get_Entity_List();
            system_User_Manage_Controls1.DataGridView_Update_Button = DataGridView_Update;
            system_User_Manage_Controls1.DataGridView_Delete_Button = DataGridView_Delete;
            base.OnLoad(e);
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void System_User_Manage_Add_Click(object sender, EventArgs e)
        {
            if (user_Add == null)
                user_Add = new System_User_Add_Form();

            user_Add.System_User = SystemUserBLL;
            if (user_Add.ShowDialog() == DialogResult.OK)
            {
                system_User_Manage_Controls1.System_User_Entity_List = SystemUserBLL.Get_Entity_List();
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id"></param>
        public void DataGridView_Update(string id)
        {
            System_User_Update_Form System_User_Update = new System_User_Update_Form();
            System_User_Update.System_User = SystemUserBLL;
            System_User_Update.UserId = id;
           
            if (System_User_Update.ShowDialog() == DialogResult.OK)
            {
                system_User_Manage_Controls1.System_User_Entity_List = SystemUserBLL.Get_Entity_List();
                System_User_Update.Dispose();
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        public void DataGridView_Delete(string id)
        {
            if (SystemUserBLL.Delete(Convert.ToInt32(id))>-1)
            {
                system_User_Manage_Controls1.System_User_Entity_List = SystemUserBLL.Get_Entity_List();
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void InquireClick(object sender, EventArgs e)
        {
            var entityList = SystemUserBLL.Get_Entity_List();
            string loginName = system_User_Manage_Controls1.LoginName_Inquire;
            if (loginName != null && loginName.Length>0)
            {
                entityList = entityList.Where(w => w.LoginName.Contains(loginName)).ToList();
            }
            string userName = system_User_Manage_Controls1.UserName_Inquire;
            if (userName!=null && userName.Length>0)
            {
                entityList = entityList.Where(w => w.UserName.Contains(userName)).ToList();
            }
            system_User_Manage_Controls1.System_User_Entity_List = entityList;
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ResetClick(object sender,EventArgs e)
        {
            system_User_Manage_Controls1.LoginName_Inquire = "";
            system_User_Manage_Controls1.UserName_Inquire = "";
            system_User_Manage_Controls1.System_User_Entity_List = SystemUserBLL.Get_Entity_List();
        }
    }
}
