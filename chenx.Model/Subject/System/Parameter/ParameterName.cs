using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Model
{
    /// <summary>
    /// 参数名称
    /// </summary>
    public class ParameterName
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        public string ConfigName { get; set; }

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
