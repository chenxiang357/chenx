using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace chenx.DAL
{
    /// <summary>
    /// 分页
    /// </summary>
    public class Paging
    {
        private CallDatabase dr;

        public Paging()
        {
            dr = new CallDatabase();
            PageSize = 50;      //默认每页显示50条记录
            PageIndex = 1;      //默认当前页为第一页
            WhereString = "";   //默认是没有条件
        }

        // private readonly string StoredProcedures = "PROCE_PAGECHANGE";

        /// <summary>
        /// 表名
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 字段名(全部字段为*)
        /// </summary>
        public string ReFieldsStr { get; set; }

        /// <summary>
        /// 排序字段
        /// </summary>
        public string OrderString { get; set; }

        /// <summary>
        /// 条件语句(默认是没有条件)
        /// </summary>
        public string WhereString { get; set; }

        /// <summary>
        /// 条件语句 left join、right join、inner join 的条件
        /// </summary>
        public string OnString { get; set; }

        /// <summary>
        /// 每页多少条记录(默认每页显示50条记录)
        /// </summary>
        public int PageSize { get; set; }


        /// <summary>
        /// 指定当前为第几页(默认当前页为第一页)
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// 记录数据的总数
        /// </summary>
        public int PageCount { get; set; }

        /// <summary>
        /// 调用分页的存储过程
        /// </summary>
        /// <returns></returns>
        public DataSet GetData()
        {
            dr.InitiCommand();
            dr.CommandText = "PROCE_PAGECHANGE";
            dr.CommandType = CommandType.StoredProcedure;

            dr.AddParameters("TableName", DbType.String, 50, TableName);
            dr.AddParameters("ReFieldsStr", DbType.String, 200, ReFieldsStr);
            dr.AddParameters("OrderString", DbType.String, 200, OrderString);
            dr.AddParameters("WhereString", DbType.String, 500, WhereString);
            dr.AddParameters("OnString", DbType.String, 500, OnString);
            dr.AddParameters("PageSize", DbType.Int32, PageSize);
            dr.AddParameters("PageIndex", DbType.Int32, PageIndex);
            dr.AddParameters("TotalRecord", DbType.Int32, 1);
            DbParameter Value = dr.AddParametersDirection("PageCount", DbType.Int32);

            DataSet data = dr.DataList();//.SqlInquiry(StoredProcedures, parameters);
            PageCount = int.Parse(Value.Value.ToString());
            return data;
        }


        //调用方法
        //Paging p = new Paging();
        //p.TableName = "Infrastructure_Menu";
        //p.ReFieldsStr = "*";
        //p.PageSize = 5; 
        //p.OrderString = "MenuId";
        //DataTable dt = p.GetData().Tables[0];
        //if (dt.Rows.Count>0)
        //{
        //      foreach (DataRow item in dt.Rows)
        //      {
        //             Response.Write(item["DisplayName"] + ",");
        //      }
        //}


    }
}