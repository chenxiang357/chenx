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
using chenx.Config;

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

            //菜单栏
            menuControls1.MenuJson = File.ReadAllText(Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["MenuUrlPath"].ToString());
        }

        private void Index_Load(object sender, EventArgs e)
        {
            //首页名称
            Text = ReadConfigFile.Text_Config.SystemName;

            //菜单名称
            menuControls1.MenuName = ReadConfigFile.Text_Config.MenuBarName;

            //当前用户
            UserName_ToolStripStatusLabel.Text= ReadConfigFile.UserLongInfo.LoginName;

            //委托
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
        }

    }
}
