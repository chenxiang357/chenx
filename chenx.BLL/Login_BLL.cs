using chenx.DAL;
using chenx.Log;
using chenx.Model;
using chenx.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chenx.Config;
using System.Configuration;
using System.IO;
using JsonHelper;

namespace chenx.BLL
{
    public class Login_BLL: IDisposable
    {

        /// <summary>
        /// 用户信息
        /// </summary>
        private string UaserName;

        /// <summary>
        /// 密码
        /// </summary>
        private string Password;

        /// <summary>
        /// 错误提示
        /// </summary>
        private string _ErrorMessage;

        /// <summary>
        /// 错误提示
        /// </summary>
        public string ErrorMessage
        {
            get { return _ErrorMessage; }
        }

        /// <summary>
        /// 读取配置
        /// </summary>
        private ReadConfigFile readConfigFile;

        /// <summary>
        /// 校验Login信息
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="pwd">密码</param>
        /// <returns>通过:true/失败:false</returns>
        public bool LoginInfoVerify(string userName, string pwd)
        {
            bool value = false;
            if (userName != null && userName.Length == 0)
                _ErrorMessage = "请输入用户名!";
            else if (pwd != null && pwd.Length == 0)
                _ErrorMessage = "请输入密码!";
            else
            {
                UaserName = userName;
                Password = pwd;
                value = true;
            }
            return value;
        }

        /// <summary>
        /// 登录用户
        /// </summary>
        /// <param name="mes">返回信息情况</param>
        /// <returns>通过:true/失败:false</returns>
        public bool UserLogin()
        {
            using (System_User_DAL UserDAL = new System_User_DAL())
            {

                bool value = true;
                var User_Entity = UserDAL.GetLoginInfo(UaserName).GetEntity<System_User>();//根据用户名来获取信息
                if (User_Entity == null)
                    _ErrorMessage = "用户名错误，请重新输入！";
                else if (Encryption.EncryptDES(Password, ConfigurationManager.AppSettings["KeyValue"]) != User_Entity.Pwd)
                    //else if (User_Entity.Pwd != Encryption.SHA1_Encryption(Encryption.Md5_Encryption(Password)))   //密码对比
                    _ErrorMessage = "密码错误，请重新输入！";
                else
                {
                    value = false;
                    UserInfoSave(User_Entity);
                    _ErrorMessage = "登录系统成功!";
                }

                using (Log_Login_Add_DAL log = new Log_Login_Add_DAL())
                {
                    log.Login_Name = UaserName;
                    log.Result = (value ? "失败" : "成功");
                    log.ResultsDescribed = _ErrorMessage;
                    log.Generatelog();
                }

                return value;
            }
        }

        /// <summary>
        /// 登录成功之后保存的信息
        /// </summary>
        private void UserInfoSave(System_User entity)
        {
            User_Login_Config user_Entity = new User_Login_Config();
            user_Entity.Id = entity.Id;
            user_Entity.IsAdmin = entity.IsAdmin;
            user_Entity.LoginName = entity.LoginName;
            user_Entity.UserName = entity.UserName;
            ReadConfigFile.UserLongInfo = user_Entity;
        }

        /// <summary>
        /// 读取配置
        /// </summary>
        public void ReadConfig()
        {
            if (readConfigFile == null)
            {
                readConfigFile = new ReadConfigFile();
            }

            readConfigFile.Read_Text_Contents(Json.Deserialization<TextConfigInfo>(
                File.ReadAllText(Directory.GetCurrentDirectory() + "/" + ConfigurationManager.AppSettings["Text_Contents_PathUrl"].ToString(), 
                Encoding.UTF8)));
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
                    // dr.Dispose();       //释放用户表的数据库访问
                }
                //非托管资源
                m_disposed = true;
            }
        }

        ~Login_BLL()
        {
            Dispose(false);
        }

        #endregion

    }
}
