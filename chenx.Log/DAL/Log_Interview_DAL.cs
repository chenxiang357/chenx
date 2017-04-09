using DatabaseOperating;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.Log
{
    /// <summary>
    /// 访问日志
    /// </summary>
    public class Log_Interview_DAL :ILog_Interview
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        public string ModuleName { get; set; }

        private string _Result;

        /// <summary>
        /// 操作结果
        /// </summary>
        public string Result
        {
            get
            {
                if (_Result!=null && _Result.Length>0)
                {
                    return _Result;
                }
                return "成功";
            }
            set { _Result = value; }
        }

        /// <summary>
        /// 执行结果描述
        /// </summary>
        public string ResultsDescribed { get; set; }

        /// <summary>
        /// 用户登录名
        /// </summary>
        public string Login_Name { get; set; }

        /// <summary>
        /// 创建
        /// </summary>
        public void Generatelog()
        {
            ICallDatabase dr = new CallDatabase_Log();
            dr.InitiCommand();
            dr.CommandText = @"insert into [Log_Interview]([Login_Name],[ModuleName],[Result],[ResultsDescribed],[Creation_Date])VALUES(@Login_Name,@ModuleName,@Result,@ResultsDescribed,@Creation_Date)";
            dr.AddParameters("Login_Name", DbType.String, 50, Login_Name);
            dr.AddParameters("ModuleName", DbType.String, 50, ModuleName);
            dr.AddParameters("Result", DbType.String, 20, Result);
            dr.AddParameters("ResultsDescribed", DbType.String, 800, ResultsDescribed);
            dr.AddParameters("Creation_Date", DbType.DateTime, DateTime.Now);
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

        ~Log_Interview_DAL()
        {
            Dispose(false);
        }

        #endregion


    }
}
