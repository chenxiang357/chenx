using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chenx.Log
{
    /// <summary>
    /// 日志接口
    /// </summary>
    public interface ILog : IDisposable
    {
        /// <summary>
        /// 操作结果
        /// </summary>
        string Result { get; set; }

        /// <summary>
        /// 执行结果描述
        /// </summary>
        string ResultsDescribed { get; set; }

        /// <summary>
        /// 用户登录名
        /// </summary>
        string Login_Name { get; set; }
    }
}
