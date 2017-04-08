namespace chenx.UI
{
    partial class Log_Operating_Controls
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ResetButton = new System.Windows.Forms.Button();
            this.LoginNameTextBox = new System.Windows.Forms.TextBox();
            this.TimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.InquireButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LogDataGridView = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ResetButton);
            this.splitContainer1.Panel1.Controls.Add(this.LoginNameTextBox);
            this.splitContainer1.Panel1.Controls.Add(this.TimeDateTimePicker);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.InquireButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.LogDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(802, 527);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(419, 1);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 38;
            this.ResetButton.Text = "重置";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LoginNameTextBox
            // 
            this.LoginNameTextBox.Location = new System.Drawing.Point(213, 1);
            this.LoginNameTextBox.MaxLength = 15;
            this.LoginNameTextBox.Name = "LoginNameTextBox";
            this.LoginNameTextBox.Size = new System.Drawing.Size(119, 21);
            this.LoginNameTextBox.TabIndex = 37;
            // 
            // TimeDateTimePicker
            // 
            this.TimeDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.TimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimeDateTimePicker.Location = new System.Drawing.Point(63, 1);
            this.TimeDateTimePicker.Name = "TimeDateTimePicker";
            this.TimeDateTimePicker.ShowUpDown = true;
            this.TimeDateTimePicker.Size = new System.Drawing.Size(88, 21);
            this.TimeDateTimePicker.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 34;
            this.label2.Text = "操作用户：";
            // 
            // InquireButton
            // 
            this.InquireButton.Location = new System.Drawing.Point(338, 1);
            this.InquireButton.Name = "InquireButton";
            this.InquireButton.Size = new System.Drawing.Size(75, 23);
            this.InquireButton.TabIndex = 35;
            this.InquireButton.Text = "查询";
            this.InquireButton.UseVisualStyleBackColor = true;
            this.InquireButton.Click += new System.EventHandler(this.InquireButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 33;
            this.label1.Text = "操作时间：";
            // 
            // LogDataGridView
            // 
            this.LogDataGridView.AllowUserToAddRows = false;
            this.LogDataGridView.AllowUserToDeleteRows = false;
            this.LogDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column4,
            this.Column5});
            this.LogDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogDataGridView.Location = new System.Drawing.Point(0, 0);
            this.LogDataGridView.Name = "LogDataGridView";
            this.LogDataGridView.ReadOnly = true;
            this.LogDataGridView.RowHeadersWidth = 55;
            this.LogDataGridView.RowTemplate.Height = 23;
            this.LogDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogDataGridView.Size = new System.Drawing.Size(802, 501);
            this.LogDataGridView.TabIndex = 34;
            this.LogDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LogDataGridView_CellDoubleClick);
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column7.DataPropertyName = "Id";
            this.Column7.HeaderText = "Id";
            this.Column7.MinimumWidth = 36;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Visible = false;
            this.Column7.Width = 36;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Creation_Date";
            this.Column1.HeaderText = "操作时间";
            this.Column1.MinimumWidth = 120;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.DataPropertyName = "Login_Name";
            this.Column2.HeaderText = "操作用户";
            this.Column2.MinimumWidth = 90;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "ModuleName";
            this.Column3.HeaderText = "系统功能";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.DataPropertyName = "OperationType";
            this.Column6.HeaderText = "操作类型";
            this.Column6.MinimumWidth = 76;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 76;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column4.DataPropertyName = "Result";
            this.Column4.HeaderText = "操作结果";
            this.Column4.MinimumWidth = 76;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 76;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ResultsDescribed";
            this.Column5.HeaderText = "结果描述";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Log_Operating_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Log_Operating_Controls";
            this.Size = new System.Drawing.Size(802, 527);
            this.Load += new System.EventHandler(this.Log_Operating_Controls_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.TextBox LoginNameTextBox;
        private System.Windows.Forms.DateTimePicker TimeDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InquireButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}
