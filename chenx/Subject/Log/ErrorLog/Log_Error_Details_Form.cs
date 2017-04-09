using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx
{
    public partial class Log_Error_Details_Form : BasicSettingsForm
    {
        /// <summary>
        /// 路径地址
        /// </summary>
        public string PathUrl { get; set; }

        public Log_Error_Details_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            if (PathUrl != null && PathUrl.Length > 0)
            {
                log_Error_Details_Controls1.Error_Log_Title = Path.GetFileNameWithoutExtension(PathUrl);
                if (File.Exists(PathUrl))
                {
                    FileStream fileStream = File.OpenRead(PathUrl);
                    byte[] b = new byte[fileStream.Length];
                    fileStream.Read(b, 0, b.Length);
                    log_Error_Details_Controls1.Error_Log_Content = Encoding.UTF8.GetString(b);
                }
            }
            base.OnLoad(e);
        }

    }
}
