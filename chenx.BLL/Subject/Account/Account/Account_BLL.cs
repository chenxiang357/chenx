using chenx.DAL;
using chenx.Model;
using chenx.Utils;
using chenx.VerificationData;
using JsonHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using chenx.Log;

namespace chenx.BLL
{
    public class Account_BLL : Basic_BLL<AccountNumber>
    {
        /// <summary>
        /// 
        /// </summary>
        private Account_DAL AccountDAL;

        /// <summary>
        /// 账号实体列表
        /// </summary>
        private List<AccountNumber> AccountNumber_Entity_List;

        /// <summary>
        /// 添加账号
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>-1为失败/大于-1为成功</returns>
        public int Add(AccountNumber entity)
        {

            if (AccountDAL == null)
                AccountDAL = new Account_DAL();

            entity.LogName = Encryption.EncryptDES(entity.LogName, ConfigurationManager.AppSettings["KeyValue"].ToString());
            entity.Paw = Encryption.EncryptDES(entity.Paw, ConfigurationManager.AppSettings["KeyValue"].ToString());

            AccountNumber_Entity_List.Add(entity);
            int value= AccountDAL.Add(Json.Serialization(AccountNumber_Entity_List));
            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }

            Contents = Combination.Log_Contents_Json("data.json文件", Json.Serialization(entity));
            Add_Log(value, "账户“" + entity.Name + "”");
            return value;
        }


        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns>-1为失败/大于-1为成功</returns>
        public int Update(AccountNumber entity)
        {

            if (AccountDAL == null)
                AccountDAL = new Account_DAL();

            entity.LogName = Encryption.EncryptDES(entity.LogName, ConfigurationManager.AppSettings["KeyValue"].ToString());
            entity.Paw = Encryption.EncryptDES(entity.Paw, ConfigurationManager.AppSettings["KeyValue"].ToString());

            AccountNumber_Entity_List.Remove(AccountNumber_Entity_List.FirstOrDefault(f => f.Id == entity.Id));
            AccountNumber_Entity_List.Add(entity);

            int value= AccountDAL.Update(Json.Serialization(AccountNumber_Entity_List));

            ContentsArray[1] = Combination.Log_Contents_Json("更新后信息", "data.json文件", Json.Serialization(entity));
            Update_Log(value, Combination.Get_PartialContents_ResultsDescribed(entity.Name, "账户"));

            return value;

        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id">主键</param>
        /// <returns>-1为失败/大于-1为成功</returns>
        public int Delete(string Id)
        {

            if (AccountDAL == null)
                AccountDAL = new Account_DAL();
            AccountNumber_Entity_List.Remove(AccountNumber_Entity_List.FirstOrDefault(f => f.Id == Id));
            int value = AccountDAL.Delete(Json.Serialization(AccountNumber_Entity_List));

            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }

            Contents = Combination.Log_Contents_PrimaryKey("data.json文件", Id.ToString());
            Delete_Log(value, "删除“" + Id + "”账户主键");

            return value;
        }

        /// <summary>
        /// 实体列表
        /// </summary>
        /// <returns>返回实体列表</returns>
        public List<AccountNumber> QueryData()
        {
            if (AccountDAL == null)
            {
                AccountDAL = new Account_DAL();
            }
            if (AccountNumber_Entity_List == null)
            {
                AccountNumber_Entity_List = Json.DeserializationList<AccountNumber>(AccountDAL.QueryData()).ToList();
            }
            return AccountNumber_Entity_List;
        }

        /// <summary>
        /// 根据主键返回实体
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public AccountNumber Get_Entity(string id)
        {
            if (AccountNumber_Entity_List != null)
            {
                var entity= AccountNumber_Entity_List.FirstOrDefault(f => f.Id == id);
                entity.LogName = Encryption.DecryptDES(entity.LogName, ConfigurationManager.AppSettings["KeyValue"].ToString());
                entity.Paw = Encryption.DecryptDES(entity.Paw, ConfigurationManager.AppSettings["KeyValue"].ToString());
                return entity;
            }
            else
                return new AccountNumber();
        }

        #region 日志

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultsDescribed">执行结果描述</param>
        protected override void AddLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "账户添加";
            Log_Operating.Generatelog(Contents);
        }

        /// <summary>
        /// 原始信息
        /// </summary>
        /// <param name="entity"></param>
        public void OriginalInfo(AccountNumber entity)
        {
            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }
            Combination.OldName = entity.Name;
            ContentsArray = new string[2];
            ContentsArray[0] = Combination.Log_Contents_Json("原始信息", "data.json文件", Json.Serialization(entity));
        }

        /// <summary>
        /// 记录原始信息
        /// </summary>
        /// <param name="resultsDescribed"></param>
        protected override void UpdateLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "账户更新";
            Log_Operating.Generatelog(ContentsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultsDescribed"></param>
        protected override void DeleteLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "账户删除";
            Log_Operating.Generatelog(Contents);
        }

        #endregion

        #region 数据验证

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool RepeatVerify_Add(AccountNumber entity)
        {
            using (VerifyTtheData = new Account_Verify<AccountNumber>())
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
        public bool RepeatVerify_Update(AccountNumber entity)
        {
            using (VerifyTtheData = new Account_Verify<AccountNumber>())
            {
                bool r = VerifyTtheData.Verification(entity);
                Messages = VerifyTtheData.Messages;
                return r;
            }
        }

        #endregion

    }
}
