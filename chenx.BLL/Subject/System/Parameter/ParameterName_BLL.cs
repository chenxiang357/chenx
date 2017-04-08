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
    /// 参数名称
    /// </summary>
    public class ParameterName_BLL :Basic_BLL<ParameterName>
    {
        private ParameterName_DAL parameterName;

        /// <summary>
        /// 参数名称列表
        /// </summary>
        private IList<ParameterName> ParameterName_List;

        public ParameterName_BLL()
        {

        }

        /// <summary>
        /// 初始化加载
        /// </summary>
        private void DoLoad()
        {
            if (parameterName == null)
            {
                parameterName = new ParameterName_DAL();
            }

            if (ParameterName_List == null)
            {
                ParameterName_List = new List<ParameterName>();
            }
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Add(ParameterName entity)
        {
            DoLoad();
            var value = parameterName.Add(entity);
            if (value>-1)
            {
                ParameterName_List.Add(entity);
            }

            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }

            Contents = Combination.Log_Contents_Json("Sys_ParameterName", Json.Serialization(entity));
            Add_Log(value, "创建“" + entity.ConfigName + "”参数名称");
            return value;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Update(ParameterName entity)
        {
            DoLoad();
            var value = parameterName.Update(entity);
            if (value>-1)
            {
                ParameterName_List.Remove(ParameterName_List.FirstOrDefault(f => f.Id == entity.Id));
                ParameterName_List.Add(entity);
            }

            ContentsArray[1] = Combination.Log_Contents_Json("更新后信息", "Sys_ParameterName", Json.Serialization(entity));
            Update_Log(value, Combination.Get_PartialContents_ResultsDescribed(entity.ConfigName, "参数名称"));
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
            DoLoad();
            var value = parameterName.UpdateStatus(status, id);
            if (value > -1)
            {
                var entity = ParameterName_List.FirstOrDefault(f => f.Id == id);
                if (entity != null)
                {
                    entity.Status = status;
                }
            }

            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }
            var s = (status == "1" ? "启用" : "禁用");
            Contents = Combination.Log_Contents_PrimaryKey("Sys_ParameterName", id.ToString());
            Status_Log(value, s, s + "“" + id + "”参数名称主键");
            return value;
        }

        /// <summary>
        /// 根据主键获取实体
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public ParameterName Get_Entity(int  id)
        {
            return ParameterName_List.FirstOrDefault(w => w.Id == id);
        }

        /// <summary>
        /// 获取所有的参数名称数据列表
        /// </summary>
        /// <returns></returns>
        public IList<ParameterName> Get_Entity_List()
        {
            if (parameterName == null)
            {
                parameterName = new ParameterName_DAL();
            }
            if (ParameterName_List == null)
            {
                ParameterName_List = parameterName.Get_Data().GetEntityList<ParameterName>();
            }
            return ParameterName_List;
        }

        /// <summary>
        /// 根据状态来显示数据
        /// </summary>
        /// <param name="state">当前是启用（1）/禁用（0）状态</param>
        /// <returns></returns>
        public IEnumerable<ParameterName> Get_Data(string state)
        {
            return Get_Entity_List().Where(w => w.Status == state);
        }

        /// <summary>
        /// 查询所以启用全部参数名称数据
        /// </summary>
        /// <returns>返回数据集</returns>
        public IEnumerable<ParameterName> Get_Enabled_Data()
        {
            return Get_Entity_List().Where(w => w.Status == "1");
        }

        /// <summary>
        /// 禁用全部参数名称数据
        /// </summary>
        /// <returns>返回数据集</returns>
        public IEnumerable<ParameterName> Get_Disabled_Data()
        {
            return Get_Entity_List().Where(w => w.Status == "0");
        }

        /// <summary>
        /// 获取最大的序号
        /// </summary>
        /// <returns>返回最大的序号</returns>
        public int GetNo()
        {
            if (parameterName == null)
            {
                parameterName = new ParameterName_DAL();
            }
            return Get_Entity_List().Max(m=>m.No);
        }

        #region 日志

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultsDescribed">执行结果描述</param>
        protected override void AddLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "参数名称添加";
            Log_Operating.Generatelog(Contents);
        }

        /// <summary>
        /// 原始信息
        /// </summary>
        /// <param name="entity"></param>
        public void OriginalInfo(ParameterName entity)
        {
            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }
            Combination.OldName = entity.ConfigName;
            ContentsArray = new string[2];
            ContentsArray[0] = Combination.Log_Contents_Json("原始信息", "Sys_ParameterName", Json.Serialization(entity));
        }

        /// <summary>
        /// 记录原始信息
        /// </summary>
        /// <param name="resultsDescribed"></param>
        protected override void UpdateLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "参数名称更新";
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
        public bool RepeatVerify_Add(ParameterName entity)
        {
            using (VerifyTtheData = new ParameterName_Verify<ParameterName>(Get_Entity_List()))
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
        public bool RepeatVerify_Update(ParameterName entity)
        {
            using (VerifyTtheData = new ParameterName_Verify<ParameterName>(Get_Entity_List()))
            {
                bool r = VerifyTtheData.Verification(entity, VerifyType.Update);
                Messages = VerifyTtheData.Messages;
                return r;
            }
        }

        #endregion

    }
}
