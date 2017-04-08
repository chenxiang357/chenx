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
    public partial class Log_Interview_Form : Form
    {

        private Log_Interview_BLL log_Interview_BLL;

        public Log_Interview_Form()
        {
            InitializeComponent();
        }

        private void Log_Interview_Form_Load(object sender, EventArgs e)
        {
            log_Interview_Controls1.InquireClick += InquireButton_Click;
            log_Interview_Controls1.ResetClick += ResetButton_Click;
            DoLoad();
        }

        /// <summary>
        /// 
        /// </summary>
        void DoLoad()
        {
            if (log_Interview_BLL==null)
            {
                log_Interview_BLL = new Log_Interview_BLL();
            }

            log_Interview_Controls1.Data = log_Interview_BLL.GetData(log_Interview_Controls1.OperationDate, log_Interview_Controls1.LoginName).Tables[0];
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InquireButton_Click(object sender, EventArgs e)
        {
            DoLoad();
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            log_Interview_Controls1.OperationDate = DateTime.Now;
            log_Interview_Controls1.LoginName = "";
            DoLoad();
        }

    }
}
