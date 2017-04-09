using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chenx.Model;

namespace chenx.UI
{


    public partial class Expend_Manage_Controls : UserControl
    {
        /// <summary>
        /// 添加按钮单机事件
        /// </summary>
        public event EventHandler AddClick;

        /// <summary>
        /// 查询事件
        /// </summary>
        public event EventHandler QueryClick;

        /// <summary>
        /// 重置
        /// </summary>
        public event EventHandler ResetClick;

        /// <summary>
        /// 表格修改按钮
        /// </summary>
        public Button_Click_Id DataGridView_Update_Button;

        /// <summary>
        /// 表格删除按钮
        /// </summary>
        public Button_Click_Id DataGridView_Delete_Button;

        /// <summary>
        /// 同步
        /// </summary>
        public Button_Click_Id DataGridView_Synchronize_Button;

        /// <summary>
        /// 数据集
        /// </summary>
        public DataTable Data
        {
            set
            {
                ExpendDataGridView.DataSource = value;
            }
        }

        /// <summary>
        /// 总金额
        /// </summary>
        public string Total_Amount
        {
            set
            {
                try
                {
                    TotalAmountToolStripStatusLabel.Text = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate
        {
            get { return StartDateTimePicker.Value; }
        }

        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime EndDate
        {
            get { return EndDateTimePicker.Value; }
        }

        /// <summary>
        /// 支付类型
        /// </summary>
        public string ExpendType
        {
            get { return ExpendType_ToolStripComboBox.Text; }
        }

        /// <summary>
        /// 名称
        /// </summary>
        public string ItemName
        {
            get { return ItemName_ToolStripTextBox.Text; }
        }

        /// <summary>
        /// 金额_1
        /// </summary>
        public string Amount_1
        {
            get { return Amount_1_ToolStripTextBox.Text; }
        }

        /// <summary>
        /// 金额
        /// </summary>
        public string Amount_2
        {
            get { return Amount_2_ToolStripTextBox.Text; }
        }

        /// <summary>
        /// 绑定支付类型
        /// </summary>
        public DataTable Binding_Parameter_Data
        {
            set
            {
                ExpendType_ToolStripComboBox.Items.Add("支付类型");
                foreach (DataRow item in value.Rows)
                {
                    ExpendType_ToolStripComboBox.Items.Add(item["Value"].ToString());
                }
                ExpendType_ToolStripComboBox.SelectedIndex = 0;
            }
        }

        public Expend_Manage_Controls()
        {
            InitializeComponent();
        }

        private void Expend_Manage_Controls_Load(object sender, EventArgs e)
        {
           
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToolStripButton_Click(object sender, EventArgs e)
        {
            AddClick(sender, e);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void QueryToolStripButton_Click(object sender, EventArgs e)
        {
            QueryClick(sender, e);
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetToolStripButton_Click(object sender, EventArgs e)
        {
            StartDateTimePicker.Value = DateTime.Now;
            EndDateTimePicker.Value = DateTime.Now;
            ExpendType_ToolStripComboBox.SelectedIndex = 0;
            ItemName_ToolStripTextBox.Text = string.Empty;
            Amount_1_ToolStripTextBox.Text = string.Empty;
            Amount_2_ToolStripTextBox.Text = string.Empty;
            ResetClick(sender, e);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpendDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                switch (ExpendDataGridView.Columns[e.ColumnIndex].Name)
                {
                    case "updateData":
                        if (DataGridView_Update_Button != null)
                        {
                            DataGridView_Update_Button(ExpendDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                        }
                        break;
                    case "deleteData":
                        if (DataGridView_Delete_Button != null)
                        {
                            DataGridView_Delete_Button(ExpendDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                        }
                        break;
                    case "synchronizeData":
                        if (DataGridView_Synchronize_Button!=null)
                        {
                            DataGridView_Synchronize_Button(ExpendDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        /// <summary>
        /// 行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExpendDataGridView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
