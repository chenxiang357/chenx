namespace chenx.UI
{
    partial class Role_Manage_Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Role_Manage_Controls));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.QueryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ResetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBox1,
            this.QueryToolStripButton,
            this.ResetToolStripButton,
            this.AddToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(722, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(68, 22);
            this.toolStripLabel1.Text = "角色名称：";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // QueryToolStripButton
            // 
            this.QueryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QueryToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("QueryToolStripButton.Image")));
            this.QueryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QueryToolStripButton.Name = "QueryToolStripButton";
            this.QueryToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.QueryToolStripButton.Text = "查询";
            // 
            // ResetToolStripButton
            // 
            this.ResetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResetToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetToolStripButton.Image")));
            this.ResetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetToolStripButton.Name = "ResetToolStripButton";
            this.ResetToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ResetToolStripButton.Text = "重置";
            // 
            // AddToolStripButton
            // 
            this.AddToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.AddToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AddToolStripButton.Image")));
            this.AddToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddToolStripButton.Margin = new System.Windows.Forms.Padding(0, 1, 3, 2);
            this.AddToolStripButton.Name = "AddToolStripButton";
            this.AddToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.AddToolStripButton.Text = "添加";
            this.AddToolStripButton.Click += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // UserDataGridView
            // 
            this.UserDataGridView.AllowUserToAddRows = false;
            this.UserDataGridView.AllowUserToDeleteRows = false;
            this.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column5,
            this.Column6});
            this.UserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDataGridView.Location = new System.Drawing.Point(0, 25);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.ReadOnly = true;
            this.UserDataGridView.RowTemplate.Height = 23;
            this.UserDataGridView.Size = new System.Drawing.Size(722, 405);
            this.UserDataGridView.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "角色名称";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "备注";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column5.HeaderText = "修改";
            this.Column5.MinimumWidth = 36;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 36;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.HeaderText = "删除";
            this.Column6.MinimumWidth = 36;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 36;
            // 
            // Role_Manage_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Role_Manage_Controls";
            this.Size = new System.Drawing.Size(722, 430);
            this.Load += new System.EventHandler(this.Role_Manage_Controls_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton QueryToolStripButton;
        private System.Windows.Forms.ToolStripButton ResetToolStripButton;
        private System.Windows.Forms.ToolStripButton AddToolStripButton;
        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
    }
}
