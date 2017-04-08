using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using chenx.Model;
using chenx.Log;

namespace chenx.DAL
{
    /// <summary>
    /// 参数值
    /// </summary>
    public class ParameterValue_DAL : IDisposable
    {
        private CallDatabase dr;

        public ParameterValue_DAL()
        {

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Add(ParameterValue entity)
        {
            try
            {
                entity.Status = "1";
                if (dr == null)
                    dr = new CallDatabase();
                dr.InitiCommand("insert into Sys_ParameterValue([P_Id],[Value],[No],[Memo])values(@P_Id,@Value,@No,@Memo);select @@identity");
                dr.AddParameters("P_Id", DbType.Int32, entity.P_Id);
                dr.AddParameters("Value", DbType.String, 60, entity.Value);
                dr.AddParameters("No", DbType.Int32, entity.No);
                dr.AddParameters("Memo", DbType.String, 300, entity.Memo);
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
        public int Update(ParameterValue entity)
        {
            if (dr == null)
                dr = new CallDatabase();

            dr.InitiCommand("Update Sys_ParameterValue set [Value]=@Value,[No]=@No,[Memo]=@Memo where [Id]=@Id");
            dr.AddParameters("Value", DbType.String, 60, entity.Value);
            dr.AddParameters("No", DbType.Int32, entity.No);
            dr.AddParameters("Memo", DbType.String, 300, entity.Memo);
            dr.AddParameters("Id", DbType.Int32, entity.Id);
            object value = dr.ExecuteNonQuery();
            dr.Close();
            return Convert.ToInt32(value);
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="status">状态(1为启用;0为禁用)</param>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public int UpdateStatus(string status, int id)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("Update Sys_ParameterValue set [Status]=@Status where [Id]=@Id");
            dr.AddParameters("Status", DbType.String, 10, status);
            dr.AddParameters("Id", DbType.Int32, id);
            int value = dr.ExecuteNonQuery();
            dr.Close();
            return value;
        }

        /// <summary>
        /// 根据主键查询数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public DataSet Get_SingleData(int id)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select * from [Sys_ParameterValue] where [Id]=@Id");
            dr.AddParameters("Id", DbType.Int32, id);
            DataSet data = dr.DataList();
            dr.Close();
            return data;
        }

        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="p_Id">Sys_ParameterName的主键</param>
        /// <returns></returns>
        public DataSet Get_Data(int p_Id)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select Id,Value,Memo,No,Status from Sys_ParameterValue  where [P_Id]=@P_Id order by [No]");
            dr.AddParameters("P_Id", DbType.Int32, p_Id);
            DataSet data = dr.DataList();
            dr.Close();
            return data;
        }

        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="configName">参数名称</param>
        /// <returns></returns>
        public DataSet Get_Data(string configName)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select * from Sys_ParameterValue v where exists(select 1 from Sys_ParameterName n where v.P_Id=n.Id and n.ConfigName=@ConfigName) order by [No]");
            dr.AddParameters("ConfigName", DbType.String, 50, configName);
            DataSet data= dr.DataList();
            dr.Close();
            return data;
        }


        /// <summary>
        /// 启用全部参数名称数据
        /// </summary>
        /// <param name="p_id">Sys_ParameterName的主键</param>
        /// <returns>返回数据集</returns>
        public DataSet Get_Enabled_Data(int p_id)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select [Id],[Value],[Memo],[No] from [Sys_ParameterValue] where [P_Id]=@P_Id and [Status]='1' order by [No] ");
            dr.AddParameters("P_Id", DbType.Int32, p_id);
            return dr.DataList();
        }

        /// <summary>
        /// 禁用全部参数名称数据
        /// </summary>
        /// <param name="p_id">Sys_ParameterName的主键</param>
        /// <returns>返回数据集</returns>
        public DataSet Get_Disabled_Data(int p_id)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select [Id],[Value],[Memo],[No] from [Sys_ParameterValue] where  [P_Id]=@P_Id and  [Status]='0' order by [No] ");
            dr.AddParameters("P_Id", DbType.Int32, p_id);
            return dr.DataList();
        }

        /// <summary>
        /// 获取最大的序号
        /// </summary>
        /// <param name="p_id">Sys_ParameterName的主键</param>
        /// <returns>返回最大的序号</returns>
        public int GetNo(int p_id)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select max([No]) from [Sys_ParameterValue]  where  [P_Id]=@P_Id ");
            dr.AddParameters("P_Id", DbType.Int32, p_id);
            object obj = dr.ExecuteScalar();
            if (obj.ToString() !="")
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

        ~ParameterValue_DAL()
        {
            Dispose(false);
        }

        #endregion

    }
}
