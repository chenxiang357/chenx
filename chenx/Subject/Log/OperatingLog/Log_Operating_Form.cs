using chenx.BLL.Subject.Log;
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
    public partial class Log_Operating_Form : BasicSettingsForm
    {

        private Log_Operating_BLL log_Operating_BLL;

        public Log_Operating_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            log_Operating_Controls1.InquireClick += InquireButton_Click;
            log_Operating_Controls1.ResetClick += ResetButton_Click;
            log_Operating_Controls1.DataGridView_Show += DataGridView_Show;
            DoLoad();
            base.OnLoad(e);
        }

        void DoLoad()
        {
            if (log_Operating_BLL == null)
            {
                log_Operating_BLL = new Log_Operating_BLL();
            }

            log_Operating_Controls1.Data= log_Operating_BLL.GetData(log_Operating_Controls1.OperationDate, log_Operating_Controls1.LoginName);
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
            log_Operating_Controls1.OperationDate = DateTime.Now;
            log_Operating_Controls1.LoginName = "";
            DoLoad();
        }


        private void DataGridView_Show(string id)
        {
            Log_Operating_Info_Form log_Operating_Info_Form = new Log_Operating_Info_Form();
            log_Operating_Info_Form.log_Operating_BLL = log_Operating_BLL;
            log_Operating_Info_Form.Id = id;
            log_Operating_Info_Form.ShowDialog();
        }
    }
}
