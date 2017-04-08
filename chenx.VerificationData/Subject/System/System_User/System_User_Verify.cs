using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using chenx.Model;

namespace chenx.VerificationData
{
    /// <summary>
    /// 用户验证
    /// </summary>
    public class System_User_Verify<T> : IVweification<T> 
        where T:System_User 
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        public string Messages { get; set; }

        /// <summary>
        /// 验证数据
        /// </summary>
        public RepeatVerify<T> RepeatVerifyData { get; set; }

        /// <summary>
        /// 当前密码
        /// </summary>
        private string CurrentPassword;

        /// <summary>
        /// 确认密码
        /// </summary>
        private string ConfirmPwd;

        /// <summary>
        /// 实体列表
        /// </summary>
        private IList<T> Entity_List;

        /// <summary>
        /// 用户数据验证
        /// </summary>
        /// <param name="entityList">实体列表</param>
        /// <param name="confirmPwd">确认密码</param>
        public System_User_Verify(IList<T> entityList,string confirmPwd)
        {
            Entity_List = entityList;
            ConfirmPwd = confirmPwd;
        }

        /// <summary>
        /// 用户数据验证
        /// </summary>
        /// <param name="currentPassword">当前密码</param>
        /// <param name="confirmPwd">确认密码</param>
        public System_User_Verify(string currentPassword,string confirmPwd)
        {
            CurrentPassword = currentPassword;
            ConfirmPwd = confirmPwd;
        }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool Verification(T entity)
        {
            return false;
        }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="type">类型</param>
        /// <returns></returns>
        public bool Verification(T entity, VerifyType type)
        {
            if (entity.LoginName.Length == 0)
            {
                Messages = "请填写用户名!";
                return false;
            }
            else if (entity.UserName.Length == 0)
            {
                Messages = "请填写用户姓名!";
                return false;
            }
            switch (type)
            {
                case VerifyType.Add:
                    if (!Add(entity))
                    {
                        return false;
                    }
                    break;
                case VerifyType.Update:
                    if (!Update(entity))
                    {
                        return false;
                    }
                    break;
                default:
                    break;
            }

            return true;
        }


        /// <summary>
        /// 添加验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        private bool Add(T entity)
        {
            if (string.IsNullOrEmpty(entity.Pwd))
            {
                Messages = "请填写密码!";
                return false;
            }
            else if (entity.Pwd != ConfirmPwd)
            {
                Messages = "密码和确认密码不一样!";
                return false;
            }
            else if (Entity_List.Where(w => w.LoginName == entity.LoginName).Count() > 0)
            {
                Messages = "已经有相同的用户名!";
                return false;
            }
            return true;
        }

        /// <summary>
        /// 更新验证
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private bool Update(T entity)
        {
            if (CurrentPassword != entity.Pwd)
            {
                //表示有修改密码
                if (entity.Pwd != ConfirmPwd)
                {
                    Messages = "密码和确认密码不一样!";
                    return false;
                }
            }
            return true;
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
                   
                }
                //非托管资源
                m_disposed = true;
            }
        }

        ~System_User_Verify()
        {
            Dispose(false);
        }

        #endregion

    }
}
