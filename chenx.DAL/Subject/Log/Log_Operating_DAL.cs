using DatabaseOperating;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public class Log_Operating_DAL
    {
        /// <summary>
        /// 根据日期获取数据
        /// </summary>
        /// <param name="date">日期</param>
        /// <param name="loginName">登录用户</param>
        /// <returns></returns>
        public DataSet GetData(DateTime date, string loginName)
        {
            ICallDatabase dr = new CallDatabase();
            dr.InitiCommand();
            dr.CommandText = "select Id,Login_Name,ModuleName,OperationType,Result,ResultsDescribed,Creation_Date from [Log_Operating]  where DateDiff(day,Creation_Date, @Creation_Date)=0  And [Login_Name] like @Login_Name  order by [Creation_Date] desc";
            dr.AddParameters("Creation_Date", DbType.String, 20, date.ToString());
            dr.AddParameters("Login_Name", DbType.String, 50, "%" + loginName + "%");
            DataSet data = dr.DataList();
            dr.Close();
            dr.Dispose();
            return data;
        }

        /// <summary>
        /// 根据主键来获取数据集
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public DataSet GetData(int id, out DataTable log_Contents_Data)
        {
            log_Contents_Data = new DataTable();
            ICallDatabase dr = new CallDatabase();
            dr.InitiCommand();
            dr.CommandText = "select Login_Name,ModuleName,OperationType,Result,ResultsDescribed,Creation_Date from [Log_Operating] where Id=@Id ";
            dr.AddParameters("Id", DbType.Int32, id);
            DataSet data = dr.DataList();
            dr.CommandText = "select  Contents from [Log_Operating_Contents] where L_Id=@Id order by [No]";
            log_Contents_Data = dr.DataList().Tables[0];
            dr.Close();
            dr.Dispose();
            return data;
        }
    }
}
