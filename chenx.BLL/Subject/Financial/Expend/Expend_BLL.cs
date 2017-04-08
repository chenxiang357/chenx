using chenx.DAL;
using chenx.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using chenx.Utils;
using chenx.VerificationData;
using chenx.Log;
using JsonHelper;

namespace chenx.BLL
{
    /// <summary>
    /// 支出
    /// </summary>
    public class Expend_BLL :Basic_BLL<Expend>,IDisposable
    {
        private Expend_DAL expend;

        public Expend_BLL()
        {

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Add(Expend entity)
        {
            if (expend == null)
                expend = new Expend_DAL();

            int value = expend.Add(entity);

            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }

            Contents = Combination.Log_Contents_Json("Expend", Json.Serialization(entity));
            Add_Log(value, "支出账目“" + entity.ItemName + "”");

            return value;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Update(Expend entity)
        {
            if (expend == null)
                expend = new Expend_DAL();
            int value = expend.Update(entity);
            
            ContentsArray[1] = Combination.Log_Contents_Json("更新后信息", "Expend", Json.Serialization(entity));
            Update_Log(value, Combination.Get_PartialContents_ResultsDescribed(entity.ItemName, "支出账目"));

            return value;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public int Delete(int id)
        {
            if (expend == null)
                expend = new Expend_DAL();
            int value= expend.Delete(id);

            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }

            Contents = Combination.Log_Contents_PrimaryKey("T_SYS_USER", id.ToString());
            Delete_Log(value, "删除“" + id + "”支出账目主键");
            return value;
        }

        /// <summary>
        /// 根据主键查询数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns>返回数据集</returns>
        public Expend Get_Entity(int id)
        {
            if (expend == null)
                expend = new Expend_DAL();
            return expend.Get_Data(id).GetEntity<Expend>();
        }

        /// <summary>
        /// 获取年的数据
        /// </summary>
        /// <param name="startDate">开始时间</param>
        /// <param name="endDate">结束时间</param>
        /// <param name="expendtype">类型</param>
        /// <returns></returns>
        public DataTable Get_Yaer_Data(int startDate,int endDate,string Expendtype)
        {
            if (expend ==null)
            {
                expend = new Expend_DAL();
            }
            return expend.Get_Yaer_Data(startDate, endDate, Expendtype).Tables[0];
        }

        /// <summary>
        /// 获取月的数据
        /// </summary>
        /// <param name="yaers">年份</param>
        /// <param name="expendtype">类型</param>
        /// <returns></returns>
        public DataTable Get_Month_Data(int yaers, string expendtype)
        {
            if (expend == null)
            {
                expend = new Expend_DAL();
            }
            return expend.Get_Month_Data(yaers, expendtype).Tables[0];
        }

        /// <summary>
        /// 获取天的数据
        /// </summary>
        /// <param name="yaers">年</param>
        /// <param name="month">月</param>
        /// <param name="expendtype">类型</param>
        /// <returns></returns>
        public DataTable Get_Day_Data(int yaers, int month, string expendtype)
        {
            if (expend == null)
            {
                expend = new Expend_DAL();
            }
            return expend.Get_Day_Data(yaers, month, expendtype).Tables[0];

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
            if (expend == null)
                expend = new Expend_DAL();
            return expend.Get_Total_Amount(startDate, endDate, expendType, itemName, amount_1, amount_2);
        }


        /// <summary>
        /// 分页
        /// </summary>
        /// <param name="pageIndex">当前页</param>
        /// <param name="pageCount">返回总页数</param>
        /// <param name="pageSize">当前显示数量</param>
        /// <param name="startDate">开始日期</param>
        /// <param name="endDate">结束日期</param>
        /// <param name="expendType">支付类型</param>
        /// <param name="itemName">名称</param>
        /// <param name="amount_1">金额_1</param>
        /// <param name="amount_2">金额_2</param>
        /// <returns></returns>
        public DataTable PagingData(int pageIndex, out int pageCount, int pageSize, 
            DateTime startDate, DateTime endDate, string expendType, string itemName, string amount_1, string amount_2)
        {
            StringBuilder tj = new StringBuilder();
            tj.AppendFormat(" ExpendDate between '{0} 00:00:00' and '{1} 23:59:59' ", startDate.ToString("yyyy-MM-dd"), endDate.ToString("yyyy-MM-dd"));

            if (expendType != null && expendType != "支付类型")
            {
                tj.AppendFormat(" and ExpendType='{0}' ", expendType);
            }

            if (itemName != null && itemName.Length > 0)
            {
                tj.AppendFormat(" and ItemName like '%{0}%' ", itemName);
            }

            if (amount_1 != null && amount_1.Length > 0 && amount_2 != null && amount_2.Length > 0)
            {
                tj.AppendFormat(" and Amount between {0} and {1} ", amount_1, amount_2);
            }
            pageCount = 0;
            Paging p = new Paging();
            p.TableName = "Expend";
            p.ReFieldsStr = "Id,ExpendDate,ExpendType,ItemName,Amount,Reason,Remarks";
            p.PageSize = pageSize;
            p.WhereString = tj.ToString();
            p.PageIndex = pageIndex;
            p.OrderString = "ExpendDate desc";
            DataTable data= p.GetData().Tables[0];
            pageCount = p.PageCount;
            return data;
        }

        #region 日志

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultsDescribed">执行结果描述</param>
        protected override void AddLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "支出账目添加";
            Log_Operating.Generatelog(Contents);
        }

        /// <summary>
        /// 原始信息
        /// </summary>
        /// <param name="entity"></param>
        public void OriginalInfo(Expend entity)
        {
            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }
            Combination.OldName = entity.ItemName;
            ContentsArray = new string[2];
            ContentsArray[0] = Combination.Log_Contents_Json("原始信息", "Expend", Json.Serialization(entity));
        }

        /// <summary>
        /// 记录原始信息
        /// </summary>
        /// <param name="resultsDescribed"></param>
        protected override void UpdateLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "支出账目更新";
            Log_Operating.Generatelog(ContentsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultsDescribed"></param>
        protected override void DeleteLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "支出账目删除";
            Log_Operating.Generatelog(Contents);
        }

        #endregion

        #region 数据验证

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool RepeatVerify_Add(Expend entity)
        {
            using (VerifyTtheData = new Expend_Verify<Expend>())
            {
                bool r = VerifyTtheData.Verification(entity);
                Messages = VerifyTtheData.Messages;
                return r;
            }
        }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool RepeatVerify_Update(Expend entity)
        {
            using (VerifyTtheData = new Expend_Verify<Expend>())
            {
                bool r = VerifyTtheData.Verification(entity);
                Messages = VerifyTtheData.Messages;
                return r;
            }
        }

        #endregion

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
                    expend.Dispose();       //释放用户表的数据库访问
                }
                //非托管资源
                m_disposed = true;
            }
        }

        ~Expend_BLL()
        {
            Dispose(false);
        }

        #endregion
    }
}
