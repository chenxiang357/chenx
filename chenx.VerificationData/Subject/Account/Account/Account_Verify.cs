using chenx.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.VerificationData
{
    /// <summary>
    /// 账号管理验证
    /// </summary>
    public class Account_Verify<T> : IVweification<T>
        where T : AccountNumber
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        public string Messages { get; set; }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public bool Verification(T entity)
        {
            if (entity.Name.Length == 0)
            {
                Messages = "请填写名称!";
                return false;
            }
            else if (entity.AccountType.Length==0)
            {
                Messages = "请填写分类!";
                return false;
            }
            else if (entity.LogName.Length==0)
            {
                Messages = "请填写账号!";
                return false;
            }
            return true;
        }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="repeatVerify">委托</param>
        /// <returns></returns>
        public bool Verification(T entity, VerifyType type)
        {
            return false;
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

        ~Account_Verify()
        {
            Dispose(false);
        }

        #endregion

    }
}
