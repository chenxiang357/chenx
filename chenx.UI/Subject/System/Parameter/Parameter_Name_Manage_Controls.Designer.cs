namespace chenx.UI
{
    partial class Parameter_Name_Manage_Controls
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parameter_Name_Manage_Controls));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Status_ToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.Add_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Update_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Status_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Parameter_Name_TreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_ToolStripComboBox,
            this.Add_ToolStripButton,
            this.Update_ToolStripButton,
            this.Status_ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStrip1.Size = new System.Drawing.Size(150, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Status_ToolStripComboBox
            // 
            this.Status_ToolStripComboBox.AutoSize = false;
            this.Status_ToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_ToolStripComboBox.DropDownWidth = 49;
            this.Status_ToolStripComboBox.Items.AddRange(new object[] {
            "启用",
            "禁用"});
            this.Status_ToolStripComboBox.MergeIndex = 0;
            this.Status_ToolStripComboBox.Name = "Status_ToolStripComboBox";
            this.Status_ToolStripComboBox.Size = new System.Drawing.Size(49, 25);
            this.Status_ToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.Status_ToolStripComboBox_SelectedIndexChanged);
            // 
            // Add_ToolStripButton
            // 
            this.Add_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Add_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Add_ToolStripButton.Image")));
            this.Add_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Add_ToolStripButton.Name = "Add_ToolStripButton";
            this.Add_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Add_ToolStripButton.Text = "添加";
            this.Add_ToolStripButton.Click += new System.EventHandler(this.Add_ToolStripButton_Click);
            // 
            // Update_ToolStripButton
            // 
            this.Update_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Update_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Update_ToolStripButton.Image")));
            this.Update_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Update_ToolStripButton.Name = "Update_ToolStripButton";
            this.Update_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Update_ToolStripButton.Text = "修改";
            this.Update_ToolStripButton.Click += new System.EventHandler(this.Update_ToolStripButton_Click);
            // 
            // Status_ToolStripButton
            // 
            this.Status_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Status_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Status_ToolStripButton.Name = "Status_ToolStripButton";
            this.Status_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Status_ToolStripButton.Text = "删除";
            this.Status_ToolStripButton.Click += new System.EventHandler(this.Status_ToolStripButton_Click);
            // 
            // Parameter_Name_TreeView
            // 
            this.Parameter_Name_TreeView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Parameter_Name_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Parameter_Name_TreeView.HideSelection = false;
            this.Parameter_Name_TreeView.Location = new System.Drawing.Point(0, 25);
            this.Parameter_Name_TreeView.Name = "Parameter_Name_TreeView";
            this.Parameter_Name_TreeView.Size = new System.Drawing.Size(150, 482);
            this.Parameter_Name_TreeView.TabIndex = 2;
            this.Parameter_Name_TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Parameter_Name_TreeView_NodeMouseClick);
            // 
            // Parameter_Name_Manage_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Parameter_Name_TreeView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Parameter_Name_Manage_Controls";
            this.Size = new System.Drawing.Size(150, 507);
            this.Load += new System.EventHandler(this.Parameter_Name_Controls_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Add_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Update_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Status_ToolStripButton;
        private System.Windows.Forms.TreeView Parameter_Name_TreeView;
        private System.Windows.Forms.ToolStripComboBox Status_ToolStripComboBox;
    }
}
