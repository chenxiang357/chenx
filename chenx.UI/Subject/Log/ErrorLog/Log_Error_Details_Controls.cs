using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx.UI
{
    public partial class Log_Error_Details_Controls : UserControl
    {
        /// <summary>
        /// 错误日志标题
        /// </summary>
        public string Error_Log_Title
        {
            set { label2.Text = value; }
        }


        /// <summary>
        /// 错误日志内容
        /// </summary>
        public string Error_Log_Content
        {
            set { ErrorLogContentTextBox.Text = value; }
        }

        public Log_Error_Details_Controls()
        {
            InitializeComponent();
        }
    }
}
