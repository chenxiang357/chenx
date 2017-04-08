using chenx.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Model
{
    /// <summary>
    /// 账号接口
    /// </summary>
    public interface IAccountNumber
    {

        /// <summary>
        /// 实体列表
        /// </summary>
        List<AccountNumber> AccountNumber_Entity_List { get; set; }

        /// <summary>
        /// 实体
        /// </summary>
        AccountNumber AccountNumber_Entity { get; set; }
    }
}
