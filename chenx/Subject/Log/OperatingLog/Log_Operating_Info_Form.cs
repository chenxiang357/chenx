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
    public partial class Log_Operating_Info_Form : BasicSettingsForm
    {

        public Log_Operating_BLL log_Operating_BLL;

        private string _Id;

        /// <summary>
        /// 主键
        /// </summary>
        public string Id
        {
            get
            {
                return _Id;
            }
            set
            {
                DataTable log_Contents_Data;
                DataTable data = log_Operating_BLL.GetData(Convert.ToInt32(value), out log_Contents_Data).Tables[0];
                log_Operating_Info_Controls1.FieldInfo = data;
                log_Operating_Info_Controls1.Log_Contents_Data = log_Contents_Data;
            }
        }

        public Log_Operating_Info_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

    }
}
