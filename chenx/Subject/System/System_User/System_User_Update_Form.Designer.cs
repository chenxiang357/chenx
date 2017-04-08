namespace chenx
{
    partial class System_User_Update_Form
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
            chenx.Model.System_User system_User2 = new chenx.Model.System_User();
            this.system_User_Controls1 = new chenx.UI.System_User_Controls();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // system_User_Controls1
            // 
            this.system_User_Controls1.ConfirmPwd = "";
            this.system_User_Controls1.Location = new System.Drawing.Point(1, 1);
            this.system_User_Controls1.Name = "system_User_Controls1";
            this.system_User_Controls1.Size = new System.Drawing.Size(471, 308);
            this.system_User_Controls1.TabIndex = 0;
            system_User2.Id = 0;
            system_User2.IsAdmin = null;
            system_User2.LoginName = "";
            system_User2.Pwd = "";
            system_User2.Remarks = "";
            system_User2.UserName = "";
            this.system_User_Controls1.User_Entity = system_User2;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(259, 320);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 36);
            this.CloseButton.TabIndex = 22;
            this.CloseButton.Text = "关闭";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(119, 320);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 36);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // System_User_Update_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 368);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.system_User_Controls1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "System_User_Update_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户更新";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.System_User_Controls system_User_Controls1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
    }
}