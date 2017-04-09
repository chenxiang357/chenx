using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chenx.Log
{
    /// <summary>
    /// 错误日志
    /// </summary>
    public interface ILog_Error: IDisposable
    {
        /// <summary>
        /// 内容
        /// </summary>
        string Content { get; set; }
        
        /// <summary>
        /// 标题
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// 用户登录名
        /// </summary>
        string Login_Name { get; set; }

        /// <summary>
        /// 生成日志
        /// </summary>
        void Generatelog();

    }
}
