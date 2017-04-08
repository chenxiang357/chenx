namespace chenx
{
    partial class Account_Manage_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chenx.Model.AccountNumber accountNumber1 = new chenx.Model.AccountNumber();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.account_Menu_Control1 = new chenx.UI.Account_Menu_Control();
            this.button2 = new System.Windows.Forms.Button();
            this.Show_Paw_Button = new System.Windows.Forms.Button();
            this.account_Control1 = new chenx.UI.Account_Control();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.account_Menu_Control1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.Show_Paw_Button);
            this.splitContainer1.Panel2.Controls.Add(this.account_Control1);
            this.splitContainer1.Size = new System.Drawing.Size(879, 503);
            this.splitContainer1.SplitterDistance = 184;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // account_Menu_Control1
            // 
            this.account_Menu_Control1.AccountNumber_Entity_List = null;
            this.account_Menu_Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.account_Menu_Control1.Location = new System.Drawing.Point(0, 0);
            this.account_Menu_Control1.Name = "account_Menu_Control1";
            this.account_Menu_Control1.Size = new System.Drawing.Size(184, 503);
            this.account_Menu_Control1.TabIndex = 0;
            this.account_Menu_Control1.AddClick += new System.EventHandler(this.Account_Add_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(519, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "打开地址";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Show_Paw_Button
            // 
            this.Show_Paw_Button.Location = new System.Drawing.Point(518, 137);
            this.Show_Paw_Button.Name = "Show_Paw_Button";
            this.Show_Paw_Button.Size = new System.Drawing.Size(62, 23);
            this.Show_Paw_Button.TabIndex = 1;
            this.Show_Paw_Button.Text = "显示密码";
            this.Show_Paw_Button.UseVisualStyleBackColor = true;
            this.Show_Paw_Button.Click += new System.EventHandler(this.Show_Paw_Button_Click);
            // 
            // account_Control1
            // 
            accountNumber1.AccountType = "";
            accountNumber1.CreatedDate = new System.DateTime(2017, 4, 3, 16, 21, 9, 106);
            accountNumber1.Description = "";
            accountNumber1.Id = "14b9218a7d3046afa10b3fa6469413cf";
            accountNumber1.LogName = "";
            accountNumber1.Name = "";
            accountNumber1.Paw = "";
            accountNumber1.RegistrationDate = new System.DateTime(2016, 11, 21, 0, 0, 0, 0);
            accountNumber1.Remarks = "";
            accountNumber1.UrlAddress = "";
            this.account_Control1.AccountNumber_Entity = accountNumber1;
            this.account_Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.account_Control1.Location = new System.Drawing.Point(0, 0);
            this.account_Control1.Name = "account_Control1";
            this.account_Control1.Size = new System.Drawing.Size(694, 503);
            this.account_Control1.TabIndex = 0;
            // 
            // Account_Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 503);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Account_Manage_Form";
            this.Text = "账号管理";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private UI.Account_Menu_Control account_Menu_Control1;
        private UI.Account_Control account_Control1;
        private System.Windows.Forms.Button Show_Paw_Button;
        private System.Windows.Forms.Button button2;
    }
}