using chenx.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx
{
    public partial class Log_Error_Manage_Form : BasicSettingsForm
    {
        private Log_Error_BLL log_Error_BLL;

        /// <summary>
        /// 文件夹地址
        /// </summary>
        private IList<string> pathUrlList;

        /// <summary>
        /// 错误日志文件地址
        /// </summary>
        private string ErrorLog_FolderPathUrl;

        public Log_Error_Manage_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            log_Error_BLL = new Log_Error_BLL();
            ErrorLog_FolderPathUrl = Directory.GetCurrentDirectory() + "/" + ConfigurationManager.AppSettings["ErrorLog_FolderPathUrl"];
            pathUrlList = new List<string>();
            log_Error_Manage_Controls1.Refresh_Button_Click += RefreshToolStripButton_Click;
            log_Error_Manage_Controls1.PreviousPage_Button_Click += PreviousPageToolStripButton_Click;
            log_Error_Manage_Controls1.Home_Button_Click += HomeToolStripButton_Click;
            log_Error_Manage_Controls1.DataGrid_Double = DataGrid_Double;
            log_Error_Manage_Controls1.TreeNode_Click = TreeNode_Click;
            Binding();
            base.OnLoad(e);
        }

        void Binding()
        {
            log_Error_Manage_Controls1.PathUrl = string.Join("/", pathUrlList);
            log_Error_Manage_Controls1.ButtonEnabled(pathUrlList.Count > 0);
            log_Error_Manage_Controls1.NodeData = log_Error_BLL.Get_Folder_List(ErrorLog_FolderPathUrl + log_Error_Manage_Controls1.PathUrl);
            log_Error_Manage_Controls1.ErrorLog_Entity_List= log_Error_BLL.GetEntityList(ErrorLog_FolderPathUrl + log_Error_Manage_Controls1.PathUrl);
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            Binding();
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousPageToolStripButton_Click(object sender, EventArgs e)
        {
            pathUrlList.RemoveAt(pathUrlList.Count - 1);
            Binding();
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeToolStripButton_Click(object sender, EventArgs e)
        {
            pathUrlList.Clear();
            Binding();
        }

        /// <summary>
        /// 双击表格
        /// </summary>
        /// <param name="pathUrl"></param>
        public void DataGrid_Double(string pathUrl)
        {
            Log_Error_Details_Form log_Error_Details = new Log_Error_Details_Form();
            log_Error_Details.PathUrl = pathUrl;
            log_Error_Details.ShowDialog();
        }

        public void TreeNode_Click(TreeNode nodes)
        {
            pathUrlList.Add(nodes.Name);
            Binding();
        }
    }
}
