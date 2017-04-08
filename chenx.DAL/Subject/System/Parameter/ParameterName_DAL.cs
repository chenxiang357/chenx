using chenx.Log;
using chenx.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.DAL
{
    /// <summary>
    /// 参数名称
    /// </summary>
    public class ParameterName_DAL : IDisposable
    {
        private CallDatabase dr;

        public ParameterName_DAL()
        {

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Add(ParameterName entity)
        {
            try
            {
                if (dr == null)
                    dr = new CallDatabase();
                entity.Status = "1";
                dr.InitiCommand("insert into Sys_ParameterName([ConfigName],[No],[Memo])values(@ConfigName,@No,@Memo);select @@identity");
                dr.AddParameters("ConfigName", DbType.String, 50, entity.ConfigName);
                dr.AddParameters("No", DbType.Int32, entity.No);
                dr.AddParameters("Memo", DbType.String, 250, entity.Memo);
                int value = Convert.ToInt32(dr.ExecuteScalar());
                entity.Id = value;
                dr.Close();
                return 0;
            }
            catch (Exception ex)
            {
                using (ILog_Error log = new Log_Error_Generate())
                {
                    log.Title = ex.Message;
                    log.Content = ex.StackTrace;
                    log.Generatelog();
                }
                return -1;
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Update(ParameterName entity)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("Update Sys_ParameterName set [ConfigName]=@ConfigName,[No]=@No,[Memo]=@Memo where [Id]=@Id ");
            dr.AddParameters("ConfigName", DbType.String, 50, entity.ConfigName);
            dr.AddParameters("No", DbType.Int32, entity.No);
            dr.AddParameters("Memo", DbType.String, 250, entity.Memo);
            dr.AddParameters("Id", DbType.Int32, entity.Id);
            int value = dr.ExecuteNonQuery();
            dr.Close();
            return value;
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="status">状态(1为启用;0为禁用)</param>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public int UpdateStatus(string status,int id)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("Update Sys_ParameterName set [Status]=@Status where [Id]=@Id");
            dr.AddParameters("Status", DbType.String, 10, status);
            dr.AddParameters("Id", DbType.Int32, id);
            int value = dr.ExecuteNonQuery();
            dr.Close();
            return value;
        }

        /// <summary>
        /// 获取全部参数名称数据
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Data()
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select [Id],[ConfigName],[Memo],[No],[Status] from [Sys_ParameterName] order by [No] ");
            return dr.DataList();
        }

        /// <summary>
        /// 启用全部参数名称数据
        /// </summary>
        /// <returns>返回数据集</returns>
        public DataSet Get_Enabled_Data()
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select [Id],[ConfigName],[Memo],[No] from [Sys_ParameterName] where [Status]='1' order by [No] ");
            return dr.DataList();
        }

        /// <summary>
        /// 禁用全部参数名称数据
        /// </summary>
        /// <returns>返回数据集</returns>
        public DataSet Get_Disabled_Data()
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select [Id],[ConfigName],[Memo],[No] from [Sys_ParameterName] where [Status]='0' order by [No] ");
            return dr.DataList();
        }

        /// <summary>
        /// 获取最大的序号
        /// </summary>
        /// <returns>返回最大的序号</returns>
        public int GetNo()
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select max([No]) from [Sys_ParameterName]");
            object obj = dr.ExecuteScalar();
            if (obj.ToString() != "")
            {
                return Convert.ToInt32(obj);
            }
            return 0;
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
                    dr.Dispose();       //释放用户表的数据库访问
                }
                //非托管资源
                m_disposed = true;
            }
        }

        ~ParameterName_DAL()
        {
            Dispose(false);
        }

        #endregion
    }
}
