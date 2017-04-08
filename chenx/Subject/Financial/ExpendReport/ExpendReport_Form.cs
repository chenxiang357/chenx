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
    public partial class ExpendReport_Form : BasicSettingsForm
    {
        private Expend_BLL ExpendBLL;

        public ExpendReport_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            ParameterValue_BLL parameterValue = new ParameterValue_BLL();
            DataTable parameterValue_Data = parameterValue.Get_Data("支出类型");
            expend_Year_Controls1.ParameterValue_Data = parameterValue_Data;
            expend_Month_Controls1.ParameterValue_Data = parameterValue_Data;
            expend_Day_Controls1.ParameterValue_Data = parameterValue_Data;
            expend_Year_Controls1.QueryClick += QueryClick;
            expend_Month_Controls1.QueryClick += Month_QueryClick;
            expend_Day_Controls1.QueryClick += Day_QueryClick;
            ExpendBLL = new Expend_BLL();

            DoLoad_Year();
            DoLoad_Month();
            DoLoad_Day();
            base.OnLoad(e);
        }

        /// <summary>
        /// 加载年份
        /// </summary>
        void DoLoad_Year()
        {
            string type = "";
            if (expend_Year_Controls1.Get_ParameterValue != "请选择")
            {
                type = expend_Year_Controls1.Get_ParameterValue;
            }

            expend_Year_Controls1.Data = ExpendBLL.Get_Yaer_Data(expend_Year_Controls1.Year_Start, expend_Year_Controls1.Year_End, type);
        }

        /// <summary>
        /// 加载月份
        /// </summary>
        void DoLoad_Month()
        {
            string Month_type = "";
            if (expend_Month_Controls1.Get_ParameterValue != "请选择")
            {
                Month_type = expend_Month_Controls1.Get_ParameterValue;
            }
            expend_Month_Controls1.Data = ExpendBLL.Get_Month_Data(expend_Month_Controls1.Years, Month_type);
        }

        /// <summary>
        /// 加载天
        /// </summary>
        void DoLoad_Day()
        {
            string Day_type = "";
            if (expend_Day_Controls1.Get_ParameterValue != "请选择")
            {
                Day_type = expend_Day_Controls1.Get_ParameterValue;
            }
            expend_Day_Controls1.Data = ExpendBLL.Get_Day_Data(expend_Day_Controls1.Years, expend_Day_Controls1.Month, Day_type);
        }

        private void QueryClick(object sender, EventArgs e)
        {
            DoLoad_Year();
        }

        private void Month_QueryClick(object sender, EventArgs e)
        {
            DoLoad_Month();
        }

        private void Day_QueryClick(object sender, EventArgs e)
        {
            DoLoad_Day();
        }

    }
}
