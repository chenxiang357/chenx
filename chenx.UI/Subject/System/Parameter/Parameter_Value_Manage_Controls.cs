using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chenx.Model;
using System.IO;

namespace chenx.UI
{
    public partial class Parameter_Value_Manage_Controls : UserControl
    {
        /// <summary>
        /// 添加按钮单机事件
        /// </summary>
        public event EventHandler AddClick;

        /// <summary>
        /// 状态选择
        /// </summary>
        public Button_Click_Id StateCheckData;

        /// <summary>
        /// 表格修改按钮
        /// </summary>
        public Button_Click_Id DataGridView_Update_Button;

        /// <summary>
        /// 表格修改按钮
        /// </summary>
        public Button_Click_Id DataGridView_Status_Button;

        /// <summary>
        /// 当前状态
        /// </summary>
        public string Status
        {
            get
            {
                if (Status_ToolStripComboBox.Text=="启用")
                {
                    return "1";
                }
                return "0";
                
            }
        }

        /// <summary>
        /// 参数实体列表
        /// </summary>
        public IEnumerable<ParameterValue> ParameterValue_Entity_List
        {
            set
            {
                IEnumerable<ParameterValue> entityList;

                if (value == null)
                    entityList = new List<ParameterValue>();
                else
                    entityList = value;

                dataGridView1.DataSource = entityList.Select(s => new
                {
                    s.Id,
                    s.Value,
                    s.Memo,
                    s.No
                }).OrderBy(o => o.No).ToList();
            }
        }


        public Parameter_Value_Manage_Controls()
        {
            InitializeComponent();
        }

        private void Parameter_Value_Manage_Controls_Load(object sender, EventArgs e)
        {
            Status_ToolStripComboBox.SelectedIndex = 0;
            this.UpdateParameterValue.Image = Image.FromFile(Directory.GetCurrentDirectory() + @"/Shared/Images/edit.png");
        }

        /// <summary>
        /// 添加参数值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (AddClick != null)
            {
                AddClick(sender, e);
            }
        }

        private void Status_ToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Status_ToolStripComboBox.Text == "启用")
            {
                Status_Image("禁用", "Disabled.png", "1");
            }
            else
            {
                Status_Image("启用", "Enabled.png", "0");
            }
        }

        /// <summary>
        /// 按钮样式
        /// </summary>
        /// <param name="text">文本</param>
        /// <param name="image">图片</param>
        /// <param name="state">当前状态</param>
        private void Status_Image(string text, string image, string state)
        {
            this.StatusParameterValue.HeaderText = text;
            this.StatusParameterValue.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/Shared/Images/System/" + image);
            if (StateCheckData != null)
            {
                StateCheckData(state);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                switch (dataGridView1.Columns[e.ColumnIndex].Name)
                {
                    case "UpdateParameterValue":
                        if (DataGridView_Update_Button != null)
                        {
                            DataGridView_Update_Button(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                        }
                        break;
                    case "StatusParameterValue":
                        if (DataGridView_Status_Button != null)
                        {
                            DataGridView_Status_Button(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// 添加序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            e.Row.HeaderCell.Value = string.Format("{0}", e.Row.Index + 1);
        }
    }
}
