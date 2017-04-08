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
    public partial class Parameter_Name_Update_Form : BasicSettingsForm
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 参数名称逻辑代码
        /// </summary>
        public ParameterName_BLL ParameterName { get; set; }

        public Parameter_Name_Update_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            var entity = ParameterName.Get_Entity(Id);
            ParameterName.OriginalInfo(entity);
            parameter_Name_Controls1.ParameterName_Entity = entity;
            base.OnLoad(e);
        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Button_Click(object sender, EventArgs e)
        {
            var entity = parameter_Name_Controls1.ParameterName_Entity;
            if (ParameterName.RepeatVerify_Update(entity))
            {
                if (ParameterName.Update(entity) > -1)
                {
                    this.DialogResult = MessageBox.Show("更新参数名称成功!", "参数名称更新提示", MessageBoxButtons.OK);
                    this.Close();
                }
            }
            else
                MessageBox.Show(ParameterName.Messages, "参数名称更新提示");

        }
    }
}
