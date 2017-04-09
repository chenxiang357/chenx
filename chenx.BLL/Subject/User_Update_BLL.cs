using chenx.DAL;
using chenx.Log;
using chenx.Model;
using chenx.Utils;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace chenx.BLL
{
    public class User_Update_BLL : Basic_BLL<System_User>
    {
        ///// <summary>
        ///// 提示
        ///// </summary>
        //public string Messages { get; set; }

        /// <summary>
        /// 数据连接层
        /// </summary>
        private System_User_DAL system_User;

        /// <summary>
        /// 更新密码
        /// </summary>
        /// <param name="pwd">新密码</param>
        /// <param name="confirmPaw">确认密码</param>
        /// <param name="id">主键</param>
        /// <returns></returns>
        public int Update_Pwd(string pwd, string id)
        {
            if (system_User == null)
            {
                system_User = new System_User_DAL();
            }

            string p = Encryption.EncryptDES(pwd, ConfigurationManager.AppSettings["KeyValue"]);
            int value = system_User.Update_Pwd(p, id);

            if (Combination == null)
            {
                Combination = new ContentsCombination();
            }

            Contents = Combination.Log_Contents_PrimaryKey("T_SYS_USER", id.ToString());
            Update_Log(value, "更新“" + id + "”用户主键的密码");
            return value;
        }

        /// <summary>
        /// 记录原始信息
        /// </summary>
        /// <param name="resultsDescribed"></param>
        protected override void UpdateLog(string resultsDescribed)
        {
            Log_Operating.ResultsDescribed = resultsDescribed;
            Log_Operating.ModuleName = "用户更新";
            Log_Operating.Generatelog(Contents);
        }

        /// <summary>
        /// 验证数据
        /// </summary>
        /// <param name="password">密码</param>
        /// <param name="confirmPwd">确认密码</param>
        /// <returns></returns>
        public bool RepeatVerify_Data(string password,string confirmPwd)
        {
            if (string.IsNullOrEmpty(password))
            {
                Messages = "请填写密码!";
                return false;
            }
            else if (string.IsNullOrEmpty(confirmPwd))
            {
                Messages = "请填写确认密码!";
                return false;
            }
            else if (password!= confirmPwd)
            {
                Messages = "两次密码不一样!";
                return false;
            }
            return true;
        }

    }
}
