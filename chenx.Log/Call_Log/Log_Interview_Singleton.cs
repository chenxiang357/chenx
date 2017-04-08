using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Log
{
    /// <summary>
    /// 访问日志单列模式
    /// </summary>
    public sealed class Log_Interview_Singleton
    {
        private Log_Interview_Singleton()
        {

        }

        public static readonly ILog_Interview Instance = new Log_Interview_DAL();
    }
}
