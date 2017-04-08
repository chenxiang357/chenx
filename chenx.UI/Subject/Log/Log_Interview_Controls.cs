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
    public partial class Log_Interview_Controls : UserControl
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
        /// 绑定数据集
        /// </summary>
        public DataTable Data
        {
            set
            {
                dataGridView1.DataSource = value;
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

        public Log_Interview_Controls()
        {
            InitializeComponent();
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
    }
}
