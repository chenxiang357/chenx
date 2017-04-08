using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Model
{
    /// <summary>
    /// 主菜单
    /// </summary>
    public class MainModule
    {
        /// <summary>
        /// 菜单ID
        /// </summary>
        public string MenuId { get; set; }

        /// <summary>
        /// 菜单名称
        /// </summary>
        public string MenuName { get; set; }

        /// <summary>
        /// 子模块列表
        /// </summary>
        public IList<SubModule> MenuList { get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        public int No { get; set;}
    }
}
