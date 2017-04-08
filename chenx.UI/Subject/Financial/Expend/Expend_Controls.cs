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
    public partial class Expend_Controls : UserControl
    {

        private Expend _Expend_Entity;

        /// <summary>
        /// 支出实体
        /// </summary>
        public Expend Expend_Entity
        {
            get
            {
                if (_Expend_Entity==null)
                {
                    _Expend_Entity = new Expend();
                }

                return Get_Entity(_Expend_Entity);
            }
            set
            {
                Set_Entity(value);
            }
        }

        /// <summary>
        /// 参数数据集
        /// </summary>
        public DataTable Binding_Parameter_Data
        {
            set
            {
                ExpendType_ComboBox.BindingData(value.Select("Status='1'").CopyToDataTable(), "Value");
            }
        }

        public Expend_Controls()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 返回实体
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        private Expend Get_Entity(Expend entity)
        {
            entity.ExpendDate = ExpendDate_DateTimePicker.Value;
            entity.Year_Date = ExpendDate_DateTimePicker.Value.Year.ToString();
            entity.Month_Date = ExpendDate_DateTimePicker.Value.Month.ToString();
            entity.Day_Date = ExpendDate_DateTimePicker.Value.Day;
            entity.ExpendType = ExpendType_ComboBox.SelectedValue.ToString();
            entity.ItemName = ItemName_TextBox.Text;
            entity.Amount = Amount_NumericUpDown.Value;
            entity.Reason = Reason_TextBox.Text;
            entity.Remarks = Remarks_TextBox.Text;
            return entity;
        }

        /// <summary>
        /// 实体赋值
        /// </summary>
        /// <param name="entity">实体</param>
        private void Set_Entity(Expend entity)
        {
            if (entity != null)
            {
                _Expend_Entity = entity;
                ExpendDate_DateTimePicker.Value = entity.ExpendDate;
                ExpendType_ComboBox.SelectedValue = entity.ExpendType;
                ItemName_TextBox.Text = entity.ItemName;
                Amount_NumericUpDown.Value = entity.Amount;
                Reason_TextBox.Text = entity.Reason;
                Remarks_TextBox.Text = entity.Remarks;
            }
        }

        private void Expend_Controls_Load(object sender, EventArgs e)
        {
     
            ExpendDate_DateTimePicker.Value = DateTime.Now;
        }
    }
}
