namespace chenx.UI
{
    partial class Parameter_Value_Controls
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
            this.Remarks_TextBox = new System.Windows.Forms.TextBox();
            this.Parameter_Name_Label = new System.Windows.Forms.Label();
            this.No_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Parameter_Value_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.No_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Remarks_TextBox
            // 
            this.Remarks_TextBox.Location = new System.Drawing.Point(82, 117);
            this.Remarks_TextBox.MaxLength = 200;
            this.Remarks_TextBox.Multiline = true;
            this.Remarks_TextBox.Name = "Remarks_TextBox";
            this.Remarks_TextBox.Size = new System.Drawing.Size(229, 98);
            this.Remarks_TextBox.TabIndex = 11;
            // 
            // Parameter_Name_Label
            // 
            this.Parameter_Name_Label.AutoSize = true;
            this.Parameter_Name_Label.Location = new System.Drawing.Point(85, 21);
            this.Parameter_Name_Label.Name = "Parameter_Name_Label";
            this.Parameter_Name_Label.Size = new System.Drawing.Size(35, 12);
            this.Parameter_Name_Label.TabIndex = 10;
            this.Parameter_Name_Label.Text = "value";
            // 
            // No_NumericUpDown
            // 
            this.No_NumericUpDown.Location = new System.Drawing.Point(82, 82);
            this.No_NumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.No_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.No_NumericUpDown.Name = "No_NumericUpDown";
            this.No_NumericUpDown.Size = new System.Drawing.Size(152, 21);
            this.No_NumericUpDown.TabIndex = 9;
            this.No_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "序号：";
            // 
            // Parameter_Value_TextBox
            // 
            this.Parameter_Value_TextBox.Location = new System.Drawing.Point(82, 46);
            this.Parameter_Value_TextBox.MaxLength = 50;
            this.Parameter_Value_TextBox.Name = "Parameter_Value_TextBox";
            this.Parameter_Value_TextBox.Size = new System.Drawing.Size(229, 21);
            this.Parameter_Value_TextBox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "参数名称：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "参数值：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "备份：";
            // 
            // Parameter_Value_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Remarks_TextBox);
            this.Controls.Add(this.Parameter_Name_Label);
            this.Controls.Add(this.No_NumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Parameter_Value_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Parameter_Value_Controls";
            this.Size = new System.Drawing.Size(348, 236);
            ((System.ComponentModel.ISupportInitialize)(this.No_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Remarks_TextBox;
        private System.Windows.Forms.Label Parameter_Name_Label;
        private System.Windows.Forms.NumericUpDown No_NumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Parameter_Value_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
