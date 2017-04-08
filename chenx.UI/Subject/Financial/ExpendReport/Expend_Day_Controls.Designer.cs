namespace chenx.UI
{
    partial class Expend_Day_Controls
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.InquireButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ParameterValue_ComboBox = new System.Windows.Forms.ComboBox();
            this.Month_ComboBox = new System.Windows.Forms.ComboBox();
            this.Years_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.InquireButton);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.ParameterValue_ComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.Month_ComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.Years_ComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.chart1);
            this.splitContainer1.Size = new System.Drawing.Size(628, 353);
            this.splitContainer1.SplitterDistance = 35;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // InquireButton
            // 
            this.InquireButton.Location = new System.Drawing.Point(264, 7);
            this.InquireButton.Name = "InquireButton";
            this.InquireButton.Size = new System.Drawing.Size(75, 23);
            this.InquireButton.TabIndex = 4;
            this.InquireButton.Text = "查询";
            this.InquireButton.UseVisualStyleBackColor = true;
            this.InquireButton.Click += new System.EventHandler(this.InquireButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 3;
            // 
            // ParameterValue_ComboBox
            // 
            this.ParameterValue_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ParameterValue_ComboBox.FormattingEnabled = true;
            this.ParameterValue_ComboBox.Location = new System.Drawing.Point(175, 8);
            this.ParameterValue_ComboBox.Name = "ParameterValue_ComboBox";
            this.ParameterValue_ComboBox.Size = new System.Drawing.Size(87, 20);
            this.ParameterValue_ComboBox.TabIndex = 1;
            // 
            // Month_ComboBox
            // 
            this.Month_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Month_ComboBox.FormattingEnabled = true;
            this.Month_ComboBox.Location = new System.Drawing.Point(123, 8);
            this.Month_ComboBox.Name = "Month_ComboBox";
            this.Month_ComboBox.Size = new System.Drawing.Size(49, 20);
            this.Month_ComboBox.TabIndex = 1;
            this.Month_ComboBox.DropDownClosed += new System.EventHandler(this.Month_ComboBox_DropDownClosed);
            // 
            // Years_ComboBox
            // 
            this.Years_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Years_ComboBox.FormattingEnabled = true;
            this.Years_ComboBox.Location = new System.Drawing.Point(40, 8);
            this.Years_ComboBox.Name = "Years_ComboBox";
            this.Years_ComboBox.Size = new System.Drawing.Size(49, 20);
            this.Years_ComboBox.TabIndex = 1;
            this.Years_ComboBox.DropDownClosed += new System.EventHandler(this.Years_ComboBox_DropDownClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "年份：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "月份：";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "金额(元)";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(628, 317);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Expend_Day_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "Expend_Day_Controls";
            this.Size = new System.Drawing.Size(628, 353);
            this.Load += new System.EventHandler(this.Expend_Day_Controls_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button InquireButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ParameterValue_ComboBox;
        private System.Windows.Forms.ComboBox Month_ComboBox;
        private System.Windows.Forms.ComboBox Years_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
