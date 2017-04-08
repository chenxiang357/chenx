namespace chenx
{
    partial class Login
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
            this.userNameComboBox = new System.Windows.Forms.ComboBox();
            this.EixtButton = new System.Windows.Forms.Button();
            this.SignInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.System_Title_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userNameComboBox
            // 
            this.userNameComboBox.FormattingEnabled = true;
            this.userNameComboBox.Items.AddRange(new object[] {
            "admin"});
            this.userNameComboBox.Location = new System.Drawing.Point(187, 151);
            this.userNameComboBox.Name = "userNameComboBox";
            this.userNameComboBox.Size = new System.Drawing.Size(164, 20);
            this.userNameComboBox.TabIndex = 8;
            // 
            // EixtButton
            // 
            this.EixtButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.EixtButton.Location = new System.Drawing.Point(311, 259);
            this.EixtButton.Name = "EixtButton";
            this.EixtButton.Size = new System.Drawing.Size(75, 37);
            this.EixtButton.TabIndex = 11;
            this.EixtButton.Text = "退出";
            this.EixtButton.UseVisualStyleBackColor = true;
            this.EixtButton.Click += new System.EventHandler(this.EixtButton_Click);
            // 
            // SignInButton
            // 
            this.SignInButton.Location = new System.Drawing.Point(116, 259);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.Size = new System.Drawing.Size(75, 37);
            this.SignInButton.TabIndex = 10;
            this.SignInButton.Text = "登录";
            this.SignInButton.UseVisualStyleBackColor = true;
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(187, 194);
            this.passwordTextBox.MaxLength = 28;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(164, 21);
            this.passwordTextBox.TabIndex = 9;
            this.passwordTextBox.Text = "123";
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户名：";
            // 
            // System_Title_Label
            // 
            this.System_Title_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.System_Title_Label.Font = new System.Drawing.Font("隶书", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.System_Title_Label.Location = new System.Drawing.Point(8, 68);
            this.System_Title_Label.Name = "System_Title_Label";
            this.System_Title_Label.Size = new System.Drawing.Size(507, 55);
            this.System_Title_Label.TabIndex = 12;
            this.System_Title_Label.Text = "222";
            this.System_Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 365);
            this.Controls.Add(this.System_Title_Label);
            this.Controls.Add(this.userNameComboBox);
            this.Controls.Add(this.EixtButton);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userNameComboBox;
        private System.Windows.Forms.Button EixtButton;
        private System.Windows.Forms.Button SignInButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label System_Title_Label;
    }
}