namespace chenx.UI
{
    partial class System_User_Controls
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LoginName_TextBox = new System.Windows.Forms.TextBox();
            this.Pwd_TextBox = new System.Windows.Forms.TextBox();
            this.ConfirmPwd_TextBox = new System.Windows.Forms.TextBox();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Remarks_TextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.LoginName_TextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Pwd_TextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ConfirmPwd_TextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.UserName_TextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Remarks_TextBox, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(471, 308);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "确认密码：";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "用户姓名：";
            // 
            // LoginName_TextBox
            // 
            this.LoginName_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginName_TextBox.Location = new System.Drawing.Point(125, 8);
            this.LoginName_TextBox.MaxLength = 30;
            this.LoginName_TextBox.Name = "LoginName_TextBox";
            this.LoginName_TextBox.Size = new System.Drawing.Size(216, 21);
            this.LoginName_TextBox.TabIndex = 2;
            // 
            // Pwd_TextBox
            // 
            this.Pwd_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Pwd_TextBox.Location = new System.Drawing.Point(125, 45);
            this.Pwd_TextBox.MaxLength = 20;
            this.Pwd_TextBox.Name = "Pwd_TextBox";
            this.Pwd_TextBox.PasswordChar = '*';
            this.Pwd_TextBox.Size = new System.Drawing.Size(216, 21);
            this.Pwd_TextBox.TabIndex = 4;
            // 
            // ConfirmPwd_TextBox
            // 
            this.ConfirmPwd_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ConfirmPwd_TextBox.Location = new System.Drawing.Point(125, 82);
            this.ConfirmPwd_TextBox.MaxLength = 20;
            this.ConfirmPwd_TextBox.Name = "ConfirmPwd_TextBox";
            this.ConfirmPwd_TextBox.PasswordChar = '*';
            this.ConfirmPwd_TextBox.Size = new System.Drawing.Size(216, 21);
            this.ConfirmPwd_TextBox.TabIndex = 6;
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.UserName_TextBox.Location = new System.Drawing.Point(125, 119);
            this.UserName_TextBox.MaxLength = 7;
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(216, 21);
            this.UserName_TextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 9, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "备注：";
            // 
            // Remarks_TextBox
            // 
            this.Remarks_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Remarks_TextBox.Location = new System.Drawing.Point(125, 152);
            this.Remarks_TextBox.MaxLength = 200;
            this.Remarks_TextBox.Multiline = true;
            this.Remarks_TextBox.Name = "Remarks_TextBox";
            this.Remarks_TextBox.Size = new System.Drawing.Size(342, 152);
            this.Remarks_TextBox.TabIndex = 12;
            // 
            // System_User_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "System_User_Controls";
            this.Size = new System.Drawing.Size(471, 308);
            this.Load += new System.EventHandler(this.UserControls_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoginName_TextBox;
        private System.Windows.Forms.TextBox Pwd_TextBox;
        private System.Windows.Forms.TextBox ConfirmPwd_TextBox;
        private System.Windows.Forms.TextBox UserName_TextBox;
        private System.Windows.Forms.TextBox Remarks_TextBox;
    }
}
