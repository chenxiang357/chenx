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
    public partial class Log_Login_Form : BasicSettingsForm
    {

        private Log_Login_BLL log_Login_BLL;

        public Log_Login_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            log_Login_Controls1.InquireClick += InquireButton_Click;
            log_Login_Controls1.ResetClick += ResetButton_Click;
            BindingGridView();
            base.OnLoad(e);
        }

        /// <summary>
        /// 绑定数据列表
        /// </summary>
        void BindingGridView()
        {
            if (log_Login_BLL == null)
            {
                log_Login_BLL = new Log_Login_BLL();
            }

            log_Login_Controls1.Data = log_Login_BLL.GetData(log_Login_Controls1.OperationDate, log_Login_Controls1.LoginName);
        }


        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InquireButton_Click(object sender, EventArgs e)
        {
            BindingGridView();
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            log_Login_Controls1.OperationDate = DateTime.Now;
            log_Login_Controls1.LoginName = "";
            BindingGridView();
        }


    }
}
