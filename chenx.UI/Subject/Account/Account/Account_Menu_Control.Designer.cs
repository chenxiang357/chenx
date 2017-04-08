namespace chenx.UI
{
    partial class Account_Menu_Control
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account_Menu_Control));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddAccountNumber_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Update_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Delete_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Menu_TreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAccountNumber_ToolStripButton,
            this.Update_ToolStripButton,
            this.Delete_ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(168, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddAccountNumber_ToolStripButton
            // 
            this.AddAccountNumber_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddAccountNumber_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddAccountNumber_ToolStripButton.Image")));
            this.AddAccountNumber_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddAccountNumber_ToolStripButton.Name = "AddAccountNumber_ToolStripButton";
            this.AddAccountNumber_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AddAccountNumber_ToolStripButton.Text = "toolStripButton1";
            this.AddAccountNumber_ToolStripButton.Click += new System.EventHandler(this.AddAccountNumber_ToolStripButton_Click);
            // 
            // Update_ToolStripButton
            // 
            this.Update_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Update_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Update_ToolStripButton.Image")));
            this.Update_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Update_ToolStripButton.Name = "Update_ToolStripButton";
            this.Update_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Update_ToolStripButton.Text = "toolStripButton2";
            this.Update_ToolStripButton.Click += new System.EventHandler(this.Update_ToolStripButton_Click);
            // 
            // Delete_ToolStripButton
            // 
            this.Delete_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Delete_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Delete_ToolStripButton.Image")));
            this.Delete_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Delete_ToolStripButton.Name = "Delete_ToolStripButton";
            this.Delete_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Delete_ToolStripButton.Text = "删除";
            this.Delete_ToolStripButton.Click += new System.EventHandler(this.Delete_ToolStripButton_Click);
            // 
            // Menu_TreeView
            // 
            this.Menu_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Menu_TreeView.Location = new System.Drawing.Point(0, 25);
            this.Menu_TreeView.Margin = new System.Windows.Forms.Padding(0);
            this.Menu_TreeView.Name = "Menu_TreeView";
            this.Menu_TreeView.Size = new System.Drawing.Size(168, 423);
            this.Menu_TreeView.TabIndex = 2;
            this.Menu_TreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Menu_TreeView_NodeMouseClick);
            // 
            // Account_Menu_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Menu_TreeView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Account_Menu_Control";
            this.Size = new System.Drawing.Size(168, 448);
            this.Load += new System.EventHandler(this.Account_Menu_Control_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddAccountNumber_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Update_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Delete_ToolStripButton;
        private System.Windows.Forms.TreeView Menu_TreeView;
    }
}
