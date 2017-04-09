using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chenx.Config
{
    /// <summary>
    /// 用户登录信息配置
    /// </summary>
    public class User_Login_Config
    {

        /// <summary>
        /// 用户Id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 是否管理员（1是，0不是）
        /// </summary>
        public string IsAdmin { get; set; }



    }
}
