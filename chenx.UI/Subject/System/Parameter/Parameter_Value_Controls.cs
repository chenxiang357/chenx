using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chenx.Model;

namespace chenx.UI
{
    public partial class Parameter_Value_Controls : UserControl
    {
        /// <summary>
        /// 实体
        /// </summary>
        private ParameterValue _ParameterValue_Entity;

        /// <summary>
        /// 实体
        /// </summary>
        public ParameterValue ParameterValue_Entity
        {
            get
            {
                if (_ParameterValue_Entity == null)
                {
                    _ParameterValue_Entity = new ParameterValue();
                }
                _ParameterValue_Entity.P_Id = Parameter_Name_Id;
                _ParameterValue_Entity.Value = Parameter_Value_TextBox.Text;
                _ParameterValue_Entity.No = Convert.ToInt32(No_NumericUpDown.Value);
                _ParameterValue_Entity.Memo = Remarks_TextBox.Text;
                return _ParameterValue_Entity;
            }
            set
            {
                if (value != null)
                {
                    _ParameterValue_Entity = value;
                    Parameter_Value_TextBox.Text = value.Value;
                    No_NumericUpDown.Value = value.No;
                    Remarks_TextBox.Text = value.Memo;
                }
            }
        }

        /// <summary>
        /// 参数名称主键
        /// </summary>
        public int Parameter_Name_Id { get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        public string Parameter_Name
        {
            get { return Parameter_Name_Label.Text; }
            set
            {
                Parameter_Name_Label.Text = value;
            }
        }

        /// <summary>
        /// 序号加载
        /// </summary>
        public int No_Load
        {
            set { No_NumericUpDown.Value = value; }
        }

        public Parameter_Value_Controls()
        {
            InitializeComponent();
        }
    }
}
