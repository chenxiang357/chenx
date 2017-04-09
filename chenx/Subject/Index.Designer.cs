namespace chenx
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Main_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Exit_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Update_Info_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.menuControls1 = new chenx.UI.MenuControls();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.UserName_ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Main_ToolStripButton,
            this.Exit_ToolStripButton,
            this.toolStripSeparator1,
            this.Update_Info_ToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1077, 74);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Main_ToolStripButton
            // 
            this.Main_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Main_ToolStripButton.Image")));
            this.Main_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Main_ToolStripButton.Name = "Main_ToolStripButton";
            this.Main_ToolStripButton.Size = new System.Drawing.Size(54, 71);
            this.Main_ToolStripButton.Text = "首页";
            this.Main_ToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Main_ToolStripButton.Click += new System.EventHandler(this.Main_ToolStripButton_Click);
            // 
            // Exit_ToolStripButton
            // 
            this.Exit_ToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Exit_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Exit_ToolStripButton.Image")));
            this.Exit_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Exit_ToolStripButton.Name = "Exit_ToolStripButton";
            this.Exit_ToolStripButton.Size = new System.Drawing.Size(54, 71);
            this.Exit_ToolStripButton.Text = "退出";
            this.Exit_ToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Exit_ToolStripButton.Click += new System.EventHandler(this.Exit_ToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 74);
            // 
            // Update_Info_ToolStripButton
            // 
            this.Update_Info_ToolStripButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.Update_Info_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Update_Info_ToolStripButton.Image")));
            this.Update_Info_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Update_Info_ToolStripButton.Name = "Update_Info_ToolStripButton";
            this.Update_Info_ToolStripButton.Size = new System.Drawing.Size(60, 71);
            this.Update_Info_ToolStripButton.Text = "修改信息";
            this.Update_Info_ToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Update_Info_ToolStripButton.Click += new System.EventHandler(this.Update_Info_ToolStripButton_Click);
            // 
            // menuControls1
            // 
            this.menuControls1.Click_PopUp_Window = null;
            this.menuControls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControls1.Location = new System.Drawing.Point(0, 74);
            this.menuControls1.MenuJson = null;
            this.menuControls1.Name = "menuControls1";
            this.menuControls1.Size = new System.Drawing.Size(1077, 455);
            this.menuControls1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.UserName_ToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1077, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel1.Text = "当前用户:";
            // 
            // UserName_ToolStripStatusLabel
            // 
            this.UserName_ToolStripStatusLabel.Name = "UserName_ToolStripStatusLabel";
            this.UserName_ToolStripStatusLabel.Size = new System.Drawing.Size(131, 17);
            this.UserName_ToolStripStatusLabel.Text = "toolStripStatusLabel2";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 551);
            this.Controls.Add(this.menuControls1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "首页";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Index_FormClosing);
            this.Load += new System.EventHandler(this.Index_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Exit_ToolStripButton;
        private UI.MenuControls menuControls1;
        private System.Windows.Forms.ToolStripButton Main_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Update_Info_ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel UserName_ToolStripStatusLabel;
    }
}