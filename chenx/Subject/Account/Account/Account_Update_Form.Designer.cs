namespace chenx
{
    partial class Account_Update_Form
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
            chenx.Model.AccountNumber accountNumber2 = new chenx.Model.AccountNumber();
            this.Close_Button = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.account_Control1 = new chenx.UI.Account_Control();
            this.SuspendLayout();
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(343, 393);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 39);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Text = "关闭";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(167, 393);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 39);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // account_Control1
            // 
            accountNumber2.AccountType = "";
            accountNumber2.CreatedDate = new System.DateTime(2017, 1, 8, 18, 25, 52, 485);
            accountNumber2.Description = "";
            accountNumber2.Id = "60c79b6eb12a43ba80890c962f98c9fe";
            accountNumber2.LogName = "";
            accountNumber2.Name = "";
            accountNumber2.Paw = "";
            accountNumber2.RegistrationDate = new System.DateTime(2016, 11, 21, 0, 0, 0, 0);
            accountNumber2.Remarks = "";
            accountNumber2.UrlAddress = "";
            this.account_Control1.AccountNumber_Entity = accountNumber2;
            this.account_Control1.Location = new System.Drawing.Point(1, 1);
            this.account_Control1.Name = "account_Control1";
            this.account_Control1.Size = new System.Drawing.Size(590, 384);
            this.account_Control1.TabIndex = 2;
            // 
            // Account_Update_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 442);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.account_Control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Account_Update_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "账号更新";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button SaveButton;
        private UI.Account_Control account_Control1;
    }
}