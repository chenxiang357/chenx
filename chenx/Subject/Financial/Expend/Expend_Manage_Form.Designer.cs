namespace chenx
{
    partial class Expend_Manage_Form
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
            this.expend_Manage_Controls1 = new chenx.UI.Expend_Manage_Controls();
            this.paging_Control1 = new chenx.UI.Paging_Control();
            this.SuspendLayout();
            // 
            // expend_Manage_Controls1
            // 
            this.expend_Manage_Controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expend_Manage_Controls1.Location = new System.Drawing.Point(0, 0);
            this.expend_Manage_Controls1.Name = "expend_Manage_Controls1";
            this.expend_Manage_Controls1.Size = new System.Drawing.Size(806, 427);
            this.expend_Manage_Controls1.TabIndex = 0;
            this.expend_Manage_Controls1.AddClick += new System.EventHandler(this.Expend_Add_Click);
            this.expend_Manage_Controls1.QueryClick += new System.EventHandler(this.Expend_Query_Click);
            this.expend_Manage_Controls1.ResetClick += new System.EventHandler(this.Expend_Reset_Click);
            // 
            // paging_Control1
            // 
            this.paging_Control1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paging_Control1.Location = new System.Drawing.Point(0, 427);
            this.paging_Control1.Name = "paging_Control1";
            this.paging_Control1.Size = new System.Drawing.Size(806, 25);
            this.paging_Control1.TabIndex = 1;
            // 
            // Expend_Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 452);
            this.Controls.Add(this.expend_Manage_Controls1);
            this.Controls.Add(this.paging_Control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Expend_Manage_Form";
            this.Text = "支出管理";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Expend_Manage_Controls expend_Manage_Controls1;
        private UI.Paging_Control paging_Control1;
    }
}