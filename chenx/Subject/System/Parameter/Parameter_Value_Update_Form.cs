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
    public partial class Parameter_Value_Update_Form : Form
    {

        public ParameterValue_BLL ParameterValueBLL;

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

        /// <summary>
        /// 参数值主键
        /// </summary>
        public int Id { get; set; }

        public Parameter_Value_Update_Form()
        {
            InitializeComponent();
        }


        private void Parameter_Value_Update_Form_Load(object sender, EventArgs e)
        {
            var entity = ParameterValueBLL.Get_Entity(Id);
            ParameterValueBLL.OriginalInfo(entity);
            parameter_Value_Controls1.ParameterValue_Entity = entity;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Button_Click(object sender, EventArgs e)
        {
            var entity = parameter_Value_Controls1.ParameterValue_Entity;

            if (ParameterValueBLL.RepeatVerify_Update(entity))
            {
                if (ParameterValueBLL.Update(entity) > -1)
                {
                    this.DialogResult = MessageBox.Show("更新参数值成功！", "参数值更新提示"); //DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show(ParameterValueBLL.Messages, "参数值提示");
            }
           
        }

        /// <summary>
        /// 关闭
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
