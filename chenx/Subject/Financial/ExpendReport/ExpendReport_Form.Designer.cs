namespace chenx
{
    partial class ExpendReport_Form
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.expend_Year_Controls1 = new chenx.UI.Expend_Year_Controls();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.expend_Month_Controls1 = new chenx.UI.Expend_Month_Controls();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.expend_Day_Controls1 = new chenx.UI.Expend_Day_Controls();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(680, 402);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.expend_Year_Controls1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(672, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "年支出";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // expend_Year_Controls1
            // 
            this.expend_Year_Controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expend_Year_Controls1.Location = new System.Drawing.Point(3, 3);
            this.expend_Year_Controls1.Name = "expend_Year_Controls1";
            this.expend_Year_Controls1.Size = new System.Drawing.Size(666, 370);
            this.expend_Year_Controls1.TabIndex = 0;
            this.expend_Year_Controls1.Year_End = 2017;
            this.expend_Year_Controls1.Year_Start = 2016;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.expend_Month_Controls1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(672, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "月支出";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // expend_Month_Controls1
            // 
            this.expend_Month_Controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expend_Month_Controls1.Location = new System.Drawing.Point(3, 3);
            this.expend_Month_Controls1.Name = "expend_Month_Controls1";
            this.expend_Month_Controls1.Size = new System.Drawing.Size(666, 370);
            this.expend_Month_Controls1.TabIndex = 0;
            this.expend_Month_Controls1.Years = 2017;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.expend_Day_Controls1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(672, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "日支出";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // expend_Day_Controls1
            // 
            this.expend_Day_Controls1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expend_Day_Controls1.Location = new System.Drawing.Point(3, 3);
            this.expend_Day_Controls1.Month = 4;
            this.expend_Day_Controls1.Name = "expend_Day_Controls1";
            this.expend_Day_Controls1.Size = new System.Drawing.Size(666, 370);
            this.expend_Day_Controls1.TabIndex = 0;
            this.expend_Day_Controls1.Years = 2017;
            // 
            // ExpendReport_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 402);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpendReport_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "支出报表";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private UI.Expend_Year_Controls expend_Year_Controls1;
        private UI.Expend_Month_Controls expend_Month_Controls1;
        private UI.Expend_Day_Controls expend_Day_Controls1;
    }
}