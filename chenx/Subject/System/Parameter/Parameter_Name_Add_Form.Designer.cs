namespace chenx
{
    partial class Parameter_Name_Add_Form
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
            chenx.Model.ParameterName parameterName1 = new chenx.Model.ParameterName();
            this.parameter_Name_Controls1 = new chenx.UI.Parameter_Name_Controls();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Save_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // parameter_Name_Controls1
            // 
            this.parameter_Name_Controls1.Location = new System.Drawing.Point(7, 4);
            this.parameter_Name_Controls1.Name = "parameter_Name_Controls1";
            parameterName1.ConfigName = "";
            parameterName1.Id = 0;
            parameterName1.Memo = "";
            parameterName1.No = 1;
            this.parameter_Name_Controls1.ParameterName_Entity = parameterName1;
            this.parameter_Name_Controls1.Size = new System.Drawing.Size(312, 191);
            this.parameter_Name_Controls1.TabIndex = 0;
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(179, 196);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(75, 36);
            this.Close_Button.TabIndex = 2;
            this.Close_Button.Text = "关闭";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(74, 197);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 36);
            this.Save_Button.TabIndex = 2;
            this.Save_Button.Text = "保存";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Parameter_Name_Add_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 246);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.Close_Button);
            this.Controls.Add(this.parameter_Name_Controls1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Parameter_Name_Add_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "参数名称添加";
            this.ResumeLayout(false);

        }

        #endregion

        private UI.Parameter_Name_Controls parameter_Name_Controls1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Save_Button;
    }
}