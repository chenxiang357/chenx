using chenx.Log;
using chenx.VerificationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.BLL
{
    /// <summary>
    /// 逻辑代码
    /// </summary>
    public class Basic_BLL<T>
         where T : class,new()
    {

        /// <summary>
        /// 提示信息
        /// </summary>
        public string Messages { get; set; }

        /// <summary>
        /// 验证数据
        /// </summary>
        public IVweification<T> VerifyTtheData;

        /// <summary>
        /// 操作日志
        /// </summary>
        protected ILog_Operating Log_Operating { get; set; }

        /// <summary>
        /// 组合
        /// </summary>
        protected ContentsCombination Combination { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        protected string Contents { get; set; }

        /// <summary>
        /// 内容数组
        /// </summary>
        protected string[] ContentsArray { get; set; }

        /// <summary>
        /// 添加日志
        /// </summary>
        /// <param name="s">添加状态</param>
        /// <param name="resultsDescribed">执行结果描述</param>
        public void Add_Log(int s,string resultsDescribed)
        {
            if (Log_Operating == null)
            {
                Log_Operating = new Log_Operating_DAL();
            }
            Log_Entity(s, "添加");
            AddLog(resultsDescribed);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultsDescribed">执行结果描述</param>
        protected virtual void AddLog(string resultsDescribed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 更新日志
        /// </summary>
        /// <param name="status">更新状态</param>
        /// <param name="resultsDescribed">执行结果描述</param>
        public void Update_Log(int s, string resultsDescribed)
        {
            if (Log_Operating == null)
            {
                Log_Operating = new Log_Operating_DAL();
            }

            Log_Entity(s, "更新");
            UpdateLog(resultsDescribed);
        }

        protected virtual void UpdateLog(string resultsDescribed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除日志
        /// </summary>
        /// <param name="status">删除状态</param>
        /// <param name="resultsDescribed">执行结果描述</param>
        public void Delete_Log(int s, string resultsDescribed)
        {
            if (Log_Operating == null)
            {
                Log_Operating = new Log_Operating_DAL();
            }

            Log_Entity(s, "删除");
            DeleteLog(resultsDescribed);
        }

        protected virtual void DeleteLog(string resultsDescribed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 状态日志
        /// </summary>
        /// <param name="s"></param>
        /// <param name="operationType"></param>
        /// <param name="moduleName">模块名称</param>
        public void Status_Log(int s,string operationType, string resultsDescribed)
        {
            if (Log_Operating == null)
            {
                Log_Operating = new Log_Operating_DAL();
            }

            Log_Entity(s, operationType);
            StatusLog(resultsDescribed);
        }

        public virtual void StatusLog(string resultsDescribed)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 日志实体
        /// </summary>
        /// <param name="status"></param>
        /// <param name="operationType"></param>
        private void Log_Entity(int status,string operationType)
        {
            Log_Operating.Result = status.ToString();
            Log_Operating.OperationType = operationType;
            Log_Operating.Login_Name = "admin";
        }
    }
}
