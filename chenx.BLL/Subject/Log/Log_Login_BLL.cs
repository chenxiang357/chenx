using chenx.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.BLL
{
    /// <summary>
    /// 登录逻辑代码
    /// </summary>
    public class Log_Login_BLL
    {
        private Log_Login_DAL log_Login_DAL;

        /// <summary>
        /// 根据日期获取数据
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="loginName">登录用户</param>
        /// <returns></returns>
        public DataTable GetData(DateTime date, string loginName)
        {
            if (log_Login_DAL == null)
            {
                log_Login_DAL = new Log_Login_DAL();
            }
            return log_Login_DAL.GetData(date, loginName).Tables[0];
        }
    }
}
