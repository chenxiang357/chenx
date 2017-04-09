using DatabaseOperating;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.Log
{
    /// <summary>
    /// 登录日志
    /// </summary>
    public class Log_Login_DAL : ILog_Login
    {
       
        public Log_Login_DAL()
        {
      
        }

        /// <summary>
        /// 用户登录名
        /// </summary>
        public string Login_Name { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
        public string Result { get; set; }

        /// <summary>
        /// 执行结果描述
        /// </summary>
        public string ResultsDescribed { get; set; }

        /// <summary>
        /// 生成日志
        /// </summary>
        public void Generatelog()
        {
            ICallDatabase dr = new CallDatabase_Log();
            dr.InitiCommand();
            dr.CommandText = @"insert into [Log_Login]([Login_Name],[Result],[ResultsDescribed],[Creation_Date])VALUES(@Login_Name,@Result,@ResultsDescribed,@Creation_Date)";
            dr.AddParameters("Login_Name", DbType.String, 50, Login_Name);
            dr.AddParameters("Result", DbType.String,20, Result);
            dr.AddParameters("ResultsDescribed", DbType.String, 140, ResultsDescribed);
            dr.AddParameters("Creation_Date", DbType.DateTime,  DateTime.Now);
            dr.ExecuteNonQuery();
            dr.Close();
            dr.Dispose();
        }


        #region 释放资源

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool m_disposed;

        protected virtual void Dispose(bool disposed)
        {
            //检查处置是否已经调用。
            if (!m_disposed)
            {
                //如果处置等于true，处置所有被管理
                //和非托管资源。
                if (disposed)
                {
                   // dr.Dispose();       //释放用户表的数据库访问
                }
                //非托管资源
                m_disposed = true;
            }
        }

        ~Log_Login_DAL()
        {
            Dispose(false);
        }

        #endregion



    }
}
