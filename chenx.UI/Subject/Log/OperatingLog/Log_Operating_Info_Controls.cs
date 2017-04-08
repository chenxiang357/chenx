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
    public partial class Log_Operating_Info_Controls : UserControl
    {

        /// <summary>
        /// 字段信息
        /// </summary>
        public DataTable FieldInfo
        {
            set
            {
                DataTable data = value;
                if (data.Rows.Count>0)
                {
                    Creation_DateLabel.Text = data.Rows[0]["Creation_Date"].ToString();
                    Login_NameLabel.Text = data.Rows[0]["Login_Name"].ToString();
                    ModuleNameLabel.Text = data.Rows[0]["ModuleName"].ToString();
                    OperationTypeLabel.Text = data.Rows[0]["OperationType"].ToString();
                    ResultLabel.Text = data.Rows[0]["Result"].ToString();
                    ResultsDescribedLabel.Text = data.Rows[0]["ResultsDescribed"].ToString();
                }
            }
        }

        /// <summary>
        /// 日志内容
        /// </summary>
        public DataTable Log_Contents_Data
        {
            set
            {
                StringBuilder str = new StringBuilder();
                if (value.Rows.Count > 1)
                {
                    str.Append("[");
                }
                foreach (DataRow item in value.Rows)
                {
                    str.AppendFormat("{0},", item["Contents"].ToString());
                }
                str.Remove(str.Length - 1, 1);
                if (value.Rows.Count > 1)
                {
                    str.Append("]");
                }
                ContentsTextBox.AppendText(str.ToString());
            }
        }

        public Log_Operating_Info_Controls()
        {
            InitializeComponent();
        }
    }
}
