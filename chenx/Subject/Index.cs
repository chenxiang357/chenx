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
        /// <summary>
        /// 判断系统是退出还是关闭（默认为退出系统）
        /// </summary>
        private bool IsButtonExit;

        /// <summary>
        /// 窗体接口
        /// </summary>
        public IForm iForm { get; set; }


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
            IsButtonExit = true;

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

        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsButtonExit)
            {
                if (MessageBox.Show("你确定要关闭系统吗?", "退出提示", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;        //取消事件的值
                    return;
                }

                iForm.CloseForm();
            }
        }

        /// <summary>
        /// 退出系统（返回登入界面）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出系统吗?", "退出提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.OK;

                //退出系统 IsButtonExit 就变量
                IsButtonExit = false;
                this.Dispose();
            }
        }

        private void Update_Info_ToolStripButton_Click(object sender, EventArgs e)
        {
            User_Update_Form user_Update_Form = new User_Update_Form();
            user_Update_Form.ShowDialog();
        }
    }
}
