using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chenx.Log
{
    /// <summary>
    /// 登录日志
    /// </summary>
    public interface ILog_Login : ILog
    {

        /// <summary>
        /// 生成日志
        /// </summary>
        void Generatelog();

    }

}
