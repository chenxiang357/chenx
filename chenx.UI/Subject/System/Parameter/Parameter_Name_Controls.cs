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
    public partial class Parameter_Name_Controls : UserControl
    {
        /// <summary>
        /// 参数名称实体
        /// </summary>
        private ParameterName _ParameterName_Entity;

        /// <summary>
        /// 参数名称实体
        /// </summary>
        public ParameterName ParameterName_Entity
        {
            get
            {
                if (_ParameterName_Entity==null)
                {
                    _ParameterName_Entity = new ParameterName();
                }
                _ParameterName_Entity.ConfigName = Parameter_Name_TextBox.Text;
                _ParameterName_Entity.No = Convert.ToInt32(No_NumericUpDown.Value);
                _ParameterName_Entity.Memo = Remarks_TextBox.Text;
                return _ParameterName_Entity;
            }

            set
            {
                
                if (value !=null)
                {
                    _ParameterName_Entity = value;
                    Parameter_Name_TextBox.Text = value.ConfigName;
                    No_NumericUpDown.Value = value.No;
                    Remarks_TextBox.Text = value.Memo;
                }
            }
        }

        /// <summary>
        /// 序号加载
        /// </summary>
        public int No_Load
        {
            set { No_NumericUpDown.Value = value; }
        }

        public Parameter_Name_Controls()
        {
            InitializeComponent();
        }

    }
}
