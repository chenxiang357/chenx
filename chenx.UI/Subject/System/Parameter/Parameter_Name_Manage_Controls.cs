using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using chenx.Model;

namespace chenx.UI
{
    public partial class Parameter_Name_Manage_Controls : UserControl
    {
        /// <summary>
        /// 实体列表
        /// </summary>
        public IEnumerable<ParameterName> EntityList
        {
            set
            {
                Parameter_Name_TreeView.Nodes.Clear();
                if (value != null)
                {
                    foreach (ParameterName item in value.OrderBy(o=>o.No))
                    {
                        TreeNode node = new TreeNode();
                        node.Text = item.ConfigName;
                        node.Name = item.Id.ToString();
                        node.ToolTipText = item.Memo.ToString();
                        Parameter_Name_TreeView.Nodes.Add(node);
                    }
                }
            }
        }

        /// <summary>
        /// 获取当前选中的下标（如果没有选中的话，返回null）
        /// 默认赋值选中的项
        /// </summary>
        public TreeNode SelectedNodes
        {
            get
            {
                if (Parameter_Name_TreeView.SelectedNode != null)
                {
                    return Parameter_Name_TreeView.SelectedNode;
                }
                return null;
            }
            set
            {
                Parameter_Name_TreeView.SelectedNode = value;
            }
        }

        /// <summary>
        /// 添加按钮单机事件
        /// </summary>
        public event EventHandler AddClick;

        /// <summary>
        /// 更新按钮单机事件
        /// </summary>
        public Button_Click_Id UpdateClick;

        /// <summary>
        /// 删除按钮单机事件
        /// </summary>
        public Button_Click_Id StatusUpdateClick;

        /// <summary>
        /// 状态选择
        /// </summary>
        public Button_Click_Id StateCheckData;

        /// <summary>
        /// 单击节点
        /// </summary>
        public Click_TreeNode Click_Node;

        /// <summary>
        /// 判断是否选中节点
        /// </summary>
        private bool Nodes
        {
            get
            {
                if (Parameter_Name_TreeView.SelectedNode != null && Parameter_Name_TreeView.SelectedNode.Name != "0")
                {
                    return true;
                }
                else if (Parameter_Name_TreeView.SelectedNode != null && Parameter_Name_TreeView.SelectedNode.Name == "0")
                {
                    MessageBox.Show("此节点为分类");
                    return false;
                }
                else
                {
                    MessageBox.Show("请先选择节点");
                    return false;
                }
            }
        }

        /// <summary>
        /// 当前状态
        /// </summary>
        public string Status
        {
            get
            {
                if (Status_ToolStripComboBox.Text == "启用")
                {
                    return "1";
                }
                return "0";

            }
        }

        public Parameter_Name_Manage_Controls()
        {
            InitializeComponent();
        }

        private void Parameter_Name_Controls_Load(object sender, EventArgs e)
        {
            Status_ToolStripComboBox.SelectedIndex = 0;
            Status_Image("禁用", "Disabled.png","1");
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Add_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (AddClick!=null)
            {
                AddClick(sender, e);
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (UpdateClick!=null)
            {
                if (Nodes)
                {
                    UpdateClick(Parameter_Name_TreeView.SelectedNode.Name);
                }
            }
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Status_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (StatusUpdateClick!=null)
            {
                if (Nodes)
                {
                    StatusUpdateClick(SelectedNodes.Name);
                }
            }
        }

        /// <summary>
        /// 更改状态按钮样式
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Status_ToolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Status_ToolStripComboBox.Text == "启用")
            {
                Status_Image("禁用", "Disabled.png","1");
            }
            else
            {
                Status_Image("启用", "Enabled.png","0");
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
            Status_ToolStripButton.Text = text;
            Status_ToolStripButton.Image = Image.FromFile(Directory.GetCurrentDirectory() + "/Shared/Images/System/" + image);
            if (StateCheckData != null)
            {
                StateCheckData(state);
            }
        }

        /// <summary>
        /// 鼠标点击节点事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parameter_Name_TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                SelectedNodes = e.Node;
                if (Click_Node!=null)
                {
                    Click_Node(e.Node);
                }
            }
        }
    }
}
