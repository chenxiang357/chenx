namespace chenx.UI
{
    partial class Parameter_Value_Manage_Controls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parameter_Value_Manage_Controls));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Status_ToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.Add_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateParameterValue = new System.Windows.Forms.DataGridViewImageColumn();
            this.StatusParameterValue = new System.Windows.Forms.DataGridViewImageColumn();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status_ToolStripComboBox,
            this.Add_ToolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(591, 25);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // Status_ToolStripComboBox
            // 
            this.Status_ToolStripComboBox.AutoSize = false;
            this.Status_ToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Status_ToolStripComboBox.DropDownWidth = 49;
            this.Status_ToolStripComboBox.Items.AddRange(new object[] {
            "启用",
            "禁用"});
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.UpdateParameterValue,
            this.StatusParameterValue});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 55;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(591, 458);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Id";
            this.Column5.HeaderText = "Id";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "Value";
            this.Column1.HeaderText = "参数值";
            this.Column1.MinimumWidth = 120;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Memo";
            this.Column2.HeaderText = "备注";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "No";
            this.Column3.HeaderText = "序号";
            this.Column3.MinimumWidth = 55;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 55;
            // 
            // UpdateParameterValue
            // 
            this.UpdateParameterValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.UpdateParameterValue.HeaderText = "修改";
            this.UpdateParameterValue.MinimumWidth = 36;
            this.UpdateParameterValue.Name = "UpdateParameterValue";
            this.UpdateParameterValue.ReadOnly = true;
            this.UpdateParameterValue.Width = 36;
            // 
            // StatusParameterValue
            // 
            this.StatusParameterValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StatusParameterValue.HeaderText = "启用";
            this.StatusParameterValue.MinimumWidth = 36;
            this.StatusParameterValue.Name = "StatusParameterValue";
            this.StatusParameterValue.ReadOnly = true;
            this.StatusParameterValue.Width = 36;
            // 
            // Parameter_Value_Manage_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Parameter_Value_Manage_Controls";
            this.Size = new System.Drawing.Size(591, 483);
            this.Load += new System.EventHandler(this.Parameter_Value_Manage_Controls_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Add_ToolStripButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripComboBox Status_ToolStripComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn UpdateParameterValue;
        private System.Windows.Forms.DataGridViewImageColumn StatusParameterValue;
    }
}
