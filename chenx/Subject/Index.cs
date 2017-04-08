using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chenx.UI;
using System.IO;
using System.Configuration;
using System.CodeDom.Compiler;
using System.Reflection;

namespace chenx
{
    public partial class Index : Form
    {

        private Form form;

        public Index()
        {
            #region 系统窗体最大化

            //this.FormBorderStyle = FormBorderStyle.None;
            //this.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            //this.WindowState = FormWindowState.Maximized;

            #endregion

            InitializeComponent();
            //  this.Size = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            menuControls1.MenuJson = File.ReadAllText(Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["MenuUrlPath"].ToString());
        }

        private void Index_Load(object sender, EventArgs e)
        {
            menuControls1.Click_PopUp_Window = Click_PopUp_Window;
            menuControls1.ShowForm(new Main_Form(), this);
        }

        /// <summary>
        /// 跳转首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_ToolStripButton_Click(object sender, EventArgs e)
        {
            menuControls1.ShowForm(new Main_Form(), this);
        }

        /// <summary>
        ///显示窗口
        /// </summary>
        /// <param name="Id">主键</param>
        private void Click_PopUp_Window(string buttonId)
        {
            form = (Form)Assembly.Load("chenx").CreateInstance("chenx." + buttonId);
            if (form != null)
            {
                menuControls1.ShowForm(form, this);
            }
            else
            {
                MessageBox.Show("没有" + buttonId + "窗体","菜单提示");
            }
            //switch (buttonId)
            //{
            //    case "User":
            //        menuControls1.ShowForm<System_User_Manage_Form, Index>(this);
            //        break;
            //    case "Role":
            //        menuControls1.ShowForm<Role_Manage_Form, Index>(this);
            //        break;
            //    case "Parameter":
            //        menuControls1.ShowForm<Parameter_Manage_Form, Index>(this);
            //        break;
            //    case "Expend":
            //        menuControls1.ShowForm<Expend_Manage_Form, Index>(this);
            //        break;
            //    case "ExpendReport":
            //        menuControls1.ShowForm<ExpendReport_Form, Index>(this);
            //        break;
            //    case "Account":
            //        menuControls1.ShowForm<Account_Manage_Form, Index>(this);
            //        break;
            //    case "LoginLog":
            //        //登录日志
            //        menuControls1.ShowForm<Log_Login_Form, Index>(this);
            //        break;
            //    case "InterviewLog":
            //        //访问日志
            //        menuControls1.ShowForm<Log_Interview_Form, Index>(this);
            //        break;
            //    case "OperatingLog":
            //        //操作日志
            //        menuControls1.ShowForm<Log_Operating_Form, Index>(this);
            //        break;
            //    case "ErrorLog":
            //        //错误日志
            //        menuControls1.ShowForm<Error_Log_Manage_Form, Index>(this);
            //        break;
            //    default:
            //        break;
            //}
        }

        private void Index_SizeChanged(object sender, EventArgs e)
        {
            //menuControls1.FormSize();
        }


    }
}
