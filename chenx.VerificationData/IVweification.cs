using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chenx.VerificationData
{
    /// <summary>
    /// 重复验证
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity"></param>
    /// <Param name="messages">提示信息</Param>
    /// <returns></returns>
    public delegate bool RepeatVerify<T>(T entity,out string messages);

    //public delegate bool OtherRulesVerify();

    /// <summary>
    /// 数据验证接口
    /// </summary>
    public interface IVweification<T>:IDisposable
    {
        /// <summary>
        /// 提示信息
        /// </summary>
        string Messages { get; set; }

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        bool Verification(T entity);

        /// <summary>
        /// 数据验证
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="type">类型</param>
        /// <returns></returns>
        bool Verification(T entity, VerifyType type);

        ///// <summary>
        ///// 验证数据
        ///// </summary>
        //RepeatVerify<T> RepeatVerifyData { get; set; }

    }
}
