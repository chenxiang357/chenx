using chenx.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.BLL
{
    public class Log_Interview_BLL
    {

        private Log_Interview_DAL log_Interview_DAL;

        public Log_Interview_BLL()
        {

        }


        /// <summary>
        /// 根据日期获取数据
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="loginName">登录用户</param>
        /// <returns></returns>
        public DataSet GetData(DateTime date, string loginName)
        {
            if (log_Interview_DAL==null)
            {
                log_Interview_DAL = new Log_Interview_DAL();
            }

            return log_Interview_DAL.GetData(date, loginName);
        }
    }
}
