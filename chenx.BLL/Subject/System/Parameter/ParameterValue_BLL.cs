using chenx.DAL;
using chenx.Log;
using chenx.Model;
using chenx.Utils;
using chenx.VerificationData;
using JsonHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.BLL
{
    /// <summary>
    /// 参数值
    /// </summary>
    public class ParameterValue_BLL : Basic_BLL<ParameterValue>
    {
        private ParameterValue_DAL parameterValue;

        /// <summary>
        /// 参数值列表
        /// </summary>
        private IList<ParameterValue> ParameterValue_List;

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Add(ParameterValue entity)
        {
            if (parameterValue == null)
                parameterValue = new ParameterValue_DAL();

            if (ParameterValue_List==null)
            {
                ParameterValue_List = new List<ParameterValue>();
            }

            var value = parameterValue.Add(entity);
            if (value>-1)
            {
                ParameterValue_List.Add(entity);
            }

            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }

            Contents = Combination.Log_Contents_Json("Sys_ParameterValue", Json.Serialization(entity));
            Add_Log(value, "创建“" + entity.Value + "”参数值");
            return value;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Update(ParameterValue entity)
        {
            if (parameterValue == null)
                parameterValue = new ParameterValue_DAL();

            if (ParameterValue_List == null)
            {
                ParameterValue_List = new List<ParameterValue>();
            }

            var value = parameterValue.Update(entity);
            if (value > -1)
            {
                ParameterValue_List.Remove(ParameterValue_List.FirstOrDefault(f => f.Id == entity.Id));
                ParameterValue_List.Add(entity);
            }

            ContentsArray[1] = Combination.Log_Contents_Json("更新后信息", "Sys_ParameterValue", Json.Serialization(entity));
            Update_Log(value, Combination.Get_PartialContents_ResultsDescribed(entity.Value, "参数值"));
            return value;
        }

        /// <summary>
        /// 更新状态
        /// </summary>
        /// <param name="status">状态(1为启用;0为禁用)</param>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public int UpdateStatus(string status, int id)
        {
            if (parameterValue == null)
                parameterValue = new ParameterValue_DAL();
            var value= parameterValue.UpdateStatus(status,id);
            if (value > -1)
            {
                var entity = ParameterValue_List.FirstOrDefault(f => f.Id == id);
                if (entity != null)
                {
                    entity.Status = status;
                }
            }

            if (Combination==null)
            {
                Combination = new ContentsCombination();
            }
            var s = (status == "1" ? "启用" : "禁用");
            Contents = Combination.Log_Contents_PrimaryKey("Sys_ParameterValue", id.ToString());
            Status_Log(value, s, s + "“" + id + "”参数值主键");
            return value;
        }

        /// <summary>
        /// 根据主键查询数据
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public DataSet Get_SingleData(int id)
        {
            if (parameterValue == null)
                parameterValue = new ParameterValue_DAL();
            return parameterValue.Get_SingleData(id);
        }

        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="p_Id">Sys_ParameterName的主键</param>
        /// <returns></returns>
        public IList<ParameterValue> Get_Data(int p_Id)
        {
            if (parameterValue == null)
                parameterValue = new ParameterValue_DAL();
            return parameterValue.Get_Data(p_Id).GetEntityList<ParameterValue>();
        }

        /// <summary>
        /// 返回数据集
        /// </summary>
        /// <param name="configName">参数名称</param>
        /// <returns></returns>
        public DataTable Get_Data(string configName)
        {
            if (parameterValue == null)
                parameterValue = new ParameterValue_DAL();
            return parameterValue.Get_Data(configName).Tables[0];
        }

        /// <summary>
        /// 获取实体列表
        /// </summary>
        /// <param name="p_Id">Sys_ParameterName的主键</param>
        /// <returns></returns>
        public IList<ParameterValue> Get_Entity_List(int p_Id)
        {
            if (parameterValue == null)
                parameterValue = new ParameterValue_DAL();
            if (ParameterValue_List==null)
            {
                ParameterValue_List = new List<ParameterValue>();
            }
            ParameterValue_List = parameterValue.Get_Data(p_Id).GetEntityList<ParameterValue>();
            return ParameterValue_List;
        }

        /// <summary>
        /// 根据主键获取参数值
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ParameterValue Get_Entity(int id)
        {
            if (ParameterValue_List == null)
            {
                return Get_SingleData(id).GetEntity<ParameterValue>();
            }
            else
                return ParameterValue_List.FirstOrDefault(f => f.Id == id);
        }

        /// <summary>
        /// 获取当前参数值数据
        /// </summary>
        /// <param name="status">数据状态</param>
        /// <returns></returns>
        public IEnumerable<ParameterValue> Get_Status_Data(string status)
        {
            if (ParameterValue_List==null)
            {
                ParameterValue_List = new List<ParameterValue>();
            }
            return ParameterValue_List.Where(w => w.Status== status);
        }

        /// <summary>
        /// 获取最大的序号
        /// </summary>
        /// <param name="p_id">Sys_ParameterName的主键</param>
        /// <returns>返回最大的序号</returns>
        public int GetNo(int p_id)
        {
            if (parameterValue == null)
                parameterValue = new ParameterValue_DAL();
            return parameterValue.GetNo(p_id);
        }

        #region 日志

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultsDescribed">执行结果描述</param>
        protected override void AddLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "参数值添加";
            Log_Operating.Generatelog(Contents);
        }

        /// <summary>
        /// 原始信息
        /// </summary>
        /// <param name="entity"></param>
        public void OriginalInfo(ParameterValue entity)
        {
            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }
            Combination.OldName = entity.Value;
            ContentsArray = new string[2];
            ContentsArray[0] = Combination.Log_Contents_Json("原始信息", "Sys_ParameterValue", Json.Serialization(entity));
        }

        /// <summary>
        /// 记录原始信息
        /// </summary>
        /// <param name="resultsDescribed"></param>
        protected override void UpdateLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "参数值更新";
            Log_Operating.Generatelog(ContentsArray);
        }

        public override void StatusLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "参数管理";
            Log_Operating.Generatelog(Contents);
        }

        #endregion

        #region 数据验证

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool RepeatVerify_Add(ParameterValue entity)
        {
            using (VerifyTtheData = new ParameterValue_Verify<ParameterValue>(ParameterValue_List))
            {
                bool r = VerifyTtheData.Verification(entity, VerifyType.Add);
                Messages = VerifyTtheData.Messages;
                return r;
            }
        }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool RepeatVerify_Update(ParameterValue entity)
        {
            using (VerifyTtheData = new ParameterValue_Verify<ParameterValue>(ParameterValue_List))
            {
                bool r = VerifyTtheData.Verification(entity, VerifyType.Update);
                Messages = VerifyTtheData.Messages;
                return r;
            }
        }

        #endregion

    }
}
