using chenx.BLL;
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
    public partial class Parameter_Value_Add_Form : Form
    {
        /// <summary>
        /// 参数值逻辑代码
        /// </summary>
        public ParameterValue_BLL ParameterValueBLL;

        /// <summary>
        /// 参数名称主键
        /// </summary>
        public int P_Id
        {
            set
            {
                parameter_Value_Controls1.Parameter_Name_Id = value;
            }
            get { return parameter_Value_Controls1.Parameter_Name_Id; }
        }

        /// <summary>
        /// 参数名称
        /// </summary>
        public string ParameterName
        {
            get
            {
                return parameter_Value_Controls1.Parameter_Name;
            }

            set
            {
                parameter_Value_Controls1.Parameter_Name = value;
            }
        }


        public Parameter_Value_Add_Form()
        {
            InitializeComponent();
        }

        private void Parameter_Value_Add_Form_Load(object sender, EventArgs e)
        {
            parameter_Value_Controls1.No_Load = ParameterValueBLL.GetNo(P_Id)+1;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Button_Click(object sender, EventArgs e)
        {
            var entity = parameter_Value_Controls1.ParameterValue_Entity;
            if (ParameterValueBLL.RepeatVerify_Add(entity))
            {
                if (ParameterValueBLL.Add(entity)>-1)
                {
                    this.DialogResult = MessageBox.Show("添加参数值!", "参数值提示", MessageBoxButtons.OK); //DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(ParameterValueBLL.Messages, "参数值提示");
            }
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
