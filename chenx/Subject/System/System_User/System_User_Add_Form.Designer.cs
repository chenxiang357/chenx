namespace chenx
{
    partial class System_User_Add_Form
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
            chenx.Model.System_User system_User1 = new chenx.Model.System_User();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.system_User_Controls2 = new chenx.UI.System_User_Controls();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(274, 317);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 36);
            this.CloseButton.TabIndex = 20;
            this.CloseButton.Text = "关闭";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(134, 317);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 36);
            this.SaveButton.TabIndex = 19;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // system_User_Controls2
            // 
            this.system_User_Controls2.ConfirmPwd = "";
            this.system_User_Controls2.Location = new System.Drawing.Point(0, 0);
            this.system_User_Controls2.Name = "system_User_Controls2";
            this.system_User_Controls2.Size = new System.Drawing.Size(471, 308);
            this.system_User_Controls2.TabIndex = 0;

            this.system_User_Controls2.User_Entity = system_User1;
            // 
            // System_User_Add_Form
            // 
            this.ClientSize = new System.Drawing.Size(472, 362);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.system_User_Controls2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "System_User_Add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户添加";
          
            this.ResumeLayout(false);

        }

        #endregion


        private UI.System_User_Controls system_User_Controls2;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
    }
}