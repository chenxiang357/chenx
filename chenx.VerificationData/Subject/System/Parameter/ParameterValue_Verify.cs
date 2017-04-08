using chenx.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.VerificationData
{
    public class ParameterValue_Verify<T> : IVweification<T>
        where T : ParameterValue
    {

        /// <summary>
        /// 提示信息
        /// </summary>
        public string Messages { get; set; }

        /// <summary>
        /// 实体列表
        /// </summary>
        private IList<T> Entity_List;

        public ParameterValue_Verify(IList<T> entityList)
        {
            Entity_List = entityList;
        }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="System_User">实体</param>
        /// <returns></returns>
        public bool Verification(T entity)
        {
            return false;
        }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="repeatVerify">委托</param>
        /// <returns></returns>
        public bool Verification(T entity, VerifyType type)
        {
            if (entity.Value.Length == 0)
            {
                Messages = "请填写参数值!";
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
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Add(T entity)
        {
            if (Entity_List.Where(w => w.Value == entity.Value).Count() > 0)
            {
                Messages = "已经有相同的参数值!";
                return false;
            }
            return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        private bool Update(T entity)
        {
            if (Entity_List.Where(w => w.Value == entity.Value && w.Id != entity.Id).Count() > 0)
            {
                Messages = "已经有相同的参数值!";
                return false;
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

        ~ParameterValue_Verify()
        {
            Dispose(false);
        }

        #endregion

    }
}
