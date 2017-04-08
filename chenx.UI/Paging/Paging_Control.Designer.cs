namespace chenx.UI
{
    partial class Paging_Control
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paging_Control));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.First_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Previous_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.PageIndex_ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.Total_ToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Next_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.Last_ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.First_ToolStripButton,
            this.Previous_ToolStripButton,
            this.toolStripSeparator1,
            this.PageIndex_ToolStripLabel,
            this.toolStripLabel2,
            this.Total_ToolStripLabel,
            this.toolStripSeparator2,
            this.Next_ToolStripButton,
            this.Last_ToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(774, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // First_ToolStripButton
            // 
            this.First_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.First_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("First_ToolStripButton.Image")));
            this.First_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.First_ToolStripButton.Name = "First_ToolStripButton";
            this.First_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.First_ToolStripButton.Text = "第一页";
            this.First_ToolStripButton.Click += new System.EventHandler(this.First_ToolStripButton_Click);
            // 
            // Previous_ToolStripButton
            // 
            this.Previous_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Previous_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Previous_ToolStripButton.Image")));
            this.Previous_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Previous_ToolStripButton.Name = "Previous_ToolStripButton";
            this.Previous_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Previous_ToolStripButton.Text = "上一页";
            this.Previous_ToolStripButton.Click += new System.EventHandler(this.Previous_ToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // PageIndex_ToolStripLabel
            // 
            this.PageIndex_ToolStripLabel.Name = "PageIndex_ToolStripLabel";
            this.PageIndex_ToolStripLabel.Size = new System.Drawing.Size(15, 22);
            this.PageIndex_ToolStripLabel.Text = "0";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(13, 22);
            this.toolStripLabel2.Text = "/";
            // 
            // Total_ToolStripLabel
            // 
            this.Total_ToolStripLabel.Name = "Total_ToolStripLabel";
            this.Total_ToolStripLabel.Size = new System.Drawing.Size(15, 22);
            this.Total_ToolStripLabel.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Next_ToolStripButton
            // 
            this.Next_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Next_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Next_ToolStripButton.Image")));
            this.Next_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Next_ToolStripButton.Name = "Next_ToolStripButton";
            this.Next_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Next_ToolStripButton.Text = "下一页";
            this.Next_ToolStripButton.Click += new System.EventHandler(this.Next_ToolStripButton_Click);
            // 
            // Last_ToolStripButton
            // 
            this.Last_ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Last_ToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("Last_ToolStripButton.Image")));
            this.Last_ToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Last_ToolStripButton.Name = "Last_ToolStripButton";
            this.Last_ToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.Last_ToolStripButton.Text = "最后一页";
            this.Last_ToolStripButton.Click += new System.EventHandler(this.Last_ToolStripButton_Click);
            // 
            // Paging_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Name = "Paging_Control";
            this.Size = new System.Drawing.Size(774, 25);
            this.Load += new System.EventHandler(this.Paging_Control_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton First_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Previous_ToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel PageIndex_ToolStripLabel;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripLabel Total_ToolStripLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Next_ToolStripButton;
        private System.Windows.Forms.ToolStripButton Last_ToolStripButton;
    }
}
