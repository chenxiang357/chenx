namespace chenx
{
    partial class System_User_Manage_Form
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
            this.system_User_Manage_Controls1 = new chenx.UI.System_User_Manage_Controls();
            this.SuspendLayout();
            // 
            // system_User_Manage_Controls1
            // 
            this.system_User_Manage_Controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.system_User_Manage_Controls1.Location = new System.Drawing.Point(0, 0);
            this.system_User_Manage_Controls1.Name = "system_User_Manage_Controls1";
            this.system_User_Manage_Controls1.Size = new System.Drawing.Size(829, 493);
            this.system_User_Manage_Controls1.TabIndex = 0;
            this.system_User_Manage_Controls1.InquireClick += new System.EventHandler(this.InquireClick);
            this.system_User_Manage_Controls1.ResetClick += new System.EventHandler(this.ResetClick);
            this.system_User_Manage_Controls1.AddClick += new System.EventHandler(this.System_User_Manage_Add_Click);
            // 
            // System_User_Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 493);
            this.Controls.Add(this.system_User_Manage_Controls1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "System_User_Manage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.System_User_Manage_Controls system_User_Manage_Controls1;
    }
}