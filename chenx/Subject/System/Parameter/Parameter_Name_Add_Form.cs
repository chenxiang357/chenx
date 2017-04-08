using chenx.BLL;
using chenx.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx
{
    public partial class Parameter_Name_Add_Form : BasicSettingsForm
    {
        /// <summary>
        /// 参数名称逻辑代码
        /// </summary>
         public ParameterName_BLL ParameterName { get; set; }

        public Parameter_Name_Add_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            parameter_Name_Controls1.No_Load = ParameterName.GetNo() + 1;
            base.OnLoad(e);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            var entity = parameter_Name_Controls1.ParameterName_Entity;
            if (ParameterName.RepeatVerify_Add(entity))
            {
                if (ParameterName.Add(entity) > -1)
                {
                    this.DialogResult = MessageBox.Show("添加参数成功!", "参数添加提示", MessageBoxButtons.OK); //DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(ParameterName.Messages, "参数添加提示");
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
