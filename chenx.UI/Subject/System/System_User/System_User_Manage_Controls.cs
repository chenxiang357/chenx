using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chenx.Model;
using System.IO;

namespace chenx.UI
{
    public partial class System_User_Manage_Controls : Admin_Manage_UserControl
    {
        /// <summary>
        /// 查询按钮
        /// </summary>
        public event EventHandler InquireClick;

        /// <summary>
        /// 重置按钮
        /// </summary>
        public event EventHandler ResetClick;

        /// <summary>
        /// 添加按钮单机事件
        /// </summary>
        public event EventHandler AddClick;

        /// <summary>
        /// 表格修改按钮
        /// </summary>
        public Button_Click_Id DataGridView_Update_Button;

        /// <summary>
        /// 表格删除按钮
        /// </summary>
        public Button_Click_Id DataGridView_Delete_Button;

        /// <summary>
        /// 查询图片地址
        /// </summary>
        public string QueryImages
        {
            set
            {
                QueryToolStripButton.Image = ButtonImage(value);
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        public string ResetImages
        {
            set
            {
                ResetToolStripButton.Image = ButtonImage(value);
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        public string AddImages
        {
            set
            {
                AddToolStripButton.Image= ButtonImage(value);
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        public string UpdateImages
        {
            set
            {
                UpdateUser.Image = ButtonImage(value);
            }
        }
        
        /// <summary>
        /// 删除
        /// </summary>
        public string DeleteImages
        {
            set
            {
                DeleteUser.Image = ButtonImage(value);
            }
        }    

        public IList<System_User> System_User_Entity_List
        {
            set
            {
                UserDataGridView.DataSource = value.Select(s => new { s.Id,s.IsAdmin, s.LoginName, s.UserName, s.Remarks }).OrderBy(o=>o.Id).ToList();
            }
        }

        /// <summary>
        /// 用户名_查询
        /// </summary>
        public string LoginName_Inquire
        {
            get
            {
                return LoginName_Inquire_ToolStripTextBox.Text;
            }

            set
            {
                LoginName_Inquire_ToolStripTextBox.Text = value;
            }
        }

        /// <summary>
        /// 姓名_查询
        /// </summary>
        public string UserName_Inquire
        {
            get
            {
                return UserName_Inquire_ToolStripTextBox.Text;
            }

            set
            {
                UserName_Inquire_ToolStripTextBox.Text = value;
            }
        }

        public System_User_Manage_Controls()
        {
            InitializeComponent();
        }

        private void System_User_Manage_Controls_Load(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            if (AddClick!=null)
            {
                AddClick(sender, e);
            }
        }

        /// <summary>
        /// 操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UserDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                switch (UserDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "UpdateUser":
                        if (DataGridView_Update_Button != null)
                        {
                            DataGridView_Update_Button(UserDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                        }
                        break;
                    case "DeleteUser":
                        if (DataGridView_Delete_Button!=null)
                        {
                            if (UserDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()!="1")
                            {
                                DataGridView_Delete_Button(UserDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                            }
                            else
                            {
                                MessageBox.Show("管理员账号不能删除","用户删除提示");
                            }
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryToolStripButton_Click(object sender, EventArgs e)
        {
            if (InquireClick!=null)
            {
                InquireClick(sender, e);
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetToolStripButton_Click(object sender, EventArgs e)
        {
            if (ResetClick!=null)
            {
                ResetClick(sender,e);
            }
        }
    }
}
