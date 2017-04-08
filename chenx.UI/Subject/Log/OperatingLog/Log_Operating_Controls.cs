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
    public partial class Log_Operating_Controls : UserControl
    {
        /// <summary>
        /// 查询按钮
        /// </summary>
        public event EventHandler InquireClick;

        /// <summary>
        /// 重置按钮
        /// </summary>
        public event EventHandler ResetClick;

        /// <summary>
        /// 表格删除按钮
        /// </summary>
        public Button_Click_Id DataGridView_Show;

        /// <summary>
        /// 绑定数据集
        /// </summary>
        public DataSet Data
        {
            set
            {
                LogDataGridView.DataSource = value.Tables[0];
            }
        }

        /// <summary>
        /// 操作日期
        /// </summary>
        public DateTime OperationDate
        {
            get { return TimeDateTimePicker.Value; }
            set { TimeDateTimePicker.Value = value; }
        }

        /// <summary>
        /// 操作用户
        /// </summary>
        public string LoginName
        {
            get { return LoginNameTextBox.Text; }
            set { LoginNameTextBox.Text = value; }
        }

        public Log_Operating_Controls()
        {
            InitializeComponent();
        }

        private void Log_Operating_Controls_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InquireButton_Click(object sender, EventArgs e)
        {
            if (InquireClick!=null)
            {
                InquireClick(sender, e);
            }
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetButton_Click(object sender, EventArgs e)
        {
            if (ResetClick!=null)
            {
                ResetClick(sender, e);
            }
        }

        /// <summary>
        /// 单元格双击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridView_Show!=null)
            {
                DataGridView_Show(LogDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
