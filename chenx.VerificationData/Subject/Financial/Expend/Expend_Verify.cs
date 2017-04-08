using chenx.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.VerificationData
{
    /// <summary>
    /// 支出验证
    /// </summary>
    public class Expend_Verify<T> : IVweification<T>
        where T : Expend
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
            if (entity.ItemName.Length == 0)
            {
                Messages = "请填写名称!";
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

        ~Expend_Verify()
        {
            Dispose(false);
        }

        #endregion

    }
}
