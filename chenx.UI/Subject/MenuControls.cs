using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BSE.Windows.Forms;
using JsonHelper;
using chenx.Model;
using System.Linq;

namespace chenx.UI
{
    /// <summary>
    /// 菜单栏
    /// </summary>
    public partial class MenuControls : UserControl
    {
        /// <summary>
        /// 定义委托变量
        /// </summary>
        public Button_Click_Id Click_PopUp_Window { get; set; }

        /// <summary>
        /// 菜单Json
        /// </summary>
        public string MenuJson { get; set; }

        ///// <summary>
        ///// 记录弹出窗口的名称
        ///// </summary>
        //private dynamic form;

        public MenuControls()
        {
            InitializeComponent();
        }

        private void MenuControls_Load(object sender, EventArgs e)
        {
            if (MenuJson != null && MenuJson.Length > 0)
            {
                IList<MainModule> MenuList = Json.DeserializationList<MainModule>(MenuJson);
                if (MenuList != null)
                {
                    XPanderPanel_Combination(MenuList);
                }
            }
        }

        /// <summary>
        /// 一级菜单--菜单组合
        /// </summary>
        /// <param name="entityList"></param>
        private void XPanderPanel_Combination(IList<MainModule> entityList)
        {
            if (entityList.Count > 0)
            {
                xPanderPanelList1.SuspendLayout();
                XPanderPanel[] MenuList_XPanderPanel = new XPanderPanel[entityList.Count];
                for (int i = 0; i < entityList.Count; i++)
                {
                    MenuList_XPanderPanel[i] = new XPanderPanel();

                    MenuList_XPanderPanel[i].CaptionFont = new Font("Microsoft YaHei UI", 8F, FontStyle.Bold);
                    MenuList_XPanderPanel[i].CustomColors.BackColor = SystemColors.Control;
                    MenuList_XPanderPanel[i].CustomColors.BorderColor = Color.FromArgb(184, 184, 184);
                    MenuList_XPanderPanel[i].CustomColors.CaptionCheckedGradientBegin = Color.Empty;
                    MenuList_XPanderPanel[i].CustomColors.CaptionCheckedGradientEnd = Color.Empty;
                    MenuList_XPanderPanel[i].CustomColors.CaptionCheckedGradientMiddle = Color.Empty;
                    MenuList_XPanderPanel[i].CustomColors.CaptionCloseIcon = SystemColors.ControlText;
                    MenuList_XPanderPanel[i].CustomColors.CaptionExpandIcon = SystemColors.ControlText;
                    MenuList_XPanderPanel[i].CustomColors.CaptionGradientBegin = Color.FromArgb(252, 252, 252);
                    MenuList_XPanderPanel[i].CustomColors.CaptionGradientEnd = SystemColors.ButtonFace;
                    MenuList_XPanderPanel[i].CustomColors.CaptionGradientMiddle = Color.FromArgb(248, 248, 248);
                    MenuList_XPanderPanel[i].CustomColors.CaptionPressedGradientBegin = Color.FromArgb(128, 188, 235);
                    MenuList_XPanderPanel[i].CustomColors.CaptionPressedGradientEnd = Color.FromArgb(128, 188, 235);
                    MenuList_XPanderPanel[i].CustomColors.CaptionPressedGradientMiddle = Color.FromArgb(128, 188, 235);
                    MenuList_XPanderPanel[i].CustomColors.CaptionSelectedGradientBegin = Color.FromArgb(179, 215, 243);
                    MenuList_XPanderPanel[i].CustomColors.CaptionSelectedGradientEnd = Color.FromArgb(179, 215, 243);
                    MenuList_XPanderPanel[i].CustomColors.CaptionSelectedGradientMiddle = Color.FromArgb(179, 215, 243);
                    MenuList_XPanderPanel[i].CustomColors.CaptionSelectedText = SystemColors.ControlText;
                    MenuList_XPanderPanel[i].CustomColors.CaptionText = SystemColors.ControlText;
                    MenuList_XPanderPanel[i].CustomColors.FlatCaptionGradientBegin = Color.FromArgb(248, 248, 248);
                    MenuList_XPanderPanel[i].CustomColors.FlatCaptionGradientEnd = Color.FromArgb(252, 252, 252);
                    MenuList_XPanderPanel[i].CustomColors.InnerBorderColor = SystemColors.Window;
                    MenuList_XPanderPanel[i].ForeColor = SystemColors.ControlText;
                    MenuList_XPanderPanel[i].Image = null;
                    MenuList_XPanderPanel[i].Name = entityList[i].MenuId;
                    MenuList_XPanderPanel[i].Size = new Size(200, 382);
                    MenuList_XPanderPanel[i].TabIndex = entityList[i].No;
                    MenuList_XPanderPanel[i].Text = entityList[i].MenuName;
                    MenuList_XPanderPanel[i].ToolTipTextCloseIcon = null;
                    MenuList_XPanderPanel[i].ToolTipTextExpandIconPanelCollapsed = null;
                    MenuList_XPanderPanel[i].ToolTipTextExpandIconPanelExpanded = null;
                    if (i == 0)
                        MenuList_XPanderPanel[i].Expand = true;
                    xPanderPanelList1.Controls.Add(MenuList_XPanderPanel[i]);
                    TreeView_Combination(MenuList_XPanderPanel[i], entityList[i].MenuList);
                }
                xPanderPanelList1.ResumeLayout(false);
            }
        }

        /// <summary>
        /// 二级菜单
        /// </summary>
        /// <param name="kj"></param>
        /// <param name="entityList"></param>
        private void TreeView_Combination(XPanderPanel kj, IList<SubModule> entityList)
        {
            if (entityList.Count > 0)
            {
                TreeView treeView1 = new TreeView();
                kj.SuspendLayout();
                kj.Controls.Add(treeView1);
                treeView1.Cursor = Cursors.Hand;
                treeView1.Dock = DockStyle.Fill;
                treeView1.Location = new Point(1, 25);
                treeView1.Name = "TreeView1" + Guid.NewGuid().ToString();
                treeView1.ShowLines = false;
                treeView1.Size = new Size(198, 111);
                treeView1.TabIndex = 0;
                treeView1.ImageList = LoadImageList(entityList);
                treeView1.NodeMouseClick += treeView1_NodeMouseClick;
                treeView1.ItemHeight = 19;
                for (int i = 0; i < entityList.Count; i++)
                {
                    TreeNode node = new TreeNode();
                    node.Text = entityList[i].ModuleName;
                    node.Name = entityList[i].ModuleId;
                    node.ImageIndex = i;
                    node.SelectedImageIndex = i;
                    treeView1.Nodes.Add(node);
                }
                kj.ResumeLayout(false);
            }
        }

        /// <summary>
        /// 菜单图片
        /// </summary>
        /// <param name="entityList"></param>
        /// <returns></returns>
        private ImageList LoadImageList(IList<SubModule> entityList)
        {
            ImageList imageList1 = new ImageList();
            for (int i = 0; i < entityList.Count; i++)
            {
                string fileUrl = Directory.GetCurrentDirectory() + entityList[i].ImagesUrl;
                if (File.Exists(fileUrl))
                {
                    imageList1.Images.Add(i.ToString(), Image.FromFile(fileUrl));
                }
                else
                {
                    imageList1.Images.Add(i.ToString(), Image.FromFile(Directory.GetCurrentDirectory() + "/Shared/Images/menu/no.png"));
                }
            }
            return imageList1;
        }

        /// <summary>
        /// 二菜单--菜单组合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
           
            Click_PopUp_Window(e.Node.Name);
        }

        /// <summary>
        /// 弹出窗口
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="v"></param>
        public void ShowForm(Form f,Form v)
        {
            panel2.Controls.Clear();
            //form = f;
            f.MdiParent = v;
            f.Parent = panel2;
            f.Dock = panel2.Dock;
            FormSize();
            f.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel1_ExpandClick(object sender, EventArgs e)
        {
            //FormSize();
        }

        /// <summary>
        /// 窗体大小改变
        /// </summary>
        public void FormSize()
        {
            //if (form!=null)
            //{
            //    form.Height = panel2.Height;
            //    form.Width = panel2.Width;
            //}
        }
    }
}
