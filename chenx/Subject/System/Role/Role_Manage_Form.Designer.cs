namespace chenx
{
    partial class Role_Manage_Form
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
            this.role_Manage_Controls1 = new chenx.UI.Role_Manage_Controls();
            this.SuspendLayout();
            // 
            // role_Manage_Controls1
            // 
            this.role_Manage_Controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.role_Manage_Controls1.Location = new System.Drawing.Point(0, 0);
            this.role_Manage_Controls1.Name = "role_Manage_Controls1";
            this.role_Manage_Controls1.Size = new System.Drawing.Size(732, 402);
            this.role_Manage_Controls1.TabIndex = 0;
            this.role_Manage_Controls1.AddClick += new System.EventHandler(this.AddToolStripButton_Click);
            // 
            // Role_Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 402);
            this.Controls.Add(this.role_Manage_Controls1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Role_Manage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Role_Manage_Form";
            this.Load += new System.EventHandler(this.Role_Manage_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Role_Manage_Controls role_Manage_Controls1;
    }
}