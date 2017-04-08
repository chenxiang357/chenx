using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Model
{
    /// <summary>
    /// 支出
    /// </summary>
    public class Expend
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 支出日期
        /// </summary>
        public DateTime ExpendDate { get; set; }

        /// <summary>
        /// 年
        /// </summary>
        public string Year_Date { get; set; }

        /// <summary>
        /// 月
        /// </summary>
        public string Month_Date { get; set; }

        /// <summary>
        /// 日
        /// </summary>
        public int Day_Date { get; set; }

        /// <summary>
        /// 支出类型
        /// </summary>
        public string ExpendType { get; set; }

        /// <summary>
        /// 物品名称
        /// </summary>
        public string ItemName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public decimal Amount { get; set; }

        /// <summary>
        /// 原因
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }
    }
}
