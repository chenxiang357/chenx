using DatabaseOperating;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.Log
{
    /// <summary>
    /// 操作日志
    /// </summary>
    public class Log_Operating_DAL: ILog_Operating
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        public string ModuleName { get; set; }

        /// <summary>
        /// 操作类型(添加、更新、删除、禁用、启用、选择)
        /// </summary>
        public string OperationType { get; set; }

        /// <summary>
        /// 操作结果
        /// </summary>
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
                    if (Convert.ToInt32(_Result)>-1)
                    {
                        return "成功";
                    }
                }
                return "失败";
            }
            set
            {
                _Result = value;
            }
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
        /// 操作日志
        /// </summary>
        /// <param name="contents">日志内容</param>
        public void Generatelog(string contents)
        {
            ICallDatabase dr = new CallDatabase_Log();
            dr.InitiCommand();
            dr.CommandText = @"insert into [Log_Operating]([Login_Name],[ModuleName],[OperationType],[Result],[ResultsDescribed],[Creation_Date])
                                                    VALUES(@Login_Name,@ModuleName,@OperationType,@Result,@ResultsDescribed,@Creation_Date);select @@identity";
            dr.AddParameters("Login_Name", DbType.String, 50, Login_Name);
            dr.AddParameters("ModuleName", DbType.String, 50, ModuleName);
            dr.AddParameters("OperationType", DbType.String, 20, OperationType);
            dr.AddParameters("Result", DbType.String, 20, Result);
            dr.AddParameters("ResultsDescribed", DbType.String, 140, ResultsDescribed);
            dr.AddParameters("Creation_Date", DbType.DateTime, DateTime.Now);
            try
            {
                dr.BeginTransaction();
                int id = Convert.ToInt32(dr.ExecuteScalar());
                if (contents != null)
                {
                    dr.ParametersClear();
                    dr.CommandText = "insert into [Log_Operating_Contents]([L_Id],[Contents],[No])VALUES(@L_Id,@Contents,@No)";
                    dr.AddParameters("L_Id", DbType.Int32, id);
                    dr.AddParameters("Contents", DbType.String, 2000, contents);
                    dr.AddParameters("No", DbType.Int32, 1);
                    dr.ExecuteNonQuery();
                }
                dr.Commit();
            }
            catch (Exception ex)
            {
                dr.Rollback();
                using (ILog_Error log = new Log_Error_Generate())
                {
                    log.Title = ex.Message;
                    log.Content = ex.StackTrace;
                    log.Generatelog();
                }
            }
            finally
            {
                dr.Close();
                dr.Dispose();
            }
        }

        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="contents">日志内容数组</param>
        public void Generatelog(string[] contents)
        {
            ICallDatabase dr = new CallDatabase_Log();
            dr.InitiCommand();
            dr.CommandText = @"insert into [Log_Operating]([Login_Name],[ModuleName],[OperationType],[Result],[ResultsDescribed],[Creation_Date])
                                                    VALUES(@Login_Name,@ModuleName,@OperationType,@Result,@ResultsDescribed,@Creation_Date);select @@identity";
            dr.AddParameters("Login_Name", DbType.String, 50,Login_Name);
            dr.AddParameters("ModuleName", DbType.String, 50, ModuleName);
            dr.AddParameters("OperationType", DbType.String, 20, OperationType);
            dr.AddParameters("Result", DbType.String, 20, Result);
            dr.AddParameters("ResultsDescribed", DbType.String, 140, ResultsDescribed);
            dr.AddParameters("Creation_Date", DbType.DateTime, DateTime.Now);

            try
            {
                dr.BeginTransaction();
                int id = Convert.ToInt32(dr.ExecuteScalar());
                if (contents != null)
                {
                    dr.CommandText = "insert into [Log_Operating_Contents]([L_Id],[Contents],[No])VALUES(@L_Id,@Contents,@No)";
                    int i = 1;
                    foreach (var item in contents)
                    {
                        dr.ParametersClear();
                        dr.AddParameters("L_Id", DbType.Int32, id);
                        dr.AddParameters("Contents", DbType.String, 2000, item);
                        dr.AddParameters("No", DbType.Int32, i);
                        dr.ExecuteNonQuery();
                        i++;
                    }
                }
                dr.Commit();
            }
            catch (Exception ex)
            {
                dr.Rollback();
                using (ILog_Error log = new Log_Error_Generate())
                {
                    log.Title = ex.Message;
                    log.Content = ex.StackTrace;
                    log.Generatelog();
                }
            }
            finally
            {
                dr.Close();
                dr.Dispose();
            }
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

        ~Log_Operating_DAL()
        {
            Dispose(false);
        }

        #endregion

    }
}
