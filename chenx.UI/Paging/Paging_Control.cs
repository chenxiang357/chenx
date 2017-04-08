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
    public partial class Paging_Control : UserControl
    {
        /// <summary>
        /// 分页绑定
        /// </summary>
        public Paging_DataGridView Paging;

        /// <summary>
        /// 当前页
        /// </summary>
        public int PageIndex
        {
            get { return int.Parse(PageIndex_ToolStripLabel.Text); }
        }

        /// <summary>
        /// 总页数
        /// </summary>
        private int PageCount;

        public Paging_Control()
        {
            InitializeComponent();
        }

        private void Paging_Control_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 加载页面信息
        /// </summary>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageCount">总页数</param>
        /// <param name="pageSize">当前显示数据数量(默认为50条)</param>
        public void Load_Paging_Info(int pageIndex,int pageCount, int pageSize=50)
        {
            if (pageCount == 0)
            {
                PageIndex_ToolStripLabel.Text = "0";
            }
            else
            {
                PageIndex_ToolStripLabel.Text = pageIndex.ToString();
            }

            int v = pageCount / pageSize;
            if ((pageCount % pageSize) > 0)
                v++;
            PageCount = v;
            Total_ToolStripLabel.Text = PageCount.ToString();
            IsEnabled();
        }

        /// <summary>
        /// 分页是否可用
        /// </summary>
        private void IsEnabled()
        {
            First_ToolStripButton.Enabled = true;
            Previous_ToolStripButton.Enabled = true;
            Next_ToolStripButton.Enabled = true;
            Last_ToolStripButton.Enabled = true;

            if (PageIndex == 1 || PageIndex == 0)
            {
                First_ToolStripButton.Enabled = false;
                Previous_ToolStripButton.Enabled = false;
            }
            if (PageIndex == 0 || PageIndex == PageCount)
            {
                Next_ToolStripButton.Enabled = false;
                Last_ToolStripButton.Enabled = false;
            }
        }

        /// <summary>
        /// 第一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void First_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (PageIndex != 1 && PageIndex != 0)
            {
                Paging(1);
            }
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Previous_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (PageIndex != 1 && PageIndex != 0)
            {
                Paging(PageIndex - 1);
            }
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Next_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (PageIndex != 0 && PageIndex != PageCount)
            {
                Paging(PageIndex + 1);
            }
        }

        /// <summary>
        /// 最后一下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Last_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (PageIndex != 0 && PageIndex != PageCount)
            {
                Paging(PageCount);
            }
        }

    }
}
