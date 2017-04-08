using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Log
{
    /// <summary>
    /// 内容组合
    /// </summary>
    public class ContentsCombination
    {

        /// <summary>
        /// 原名称
        /// </summary>
        public string OldName { get; set; }

        /// <summary>
        /// 日志的结果内容_主键
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="primaryKey">主键</param>
        /// <returns></returns>
        public string Log_Contents_PrimaryKey(string tableName, string primaryKey)
        {
            return "{" + string.Format("\"TableName\":\"{0}\",\"PrimaryKey\":{1}", tableName, primaryKey) + "}";
        }

        /// <summary>
        /// 日志的结果内容_json
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <param name="entityJson">实体的json</param>
        /// <returns></returns>
        public string Log_Contents_Json(string tableName, string entityJson)
        {
            return "{" + string.Format("\"TableName\":\"{0}\",\"Contents\":{1}", tableName, entityJson) + "}";
        }

        /// <summary>
        /// 日志的结果内容_json
        /// </summary>
        /// <param name="type">分类</param>
        /// <param name="tableName">表名</param>
        /// <param name="entityJson">实体的json</param>
        /// <returns></returns>
        public string Log_Contents_Json(string type, string tableName, string entityJson)
        {
            return "{" + string.Format("\"Type\":\"{0}\",\"TableName\":\"{1}\",\"Contents\":{2}", type, tableName, entityJson) + "}";
        }

        /// <summary>
        /// 返回部分执行结果
        /// </summary>
        /// <param name="name">当前名称</param>
        /// <param name="text">文本</param>
        /// <returns></returns>
        public string Get_PartialContents_ResultsDescribed(string name, string text)
        {
            if (OldName == name)
            {
                return string.Format("更新“" + name + "”{0}", text);
            }
            else
            {
                return string.Format("原“{0}”更新为“{1}”{2}", OldName, name, text);
            }
        }
    }
}
