using chenx.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.BLL.Subject.Log
{
    public class Log_Operating_BLL
    {
        private Log_Operating_DAL log_Operating_DAL;

        public Log_Operating_BLL()
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
            if (log_Operating_DAL == null)
            {
                log_Operating_DAL = new Log_Operating_DAL();
            }

            return log_Operating_DAL.GetData(date, loginName);
        }

        /// <summary>
        /// 根据主键来获取数据集
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public DataSet GetData(int id, out DataTable log_Contents_Data)
        {
            if (log_Operating_DAL == null)
            {
                log_Operating_DAL = new Log_Operating_DAL();
            }

            return log_Operating_DAL.GetData(id, out log_Contents_Data);
        }
    }
}
