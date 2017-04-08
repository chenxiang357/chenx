using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Model
{
    /// <summary>
    /// 账号实体
    /// </summary>
    public class AccountNumber
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string UrlAddress { get; set; }

        /// <summary>
        /// 账号分类
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string LogName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        public string Paw { get; set; }

        /// <summary>
        /// 注册日期
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remarks { get; set; }

        ///// <summary>
        ///// 序号
        ///// </summary>
        //public int No { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreatedDate { get; set; }

    }

}
