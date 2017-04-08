using chenx.DAL;
using chenx.Log;
using chenx.Model;
using chenx.Utils;
using chenx.VerificationData;
using JsonHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;

namespace chenx.BLL
{
    public class System_User_BLL : Basic_BLL<System_User>
    {
        /// <summary>
        /// 数据连接层
        /// </summary>
        private System_User_DAL system_User;

        /// <summary>
        /// 当前密码
        /// </summary>
        private string CurrentPassword;

        /// <summary>
        /// 确认密码
        /// </summary>
        public string ConfirmPwd { get; set; }

        /// <summary>
        /// 实体列表
        /// </summary>
        private IList<System_User> System_User_Entity_List;

        public System_User_BLL()
        {
            //ModuleName = "";
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Add(System_User entity)
        {
            if (system_User == null)
            {
                system_User = new System_User_DAL();
            }
            entity.Pwd = Encryption.EncryptDES(entity.Pwd, ConfigurationManager.AppSettings["KeyValue"]);
            entity.IsAdmin = "0";
            System_User_Entity_List.Add(entity);
            int value= system_User.Add(entity);
            
            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }

            Contents = Combination.Log_Contents_Json("Sys_User", Json.Serialization(entity));
            Add_Log(value, "创建“" + entity.LoginName + "”用户名");
            return value;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public int Update(System_User entity)
        {
            if (system_User == null)
            {
                system_User = new System_User_DAL();
            }

            if (CurrentPassword != entity.Pwd)
            {
                entity.Pwd = Encryption.EncryptDES(entity.Pwd, ConfigurationManager.AppSettings["KeyValue"]);
            }

            int value = system_User.Update(entity);
            if (value > -1)
            {
                System_User_Entity_List.Remove(System_User_Entity_List.FirstOrDefault(f => f.Id == entity.Id));
                System_User_Entity_List.Add(entity);
            }

            ContentsArray[1] = Combination.Log_Contents_Json("更新后信息", "T_SYS_USER", Json.Serialization(entity)); 
            Update_Log(value, Combination.Get_PartialContents_ResultsDescribed(entity.LoginName, "用户名"));
            return value;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public int Delete(int id)
        {
            if (system_User == null)
            {
                system_User = new System_User_DAL();
            }

            int value = system_User.Delete(id);
            if (value>-1)
            {
                System_User_Entity_List.Remove(System_User_Entity_List.FirstOrDefault(f => f.Id == id));
            }
       
            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }

            Contents = Combination.Log_Contents_PrimaryKey("T_SYS_USER", id.ToString());
            Delete_Log(value, "删除“" + id + "”用户主键");
            return value;
        }

        /// <summary>
        /// 查询实体列表
        /// </summary>
        /// <returns></returns>
        public IList<System_User> Get_Entity_List()
        {
            if (system_User == null)
            {
                system_User = new System_User_DAL();
            }

            if (System_User_Entity_List == null)
                System_User_Entity_List = system_User.Get_Data().GetEntityList<System_User>();
            return System_User_Entity_List;
        }

        /// <summary>
        /// 返回实体
        /// </summary>
        /// <param name="userId">用户名主键</param>
        /// <returns></returns>
        public System_User Get_Entity(string userId)
        {
            if (System_User_Entity_List == null)
            {
                return null;
            }
            else
            {
                var entity = System_User_Entity_List.FirstOrDefault(f => f.Id.ToString() == userId);
                if (entity != null)
                    CurrentPassword = entity.Pwd;   //记录当前密码
                else
                    CurrentPassword = "";
                return entity;
            }
        }

        #region 日志

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultsDescribed">执行结果描述</param>
        protected override void AddLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "用户添加";
            Log_Operating.Generatelog(Contents);
        }

        /// <summary>
        /// 原始信息
        /// </summary>
        /// <param name="entity"></param>
        public void OriginalInfo(System_User entity)
        {
            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }
            Combination.OldName = entity.LoginName;
            ContentsArray = new string[2];
            ContentsArray[0] = Combination.Log_Contents_Json("原始信息", "T_SYS_USER", Json.Serialization(entity));
        }

        /// <summary>
        /// 记录原始信息
        /// </summary>
        /// <param name="resultsDescribed"></param>
        protected override void UpdateLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "用户更新";
            Log_Operating.Generatelog(ContentsArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="resultsDescribed"></param>
        protected override void DeleteLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "用户删除";
            Log_Operating.Generatelog(Contents);
        }

        #endregion

        #region 数据验证

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool RepeatVerify_Add(System_User entity)
        {
            using (VerifyTtheData = new System_User_Verify<System_User>(Get_Entity_List(), ConfirmPwd))
            {
                bool r = VerifyTtheData.Verification(entity, VerifyType.Add);
                Messages = VerifyTtheData.Messages;
                return r;
            }
        }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool RepeatVerify_Update(System_User entity)
        {
            using (VerifyTtheData = new System_User_Verify<System_User>(CurrentPassword,ConfirmPwd))
            {
                bool r = VerifyTtheData.Verification(entity, VerifyType.Update);
                Messages = VerifyTtheData.Messages;
                return r;
            }
        }

        #endregion

    }
}
