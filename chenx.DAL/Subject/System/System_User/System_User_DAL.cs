using chenx.Log;
using chenx.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.DAL
{
    public class System_User_DAL : IDisposable
    {
        private CallDatabase dr;

        public System_User_DAL()
        {

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Add(System_User entity)
        {
            try
            {
                if (dr == null)
                    dr = new CallDatabase();
                dr.InitiCommand("insert into Sys_User([LoginName],[Pwd],[UserName],[Remarks])values(@LoginName,@Pwd,@UserName,@Remarks);select @@identity");
                dr.AddParameters("LoginName", DbType.String, 30, entity.LoginName);
                dr.AddParameters("Pwd", DbType.String, 20, entity.Pwd);
                dr.AddParameters("UserName", DbType.String, 8, entity.UserName);
                dr.AddParameters("Remarks", DbType.String, 200, entity.Remarks);
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
        public int Update(System_User entity)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("Update Sys_User set [LoginName]=@LoginName,[Pwd]=@Pwd,[UserName]=@UserName,[Remarks]=@Remarks where [Id]=@Id ");
            dr.AddParameters("LoginName", DbType.String, 30, entity.LoginName);
            dr.AddParameters("Pwd", DbType.String, 20, entity.Pwd);
            dr.AddParameters("UserName", DbType.String, 8, entity.UserName);
            dr.AddParameters("Remarks", DbType.String, 200, entity.Remarks);
            dr.AddParameters("Id", DbType.Int32, entity.Id);
            int value = dr.ExecuteNonQuery();
            dr.Close();
            return value;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public int Delete(int id)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("delete from Sys_User where [Id]=@Id ");
            dr.AddParameters("Id", DbType.Int32, id);
            int value = dr.ExecuteNonQuery();
            dr.Close();
            return value;
        }

        /// <summary>
        /// 查询数据集
        /// </summary>
        /// <returns></returns>
        public DataSet Get_Data()
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select Id,LoginName,Pwd,UserName,Remarks,IsAdmin  from [Sys_User]");
            DataSet data = dr.DataList();
            dr.Close();
            return data;
        }

        /// <summary>
        /// 根据用户名来获取用户信息
        /// </summary>
        /// <param name="loginName">用户名</param>
        /// <returns></returns>
        public DataSet GetLoginInfo(string loginName)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand();
            dr.CommandText = "select * from Sys_User where [LoginName]=@LoginName";
            dr.AddParameters("LoginName", DbType.String, 30, loginName);
            var data = dr.DataList();
            dr.Close();
            return data;
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

        ~System_User_DAL()
        {
            Dispose(false);
        }

        #endregion
    }
}
