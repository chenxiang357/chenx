using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using chenx.Model;

namespace chenx.UI
{
    public partial class Log_Error_Manage_Controls : UserControl
    {
        /// <summary>
        /// 刷新
        /// </summary>
        public EventHandler Refresh_Button_Click { get; set; }

        /// <summary>
        /// 上一页
        /// </summary>
        public EventHandler PreviousPage_Button_Click { get; set; }

        /// <summary>
        /// 首页
        /// </summary>
        public EventHandler Home_Button_Click { get; set; }

        /// <summary>
        /// 双击表格
        /// </summary>
        public DelegateString DataGrid_Double { get; set; }

        /// <summary>
        /// 单击树形结构
        /// </summary>
        public Click_TreeNode TreeNode_Click { get; set; }

        /// <summary>
        /// 路径
        /// </summary>
        public string PathUrl
        {
            get { return UrlPathToolStripLabel.Text;  }
            set { UrlPathToolStripLabel.Text = value; }
        }

        /// <summary>
        /// 节点数据列表
        /// </summary>
        public IEnumerable<int> NodeData
        {
            set
            {
                if (value != null)
                {
                    treeView1.Nodes.Clear();
                    foreach (var item in value)
                    {
                        TreeNode node = new TreeNode();
                        node.Text = item.ToString();
                        node.Name = item.ToString();
                        treeView1.Nodes.Add(node);
                    }
                }
            }
        }

        /// <summary>
        /// 错误日志实体列表
        /// </summary>
        public IEnumerable<ErrorLog_FileInfo> ErrorLog_Entity_List
        {
            set { dataGridView1.DataSource = value; }
        }

        public Log_Error_Manage_Controls()
        {
            InitializeComponent();
        }

        private void Log_Error_Manage_Controls_Load(object sender, EventArgs e)
        {
            //ButtonEnabled(false);
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshToolStripButton_Click(object sender, EventArgs e)
        {
            if (Refresh_Button_Click!=null)
            {
                Refresh_Button_Click(sender, e);
            }
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousPageToolStripButton_Click(object sender, EventArgs e)
        {
            if (PreviousPage_Button_Click!=null)
            {
                PreviousPage_Button_Click(sender, e);
            }
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeToolStripButton_Click(object sender, EventArgs e)
        {
            if (Home_Button_Click != null)
            {
                Home_Button_Click(sender, e);
            }
        }

        /// <summary>
        /// 弹出详细页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (DataGrid_Double!=null)
                {
                    DataGrid_Double(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }

        /// <summary>
        /// 序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }

        /// <summary>
        /// 按钮是否显示
        /// </summary>
        /// <param name="b">布尔值</param>
        public void ButtonEnabled(bool b)
        {
            //首页
            HomeToolStripButton.Enabled = b;
            
            //上一页
            PreviousPageToolStripButton.Enabled = b;
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (TreeNode_Click!=null)
            {
                TreeNode_Click(e.Node);
            }
        }
    }
}
