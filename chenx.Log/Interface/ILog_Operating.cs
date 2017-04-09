using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chenx.Log
{
    /// <summary>
    /// 操作日志接口
    /// </summary>
    public interface ILog_Operating :ILog
    {
        /// <summary>
        /// 模块名称
        /// </summary>
        string ModuleName { get; set; }

        /// <summary>
        /// 操作类型(添加、更新、删除、禁用、启用、选择)
        /// </summary>
        string OperationType { get; set; }

        ///// <summary>
        ///// 原名称
        ///// </summary>
        //string OldName { get; set; }

        /// <summary>
        /// 生成日志
        /// </summary>
        void Generatelog(string contents);

        /// <summary>
        /// 生成日志
        /// </summary>
        void Generatelog(string[] contents);

        ///// <summary>
        ///// 日志的结果内容_主键
        ///// </summary>
        ///// <param name="tableName">表名</param>
        ///// <param name="primaryKey">主键</param>
        ///// <returns></returns>
        //string Log_Contents_PrimaryKey(string tableName, string primaryKey);

        ///// <summary>
        ///// 日志的结果内容_json
        ///// </summary>
        ///// <param name="tableName">表名</param>
        ///// <param name="entityJson">实体的json</param>
        ///// <returns></returns>
        //string Log_Contents_Json(string tableName, string entityJson);

        ///// <summary>
        ///// 日志的结果内容_json
        ///// </summary>
        ///// <param name="type">分类</param>
        ///// <param name="tableName">表名</param>
        ///// <param name="entityJson">实体的json</param>
        ///// <returns></returns>
        //string Log_Contents_Json(string type, string tableName, string entityJson);

        ///// <summary>
        ///// 返回部分执行结果
        ///// </summary>
        ///// <param name="name">当前名称</param>
        ///// <param name="text">文本</param>
        ///// <returns></returns>
        //string Get_PartialContents_ResultsDescribed(string name, string text);
    }
}
