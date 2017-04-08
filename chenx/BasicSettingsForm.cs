using chenx.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace chenx
{
    /// <summary>
    /// 基本设置窗体
    /// </summary>
    public class BasicSettingsForm :Form
    {

        protected override void OnLoad(EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(AddInstance);
            base.OnLoad(e);
        }

        /// <summary>
        /// 访问日志
        /// </summary>
        /// <param name="obj"></param>
        private void AddInstance(object obj)
        {
            Log_Interview_Singleton.Instance.Login_Name = "admin";
            Log_Interview_Singleton.Instance.ModuleName = Text;
            Log_Interview_Singleton.Instance.ResultsDescribed = "访问页面:" + Name;
            Log_Interview_Singleton.Instance.Generatelog();
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // BasicSettingsForm
        //    // 
        //    this.ClientSize = new System.Drawing.Size(284, 261);
        //    this.Name = "BasicSettingsForm";
        //    this.ResumeLayout(false);

        //}
    }
}
