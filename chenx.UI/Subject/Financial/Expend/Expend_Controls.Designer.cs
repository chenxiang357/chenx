namespace chenx.UI
{
    partial class Expend_Controls
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ExpendDate_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ExpendType_ComboBox = new System.Windows.Forms.ComboBox();
            this.Remarks_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Reason_TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Amount_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemName_TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.ExpendDate_DateTimePicker, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ExpendType_ComboBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Remarks_TextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Reason_TextBox, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Amount_NumericUpDown, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ItemName_TextBox, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(491, 303);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ExpendDate_DateTimePicker
            // 
            this.ExpendDate_DateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExpendDate_DateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.ExpendDate_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ExpendDate_DateTimePicker.Location = new System.Drawing.Point(125, 8);
            this.ExpendDate_DateTimePicker.Name = "ExpendDate_DateTimePicker";
            this.ExpendDate_DateTimePicker.ShowUpDown = true;
            this.ExpendDate_DateTimePicker.Size = new System.Drawing.Size(172, 21);
            this.ExpendDate_DateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "日期：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "支出类型：";
            // 
            // ExpendType_ComboBox
            // 
            this.ExpendType_ComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ExpendType_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpendType_ComboBox.FormattingEnabled = true;
            this.ExpendType_ComboBox.Location = new System.Drawing.Point(125, 46);
            this.ExpendType_ComboBox.Name = "ExpendType_ComboBox";
            this.ExpendType_ComboBox.Size = new System.Drawing.Size(172, 20);
            this.ExpendType_ComboBox.TabIndex = 4;
            // 
            // Remarks_TextBox
            // 
            this.Remarks_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remarks_TextBox.Location = new System.Drawing.Point(125, 208);
            this.Remarks_TextBox.MaxLength = 450;
            this.Remarks_TextBox.Multiline = true;
            this.Remarks_TextBox.Name = "Remarks_TextBox";
            this.Remarks_TextBox.Size = new System.Drawing.Size(362, 91);
            this.Remarks_TextBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "备注：";
            // 
            // Reason_TextBox
            // 
            this.Reason_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reason_TextBox.Location = new System.Drawing.Point(125, 152);
            this.Reason_TextBox.MaxLength = 240;
            this.Reason_TextBox.Multiline = true;
            this.Reason_TextBox.Name = "Reason_TextBox";
            this.Reason_TextBox.Size = new System.Drawing.Size(362, 49);
            this.Reason_TextBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "原因：";
            // 
            // Amount_NumericUpDown
            // 
            this.Amount_NumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Amount_NumericUpDown.DecimalPlaces = 2;
            this.Amount_NumericUpDown.Location = new System.Drawing.Point(125, 119);
            this.Amount_NumericUpDown.Maximum = new decimal(new int[] {
            410065408,
            2,
            0,
            0});
            this.Amount_NumericUpDown.Name = "Amount_NumericUpDown";
            this.Amount_NumericUpDown.Size = new System.Drawing.Size(172, 21);
            this.Amount_NumericUpDown.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "金额：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "名称：";
            // 
            // ItemName_TextBox
            // 
            this.ItemName_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ItemName_TextBox.Location = new System.Drawing.Point(125, 82);
            this.ItemName_TextBox.MaxLength = 100;
            this.ItemName_TextBox.Name = "ItemName_TextBox";
            this.ItemName_TextBox.Size = new System.Drawing.Size(172, 21);
            this.ItemName_TextBox.TabIndex = 6;
            // 
            // Expend_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Expend_Controls";
            this.Size = new System.Drawing.Size(491, 303);
            this.Load += new System.EventHandler(this.Expend_Controls_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Amount_NumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Remarks_TextBox;
        private System.Windows.Forms.DateTimePicker ExpendDate_DateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ExpendType_ComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Reason_TextBox;
        private System.Windows.Forms.NumericUpDown Amount_NumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ItemName_TextBox;
    }
}
