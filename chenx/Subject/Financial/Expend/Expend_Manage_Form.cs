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
    public partial class Expend_Manage_Form : BasicSettingsForm
    {
        public Expend_Manage_Form()
        {
            InitializeComponent();
        }

        private Expend_BLL Expend;

        /// <summary>
        /// 当前显示数量
        /// </summary>
        private int pageSize;

        /// <summary>
        /// 支付类型
        /// </summary>
        private DataTable Parameter_Data;

        protected override void OnLoad(EventArgs e)
        {
            pageSize = 50;
            ParameterValue_BLL parameterValue = new ParameterValue_BLL();
            Parameter_Data = parameterValue.Get_Data("支出类型");
            expend_Manage_Controls1.Binding_Parameter_Data = Parameter_Data;
            expend_Manage_Controls1.DataGridView_Update_Button = DataGridView_Update_Button;
            expend_Manage_Controls1.DataGridView_Delete_Button = DataGridView_Delete_Button;
            paging_Control1.Paging = BindingDataGridView;

            BindingDataGridView(1);
            Total_Amount();
            base.OnLoad(e);
        }

        /// <summary>
        /// 绑定数据集合
        /// </summary>
        private void BindingDataGridView(int pageIndex)
        {
            int pageCount;
            if (Expend == null)
                Expend = new Expend_BLL();

            expend_Manage_Controls1.Data = Expend.PagingData(pageIndex, out pageCount, pageSize, expend_Manage_Controls1.StartDate, 
                expend_Manage_Controls1.EndDate, expend_Manage_Controls1.ExpendType, expend_Manage_Controls1.ItemName, 
                expend_Manage_Controls1.Amount_1, expend_Manage_Controls1.Amount_2);

            //分页
            paging_Control1.Load_Paging_Info(pageIndex, pageCount, pageSize);
        }

        /// <summary>
        /// 总金额
        /// </summary>
        private void Total_Amount()
        {
            if (Expend == null)
                Expend = new Expend_BLL();
            expend_Manage_Controls1.Total_Amount = Expend.Get_Total_Amount(expend_Manage_Controls1.StartDate,
              expend_Manage_Controls1.EndDate, expend_Manage_Controls1.ExpendType, expend_Manage_Controls1.ItemName,
              expend_Manage_Controls1.Amount_1, expend_Manage_Controls1.Amount_2);
        }

        /// <summary>
        /// 添加支付
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Expend_Add_Click(object sender, EventArgs e)
        {
            Expend_Add_Form Add = new Expend_Add_Form();
            Add.Binding_Parameter_Data = Parameter_Data;
            if (Add.ShowDialog() == DialogResult.OK)
            {
                BindingDataGridView(1);
                Total_Amount();
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Expend_Query_Click(object sender, EventArgs e)
        {
            BindingDataGridView(1);
            Total_Amount();
        }

        /// <summary>
        /// 重置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Expend_Reset_Click(object sender, EventArgs e)
        {
            BindingDataGridView(1);
            Total_Amount();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="id">主键</param>
        private void DataGridView_Update_Button(string id)
        {
            Expend_Update_Form Update = new Expend_Update_Form();
            Update.Binding_Parameter_Data = Parameter_Data;
            Update.Id = id;
            if (Update.ShowDialog() == DialogResult.OK)
            {
                BindingDataGridView(paging_Control1.PageIndex);
                Total_Amount();
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        private void DataGridView_Delete_Button(string id)
        {
            if (MessageBox.Show("请确定要删除吗?", "删除提示", MessageBoxButtons.YesNo,MessageBoxIcon.Asterisk) == DialogResult.Yes)
            {
                if (Expend == null)
                    Expend = new Expend_BLL();

                if (Expend.Delete(int.Parse(id)) > -1)
                {
                    BindingDataGridView(1);
                    Total_Amount();
                }
            }
        }

    }
}
