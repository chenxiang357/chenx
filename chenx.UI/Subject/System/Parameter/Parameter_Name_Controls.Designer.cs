namespace chenx.UI
{
    partial class Parameter_Name_Controls
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
            this.label1 = new System.Windows.Forms.Label();
            this.Parameter_Name_TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.No_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Remarks_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.No_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "参数名称：";
            // 
            // Parameter_Name_TextBox
            // 
            this.Parameter_Name_TextBox.Location = new System.Drawing.Point(73, 7);
            this.Parameter_Name_TextBox.MaxLength = 50;
            this.Parameter_Name_TextBox.Name = "Parameter_Name_TextBox";
            this.Parameter_Name_TextBox.Size = new System.Drawing.Size(229, 21);
            this.Parameter_Name_TextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "序号：";
            // 
            // No_NumericUpDown
            // 
            this.No_NumericUpDown.Location = new System.Drawing.Point(73, 45);
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
            this.No_NumericUpDown.TabIndex = 3;
            this.No_NumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "备注：";
            // 
            // Remarks_TextBox
            // 
            this.Remarks_TextBox.Location = new System.Drawing.Point(73, 84);
            this.Remarks_TextBox.MaxLength = 200;
            this.Remarks_TextBox.Multiline = true;
            this.Remarks_TextBox.Name = "Remarks_TextBox";
            this.Remarks_TextBox.Size = new System.Drawing.Size(229, 98);
            this.Remarks_TextBox.TabIndex = 5;
            // 
            // Parameter_Name_Controls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Remarks_TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.No_NumericUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Parameter_Name_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "Parameter_Name_Controls";
            this.Size = new System.Drawing.Size(308, 189);
            ((System.ComponentModel.ISupportInitialize)(this.No_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Parameter_Name_TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown No_NumericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Remarks_TextBox;
    }
}
