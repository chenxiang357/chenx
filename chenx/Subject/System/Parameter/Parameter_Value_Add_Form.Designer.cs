namespace chenx
{
    partial class Parameter_Value_Add_Form
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
            chenx.Model.ParameterValue parameterValue1 = new chenx.Model.ParameterValue();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.parameter_Value_Controls1 = new chenx.UI.Parameter_Value_Controls();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(90, 237);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 36);
            this.Save_Button.TabIndex = 3;
            this.Save_Button.Text = "保存";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(195, 237);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 36);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Text = "关闭";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // parameter_Value_Controls1
            // 
            this.parameter_Value_Controls1.Location = new System.Drawing.Point(2, 1);
            this.parameter_Value_Controls1.Name = "parameter_Value_Controls1";
            this.parameter_Value_Controls1.Parameter_Name = "value";
            this.parameter_Value_Controls1.Parameter_Name_Id = 0;
            parameterValue1.Id = 0;
            parameterValue1.Memo = "";
            parameterValue1.No = 1;
            parameterValue1.P_Id = 0;
            parameterValue1.Value = "";
            this.parameter_Value_Controls1.ParameterValue_Entity = parameterValue1;
            this.parameter_Value_Controls1.Size = new System.Drawing.Size(326, 236);
            this.parameter_Value_Controls1.TabIndex = 0;
            // 
            // Parameter_Value_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 281);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.parameter_Value_Controls1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Parameter_Value_Add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数值添加";
            this.Load += new System.EventHandler(this.Parameter_Value_Add_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Parameter_Value_Controls parameter_Value_Controls1;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Close_Button;
    }
}