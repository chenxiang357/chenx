using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chenx.Log
{
    /// <summary>
    /// 访问日志接口
    /// </summary>
    public interface ILog_Interview :ILog
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        string ModuleName { get; set; }

        /// <summary>
        /// 生成日志
        /// </summary>
        void Generatelog();
    }
}
