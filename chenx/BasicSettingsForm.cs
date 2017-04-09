using chenx.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using chenx.Config;

namespace chenx
{
    /// <summary>
    /// 基本设置窗体
    /// </summary>
    public class BasicSettingsForm :Form
    {
       // public static readonly ILog_Interview Instance = new Log_Interview_Add_DAL();

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
            Log_Interview_Singleton.Instance.Login_Name = ReadConfigFile.UserLongInfo.LoginName;
            Log_Interview_Singleton.Instance.ModuleName = Text;
            Log_Interview_Singleton.Instance.ResultsDescribed = "访问页面:" + Name;
            Log_Interview_Singleton.Instance.Generatelog();
        }
    }
}
