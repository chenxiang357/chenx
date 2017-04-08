namespace chenx.UI
{
    partial class System_User_Manage_Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(System_User_Manage_Controls));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.LoginName_Inquire_ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.UserName_Inquire_ToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.QueryToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ResetToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.AddToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UserDataGridView = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateUser = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteUser = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.LoginName_Inquire_ToolStripTextBox,
            this.toolStripLabel2,
            this.UserName_Inquire_ToolStripTextBox,
            this.QueryToolStripButton,
            this.ResetToolStripButton,
            this.AddToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(780, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "用户名：";
            // 
            // LoginName_Inquire_ToolStripTextBox
            // 
            this.LoginName_Inquire_ToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginName_Inquire_ToolStripTextBox.MaxLength = 20;
            this.LoginName_Inquire_ToolStripTextBox.Name = "LoginName_Inquire_ToolStripTextBox";
            this.LoginName_Inquire_ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel2.Text = "姓名：";
            // 
            // UserName_Inquire_ToolStripTextBox
            // 
            this.UserName_Inquire_ToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName_Inquire_ToolStripTextBox.MaxLength = 10;
            this.UserName_Inquire_ToolStripTextBox.Name = "UserName_Inquire_ToolStripTextBox";
            this.UserName_Inquire_ToolStripTextBox.Size = new System.Drawing.Size(100, 25);
            // 
            // QueryToolStripButton
            // 
            this.QueryToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QueryToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("QueryToolStripButton.Image")));
            this.QueryToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QueryToolStripButton.Name = "QueryToolStripButton";
            this.QueryToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.QueryToolStripButton.Text = "查询";
            this.QueryToolStripButton.Click += new System.EventHandler(this.QueryToolStripButton_Click);
            // 
            // ResetToolStripButton
            // 
            this.ResetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResetToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ResetToolStripButton.Image")));
            this.ResetToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetToolStripButton.Name = "ResetToolStripButton";
            this.ResetToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ResetToolStripButton.Text = "重置";
            this.ResetToolStripButton.Click += new System.EventHandler(this.ResetToolStripButton_Click);
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
            this.Column3,
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column4,
            this.UpdateUser,
            this.DeleteUser});
            this.UserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserDataGridView.Location = new System.Drawing.Point(0, 25);
            this.UserDataGridView.Name = "UserDataGridView";
            this.UserDataGridView.ReadOnly = true;
            this.UserDataGridView.RowTemplate.Height = 23;
            this.UserDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserDataGridView.Size = new System.Drawing.Size(780, 431);
            this.UserDataGridView.TabIndex = 2;
            this.UserDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataGridView_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Id";
            this.Column3.HeaderText = "Id";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "IsAdmin";
            this.Column7.HeaderText = "IsAdmin";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "LoginName";
            this.Column1.HeaderText = "用户名";
            this.Column1.MinimumWidth = 100;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "UserName";
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 100;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Remarks";
            this.Column4.HeaderText = "备注";
            this.Column4.MinimumWidth = 100;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // UpdateUser
            // 
            this.UpdateUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UpdateUser.HeaderText = "修改";
            this.UpdateUser.MinimumWidth = 36;
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.ReadOnly = true;
            this.UpdateUser.Width = 36;
            // 
            // DeleteUser
            // 
            this.DeleteUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DeleteUser.HeaderText = "删除";
            this.DeleteUser.MinimumWidth = 36;
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.ReadOnly = true;
            this.DeleteUser.Width = 36;
            // 
            // System_User_Manage_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UserDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "System_User_Manage_Controls";
            this.Size = new System.Drawing.Size(780, 456);
            this.Load += new System.EventHandler(this.System_User_Manage_Controls_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox LoginName_Inquire_ToolStripTextBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox UserName_Inquire_ToolStripTextBox;
        private System.Windows.Forms.DataGridView UserDataGridView;
        private System.Windows.Forms.ToolStripButton QueryToolStripButton;
        private System.Windows.Forms.ToolStripButton ResetToolStripButton;
        private System.Windows.Forms.ToolStripButton AddToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn UpdateUser;
        private System.Windows.Forms.DataGridViewImageColumn DeleteUser;
    }
}
