using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Model
{
    /// <summary>
    /// 参数值
    /// </summary>
    public class ParameterValue
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Sys_ParameterName的主键
        /// </summary>
        public int P_Id { get; set; }

        /// <summary>
        /// 值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int No { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Memo { get; set; }

        /// <summary>
        /// 状态(1为启用;0为禁用)
        /// </summary>
        public string Status { get; set; }
    }
}
