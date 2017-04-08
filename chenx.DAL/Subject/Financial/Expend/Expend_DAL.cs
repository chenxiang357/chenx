using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chenx.Model;
using System.Data;
using chenx.Log;

namespace chenx.DAL
{

    public class Expend_DAL : IDisposable
    {
        private CallDatabase dr;

        public Expend_DAL()
        {

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Add(Expend entity)
        {
            if (dr == null)
                dr = new CallDatabase();
            int value = -1;
            try
            {
                dr.InitiCommand("insert into Expend([ExpendDate],[Year_Date],[Month_Date],[Day_Date],[ExpendType],[ItemName],[Amount],[Reason],[Remarks])values(@ExpendDate,@Year_Date,@Month_Date,@Day_Date,@ExpendType,@ItemName,@Amount,@Reason,@Remarks);SELECT @@IDENTITY;");
                dr.AddParameters("ExpendDate", DbType.DateTime, entity.ExpendDate);
                dr.AddParameters("Year_Date", DbType.String, 20, entity.Year_Date);
                dr.AddParameters("Month_Date", DbType.String, 20, entity.Month_Date);
                dr.AddParameters("Day_Date", DbType.Int32, entity.Day_Date);
                dr.AddParameters("ExpendType", DbType.String, 50, entity.ExpendType);
                dr.AddParameters("ItemName", DbType.String, 72, entity.ItemName);
                dr.AddParameters("Amount", DbType.Decimal, entity.Amount);
                dr.AddParameters("Reason", DbType.String, 250, entity.Reason);
                dr.AddParameters("Remarks", DbType.String, 500, entity.Remarks);
                object id = dr.ExecuteScalar();
                entity.Id = Convert.ToInt32(id);
                value = 1;
            }
            catch (Exception ex)
            {
                using (ILog_Error log = new Log_Error_Generate())
                {
                    log.Title = ex.Message;
                    log.Content = ex.StackTrace;
                    log.Generatelog();
                }
                value = -1;
            }
            return value;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Update(Expend entity)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("Update Expend set [ExpendDate]=@ExpendDate,[Year_Date]=@Year_Date,[Month_Date]=@Month_Date,[Day_Date]=@Day_Date,[ExpendType]=@ExpendType,[ItemName]=@ItemName,[Amount]=@Amount,[Reason]=@Reason,[Remarks]=@Remarks where  [Id]=@Id ");
            dr.AddParameters("ExpendDate", DbType.DateTime, entity.ExpendDate);
            dr.AddParameters("Year_Date", DbType.String, 20, entity.Year_Date);
            dr.AddParameters("Month_Date", DbType.String, 20, entity.Month_Date);
            dr.AddParameters("Day_Date", DbType.Int32, entity.Day_Date);
            dr.AddParameters("ExpendType", DbType.String, 50, entity.ExpendType);
            dr.AddParameters("ItemName", DbType.String, 72, entity.ItemName);
            dr.AddParameters("Amount", DbType.Decimal, entity.Amount);
            dr.AddParameters("Reason", DbType.String, 250, entity.Reason);
            dr.AddParameters("Remarks", DbType.String, 500, entity.Remarks);
            dr.AddParameters("Id", DbType.Int32, entity.Id);
            return dr.ExecuteNonQuery();
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
            dr.InitiCommand("delete from [Expend] where  [Id]=@Id ");
            dr.AddParameters("Id", DbType.Int32, id);
            return dr.ExecuteNonQuery();
        }

        /// <summary>
        /// 根据主键查询数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回数据集</returns>
        public DataSet Get_Data(int id)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand("select Id,ExpendDate,ExpendType,ItemName,Amount,Reason,Remarks from [Expend] where [Id]=@Id ");
            dr.AddParameters("Id", DbType.Int32, id);
            return dr.DataList();
        }

        /// <summary>
        /// 获取年的数据
        /// </summary>
        /// <param name="startDate">开始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <param name="expendtype">类型</param>
        /// <returns></returns>
        public DataSet Get_Yaer_Data(int startDate, int endDate, string expendtype)
        {
            if (dr == null)
                dr = new CallDatabase();
            string sql = "select Year_Date, SUM(Amount) AS Amount from [Expend] where (Year_Date BETWEEN @StartDate AND @EndDate)  ";
            if (expendtype.Length>0)
            {
                sql = sql + " and [ExpendType]=@ExpendType ";
            }
            sql = sql + " GROUP BY Year_Date";
            dr.InitiCommand(sql);
            dr.AddParameters("StartDate", DbType.Int32, startDate);
            dr.AddParameters("EndDate", DbType.Int32, endDate);
            if (expendtype.Length > 0)
            {
                dr.AddParameters("ExpendType", DbType.String, 50, expendtype);
            }
            return dr.DataList();
        }

        /// <summary>
        /// 获取月的数据
        /// </summary>
        /// <param name="yaers">年份</param>
        /// <param name="expendtype">类型</param>
        /// <returns></returns>
        public DataSet Get_Month_Data(int yaers,  string expendtype)
        {
            if (dr == null)
                dr = new CallDatabase();
            string sql = "select Month_Date,SUM(Amount) AS Amount from [Expend] where [Year_Date]=@Years ";
            if (expendtype.Length > 0)
            {
                sql = sql + " and [ExpendType]=@ExpendType ";
            }
            sql = sql + " GROUP BY Month_Date";
            dr.InitiCommand(sql);
            dr.AddParameters("Years", DbType.Int32, yaers);
            if (expendtype.Length > 0)
            {
                dr.AddParameters("ExpendType", DbType.String, 50, expendtype);
            }
            return dr.DataList();
        }

        /// <summary>
        /// 获取天的数据
        /// </summary>
        /// <param name="yaers">年</param>
        /// <param name="month">月</param>
        /// <param name="expendtype">类型</param>
        /// <returns></returns>
        public DataSet Get_Day_Data(int yaers,int month, string expendtype)
        {
            if (dr == null)
                dr = new CallDatabase();
            string sql = "select Day_Date,SUM(Amount) AS Amount from [Expend] where [Year_Date]=@Years and [Month_Date]=@Month";
            if (expendtype.Length > 0)
            {
                sql = sql + " and [ExpendType]=@ExpendType ";
            }
            sql = sql + " GROUP BY Day_Date ORDER BY Day_Date";
            dr.InitiCommand(sql);
            dr.AddParameters("Years", DbType.Int32, yaers);
            dr.AddParameters("Month", DbType.Int32, month);
            if (expendtype.Length > 0)
            {
                dr.AddParameters("ExpendType", DbType.String, 50, expendtype);
            }
            return dr.DataList();
        }

        /// <summary>
        /// 总金额
        /// </summary>
        /// <param name="startDate">开始日期</param>
        /// <param name="endDate">结束日期</param>
        /// <param name="expendType">支付类型</param>
        /// <param name="itemName">名称</param>
        /// <param name="amount_1">金额_1</param>
        /// <param name="amount_2">金额_2</param>
        /// <returns>总金额</returns>
        public string Get_Total_Amount(DateTime startDate, DateTime endDate, string expendType, string itemName, string amount_1, string amount_2)
        {
            if (dr == null)
                dr = new CallDatabase();
            dr.InitiCommand();
            StringBuilder sql = new StringBuilder();
            sql.Append("select sum(Amount) from [Expend]  where   ExpendDate between @startDate and @endDate");
            dr.AddParameters("startDate", DbType.String,50, startDate.ToString("yyyy-MM-dd 00:00:00"));
            dr.AddParameters("endDate", DbType.String, 50, endDate.ToString("yyyy-MM-dd 23:59:59"));

            if (expendType != null && expendType != "支付类型")
            {
                sql.Append(" and ExpendType=@expendType ");
                dr.AddParameters("expendType", DbType.String, 50, expendType);
            }

            if (itemName != null && itemName.Length > 0)
            {
                sql.Append(" and ItemName like '%@itemName%' ");
                dr.AddParameters("itemName", DbType.String, 50, itemName);
            }

            if (amount_1 != null && amount_1.Length > 0 && amount_2 != null && amount_2.Length > 0)
            {
                sql.Append(" and Amount between @amount_1 and @amount_2 ");
                dr.AddParameters("amount_1", DbType.String, 50, amount_1);
                dr.AddParameters("amount_2", DbType.String, 50, amount_2);
            }

            dr.CommandText = sql.ToString();
            string value = dr.ExecuteScalar().ToString();
            if (value.Length>0)
            {
                return value.ToString();
            }
            return "0";
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

        ~Expend_DAL()
        {
            Dispose(false);
        }

        #endregion

    }
}
