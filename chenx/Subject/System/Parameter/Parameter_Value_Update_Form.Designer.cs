namespace chenx
{
    partial class Parameter_Value_Update_Form
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
            chenx.Model.ParameterValue parameterValue5 = new chenx.Model.ParameterValue();
            this.parameter_Value_Controls1 = new chenx.UI.Parameter_Value_Controls();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parameter_Value_Controls1
            // 
            this.parameter_Value_Controls1.Location = new System.Drawing.Point(2, 2);
            this.parameter_Value_Controls1.Name = "parameter_Value_Controls1";
            this.parameter_Value_Controls1.Parameter_Name = "value";
            this.parameter_Value_Controls1.Parameter_Name_Id = 0;
            parameterValue5.Id = 0;
            parameterValue5.Memo = "";
            parameterValue5.No = 1;
            parameterValue5.P_Id = 0;
            parameterValue5.Value = "";
            this.parameter_Value_Controls1.ParameterValue_Entity = parameterValue5;
            this.parameter_Value_Controls1.Size = new System.Drawing.Size(348, 236);
            this.parameter_Value_Controls1.TabIndex = 0;
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(89, 233);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 36);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "保存";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(194, 233);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 36);
            this.Close_Button.TabIndex = 6;
            this.Close_Button.Text = "关闭";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Parameter_Value_Update_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 281);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.parameter_Value_Controls1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Parameter_Value_Update_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数值更新";
            this.Load += new System.EventHandler(this.Parameter_Value_Update_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Parameter_Value_Controls parameter_Value_Controls1;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Close_Button;
    }
}