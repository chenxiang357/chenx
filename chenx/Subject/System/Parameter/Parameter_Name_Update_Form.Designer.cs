namespace chenx
{
    partial class Parameter_Name_Update_Form
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
            chenx.Model.ParameterName parameterName2 = new chenx.Model.ParameterName();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.parameter_Name_Controls1 = new chenx.UI.Parameter_Name_Controls();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(74, 196);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 36);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "保存";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(179, 195);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 36);
            this.Close_Button.TabIndex = 4;
            this.Close_Button.Text = "关闭";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // parameter_Name_Controls1
            // 
            this.parameter_Name_Controls1.Location = new System.Drawing.Point(2, 2);
            this.parameter_Name_Controls1.Name = "parameter_Name_Controls1";
            parameterName2.ConfigName = "";
            parameterName2.Id = 0;
            parameterName2.Memo = "";
            parameterName2.No = 1;
            this.parameter_Name_Controls1.ParameterName_Entity = parameterName2;
            this.parameter_Name_Controls1.Size = new System.Drawing.Size(312, 191);
            this.parameter_Name_Controls1.TabIndex = 3;
            // 
            // Parameter_Name_Update_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 243);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.parameter_Name_Controls1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Parameter_Name_Update_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数名称更新";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Close_Button;
        private UI.Parameter_Name_Controls parameter_Name_Controls1;
    }
}