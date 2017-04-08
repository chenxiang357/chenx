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
    public partial class Account_Menu_Control : UserControl
    {
        /// <summary>
        /// 读取实体
        /// </summary>

        public Read_AccountNumber AccountNumber_Entity;

        /// <summary>
        /// 实体列表
        /// </summary>
        public IList<AccountNumber> AccountNumber_Entity_List { get; set; }

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
        public Button_Click_Id DeleteClick;

        /// <summary>
        /// 判断是否选中节点
        /// </summary>
        private bool Nodes
        {
            get
            {
                return IsNode(Menu_TreeView.SelectedNode);
            }
        }

        /// <summary>
        /// TreeView数据集
        /// </summary>
        public IList<AccountNumber> TreeViewData
        {
            set
            {
                Menu_TreeView.Nodes.Clear();
                AccountNumber_Entity_List = value;
                if (AccountNumber_Entity_List != null)
                {
                    if (AccountNumber_Entity_List.Count > 0)
                    {
                        var dataList = AccountNumber_Entity_List.GroupBy(g => g.AccountType).Select(s=>s.First()).ToList();//.Select(s => s.AccountType).GroupBy(g => g);
                        foreach (var item in dataList)
                        {
                            TreeNode node = new TreeNode();
                            node.Text = item.AccountType;
                            node.Name = "0";
                            Menu_TreeView.Nodes.Add(node);
                            BindingTreeView(node);
                        }
                        Menu_TreeView.ExpandAll();
                    }
                }
            }
        }


        public Account_Menu_Control()
        {
            InitializeComponent();
        }

        private void Account_Menu_Control_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 点击查看信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_TreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (IsNode(e.Node))
            {
                AccountNumber_Entity(e.Node.Name);
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddAccountNumber_ToolStripButton_Click(object sender, EventArgs e)
        {
            AddClick(sender, e);
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (Nodes)
            {
                UpdateClick(Menu_TreeView.SelectedNode.Name);
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_ToolStripButton_Click(object sender, EventArgs e)
        {
            if (Nodes)
            {
                DeleteClick(Menu_TreeView.SelectedNode.Name);
            }
        }

        /// <summary>
        /// 绑定TreeView数据
        /// </summary>
        /// <param name="nodes"></param>
        private void BindingTreeView(TreeNode nodes)
        {
            var entityList = AccountNumber_Entity_List.Where(w => w.AccountType == nodes.Text);
            foreach (AccountNumber item in entityList)
            {
                TreeNode node = new TreeNode();
                node.Text = item.Name;
                node.Name = item.Id;
                nodes.Nodes.Add(node);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nodes"></param>
        /// <returns></returns>
        private bool IsNode(TreeNode nodes)
        {
            if (nodes != null && nodes.Name != "0")
            {
                return true;
            }
            else if (nodes != null && nodes.Name == "0")
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
}
