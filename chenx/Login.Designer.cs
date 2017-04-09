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
            this.Eixt_Button = new System.Windows.Forms.Button();
            this.SignIn_Button = new System.Windows.Forms.Button();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.System_Title_Label = new System.Windows.Forms.Label();
            this.UserName_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Eixt_Button
            // 
            this.Eixt_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Eixt_Button.Location = new System.Drawing.Point(311, 259);
            this.Eixt_Button.Name = "Eixt_Button";
            this.Eixt_Button.Size = new System.Drawing.Size(75, 37);
            this.Eixt_Button.TabIndex = 6;
            this.Eixt_Button.Text = "退出";
            this.Eixt_Button.UseVisualStyleBackColor = true;
            this.Eixt_Button.Click += new System.EventHandler(this.EixtButton_Click);
            // 
            // SignIn_Button
            // 
            this.SignIn_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignIn_Button.Location = new System.Drawing.Point(116, 259);
            this.SignIn_Button.Name = "SignIn_Button";
            this.SignIn_Button.Size = new System.Drawing.Size(75, 37);
            this.SignIn_Button.TabIndex = 5;
            this.SignIn_Button.Text = "登录";
            this.SignIn_Button.UseVisualStyleBackColor = true;
            this.SignIn_Button.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(187, 194);
            this.Password_TextBox.MaxLength = 28;
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(164, 21);
            this.Password_TextBox.TabIndex = 4;
            this.Password_TextBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "用户名：";
            // 
            // System_Title_Label
            // 
            this.System_Title_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.System_Title_Label.Font = new System.Drawing.Font("隶书", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.System_Title_Label.Location = new System.Drawing.Point(8, 61);
            this.System_Title_Label.Name = "System_Title_Label";
            this.System_Title_Label.Size = new System.Drawing.Size(507, 55);
            this.System_Title_Label.TabIndex = 0;
            this.System_Title_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserName_TextBox
            // 
            this.UserName_TextBox.Location = new System.Drawing.Point(187, 151);
            this.UserName_TextBox.Name = "UserName_TextBox";
            this.UserName_TextBox.Size = new System.Drawing.Size(164, 21);
            this.UserName_TextBox.TabIndex = 2;
            // 
            // Login
            // 
            this.AcceptButton = this.SignIn_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Eixt_Button;
            this.ClientSize = new System.Drawing.Size(527, 365);
            this.Controls.Add(this.UserName_TextBox);
            this.Controls.Add(this.System_Title_Label);
            this.Controls.Add(this.Eixt_Button);
            this.Controls.Add(this.SignIn_Button);
            this.Controls.Add(this.Password_TextBox);
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
        private System.Windows.Forms.Button Eixt_Button;
        private System.Windows.Forms.Button SignIn_Button;
        private System.Windows.Forms.TextBox Password_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label System_Title_Label;
        private System.Windows.Forms.TextBox UserName_TextBox;
    }
}