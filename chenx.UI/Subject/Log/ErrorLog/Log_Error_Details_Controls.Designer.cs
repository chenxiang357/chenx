namespace chenx.UI
{
    partial class Log_Error_Details_Controls
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
            this.ErrorLogContentTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LogContentTextLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ErrorLogContentTextBox
            // 
            this.ErrorLogContentTextBox.AcceptsReturn = true;
            this.ErrorLogContentTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.ErrorLogContentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorLogContentTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorLogContentTextBox.Location = new System.Drawing.Point(111, 43);
            this.ErrorLogContentTextBox.Multiline = true;
            this.ErrorLogContentTextBox.Name = "ErrorLogContentTextBox";
            this.ErrorLogContentTextBox.ReadOnly = true;
            this.ErrorLogContentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorLogContentTextBox.Size = new System.Drawing.Size(763, 486);
            this.ErrorLogContentTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.Controls.Add(this.ErrorLogContentTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.LogContentTextLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 534);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // LogContentTextLabel
            // 
            this.LogContentTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogContentTextLabel.AutoSize = true;
            this.LogContentTextLabel.Location = new System.Drawing.Point(14, 49);
            this.LogContentTextLabel.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.LogContentTextLabel.Name = "LogContentTextLabel";
            this.LogContentTextLabel.Size = new System.Drawing.Size(89, 12);
            this.LogContentTextLabel.TabIndex = 2;
            this.LogContentTextLabel.Text = "错误信息内容：";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "错误信息标题：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 1;
            // 
            // Error_Log_Details_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Error_Log_Details_Controls";
            this.Size = new System.Drawing.Size(879, 534);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ErrorLogContentTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label LogContentTextLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
