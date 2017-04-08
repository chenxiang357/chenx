namespace chenx
{
    partial class Parameter_Manage_Form
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.parameter_Name_Manage_Controls1 = new chenx.UI.Parameter_Name_Manage_Controls();
            this.parameter_Value_Manage_Controls1 = new chenx.UI.Parameter_Value_Manage_Controls();
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
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.parameter_Name_Manage_Controls1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.parameter_Value_Manage_Controls1);
            this.splitContainer1.Size = new System.Drawing.Size(853, 463);
            this.splitContainer1.SplitterDistance = 152;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // parameter_Name_Manage_Controls1
            // 
            this.parameter_Name_Manage_Controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameter_Name_Manage_Controls1.Location = new System.Drawing.Point(0, 0);
            this.parameter_Name_Manage_Controls1.Name = "parameter_Name_Manage_Controls1";
            this.parameter_Name_Manage_Controls1.SelectedNodes = null;
            this.parameter_Name_Manage_Controls1.Size = new System.Drawing.Size(152, 463);
            this.parameter_Name_Manage_Controls1.TabIndex = 0;
            this.parameter_Name_Manage_Controls1.AddClick += new System.EventHandler(this.Parameter_Name_Add_Click);
            // 
            // parameter_Value_Manage_Controls1
            // 
            this.parameter_Value_Manage_Controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parameter_Value_Manage_Controls1.Location = new System.Drawing.Point(0, 0);
            this.parameter_Value_Manage_Controls1.Name = "parameter_Value_Manage_Controls1";
            this.parameter_Value_Manage_Controls1.Size = new System.Drawing.Size(700, 463);
            this.parameter_Value_Manage_Controls1.TabIndex = 0;
            this.parameter_Value_Manage_Controls1.AddClick += new System.EventHandler(this.Parameter_Value_Add_Click);
            // 
            // Parameter_Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 463);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Parameter_Manage_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数管理";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private UI.Parameter_Name_Manage_Controls parameter_Name_Manage_Controls1;
        private UI.Parameter_Value_Manage_Controls parameter_Value_Manage_Controls1;
    }
}