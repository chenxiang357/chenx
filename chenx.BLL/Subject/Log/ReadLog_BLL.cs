using chenx.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.BLL
{
    /// <summary>
    /// 读取日志
    /// </summary>
    public class ReadLog_BLL
    {

        /// <summary>
        /// 读取登录日志
        /// </summary>
        /// <param name="riqi">日期</param>
        /// <param name="loginName">登录用户</param>
        /// <returns></returns>
        public DataTable Read_Login_Log(DateTime riqi, string loginName)
        {
            Log_Login_DAL log_Login_DAL = new Log_Login_DAL();
            return log_Login_DAL.GetData(riqi, loginName).Tables[0];
        }

        /// <summary>
        /// 读取访问日志
        /// </summary>
        /// <param name="riqi">日期</param>
        /// <param name="loginName">登录用户</param>
        /// <returns></returns>
        public DataTable Read_Interview_Log(DateTime riqi, string loginName)
        {
            Log_Interview_DAL log_Interview_DAL = new Log_Interview_DAL();
            return log_Interview_DAL.GetData(riqi, loginName).Tables[0];
        }

        /// <summary>
        /// 读取操作日志
        /// </summary>
        /// <param name="riqi">日期</param>
        /// <param name="loginName">登录用户</param>
        /// <returns></returns>
        public DataTable Read_Operating_Log(DateTime riqi, string loginName)
        {
            Log_Operating_DAL log_Operating_DAL = new Log_Operating_DAL();
            return log_Operating_DAL.GetData(riqi, loginName).Tables[0];
        }

        /// <summary>
        /// 读取操作日志
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public DataTable Read_Operating_Log(int id, out DataTable log_Contents)
        {
            Log_Operating_DAL log_Operating_DAL = new Log_Operating_DAL();
            DataTable data = log_Operating_DAL.GetData(id, out log_Contents).Tables[0];
            return data;
        }

    }
}
