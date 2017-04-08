using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Model
{
    /// <summary>
    /// 子菜单
    /// </summary>
    public class SubModule
    {
        /// <summary>
        /// 模块ID
        /// </summary>
        public string ModuleId { get; set; }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string ModuleName { get; set; }

        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImagesUrl { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int No { get; set; }
    }
}
