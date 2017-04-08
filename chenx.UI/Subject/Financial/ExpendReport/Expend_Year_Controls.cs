using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using chenx.Model;

namespace chenx.UI
{
    public partial class Expend_Year_Controls : UserControl
    {
        /// <summary>
        /// 开始年份
        /// </summary>
        public int Year_Start { get; set; }

        /// <summary>
        /// 结束年份
        /// </summary>
        public int Year_End { get; set; }

        /// <summary>
        /// 参数值数据集
        /// </summary>
        public DataTable ParameterValue_Data
        {
            set
            {
                ParameterValue_ComboBox.Items.Add("请选择");
                foreach (DataRow item in value.Rows)
                {
                    ParameterValue_ComboBox.Items.Add(item["Value"].ToString());
                }
                ParameterValue_ComboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 返回参数值
        /// </summary>
        public string Get_ParameterValue
        {
            get { return ParameterValue_ComboBox.Text; }
        }

        /// <summary>
        /// 支出数据集
        /// </summary>
        public DataTable Data
        {
            set
            {
                chart1.DataSource = value;
                //设置图表Y轴对应项
                chart1.Series[0].YValueMembers = "Amount";
                //设置图表X轴对应项
                chart1.Series[0].XValueMember = "Year_Date";
                chart1.Series[0].IsValueShownAsLabel = true;
                //绑定数据
                chart1.DataBind();
            }
        }

        /// <summary>
        /// 查询事件
        /// </summary>
        public event EventHandler QueryClick;

        public Expend_Year_Controls()
        {
            InitializeComponent();
            Year_Start = DateTime.Now.AddYears(-1).Year;
            Year_End = DateTime.Now.Year;
            Assignment_ComboBox(Year_Start_ComboBox, Year_Start, Year_Start);
            Assignment_ComboBox(Year_End_ComboBox, Year_End, Year_End);
        }

        private void Expend_Year_Controls_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 给时间下拉列表赋值
        /// </summary>
        /// <param name="kj"></param>
        /// <param name="yaer">年</param>
        /// <param name="value">选中的值</param>
        private void Assignment_ComboBox(ComboBox kj, int yaer, int value)
        {
            kj.Items.Clear();
            for (int i = yaer - 3; i < yaer + 3; i++)
            {
                kj.Items.Add(i.ToString());
            }
            kj.Text = value.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Year_Start_ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            Year_Start = Convert.ToInt32(Year_Start_ComboBox.Text);
            Assignment_ComboBox(Year_Start_ComboBox, Year_Start, Year_Start);
        }

        private void Year_End_ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            Year_End = Convert.ToInt32(Year_End_ComboBox.Text);
            Assignment_ComboBox(Year_End_ComboBox, Year_End, Year_End);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InquireButton_Click(object sender, EventArgs e)
        {
            if (QueryClick!=null)
            {
                QueryClick(sender, e);
            }
        }
    }
}
