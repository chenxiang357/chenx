namespace chenx
{
    partial class Log_Error_Manage_Form
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
            this.log_Error_Manage_Controls1 = new chenx.UI.Log_Error_Manage_Controls();
            this.SuspendLayout();
            // 
            // log_Error_Manage_Controls1
            // 
            this.log_Error_Manage_Controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.log_Error_Manage_Controls1.Location = new System.Drawing.Point(0, 0);
            this.log_Error_Manage_Controls1.Name = "log_Error_Manage_Controls1";
            this.log_Error_Manage_Controls1.Size = new System.Drawing.Size(948, 494);
            this.log_Error_Manage_Controls1.TabIndex = 0;
            // 
            // Log_Error_Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 494);
            this.Controls.Add(this.log_Error_Manage_Controls1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log_Error_Manage_Form";
            this.Text = "错误日志";
            //this.Load += new System.EventHandler(this.Log_Error_Manage_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Log_Error_Manage_Controls log_Error_Manage_Controls1;
    }
}