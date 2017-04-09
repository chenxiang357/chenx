using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Configuration;

namespace chenx.Log
{
    /// <summary>
    /// 错误日志生成文件
    /// </summary>
    public class Log_Error_Generate : ILog_Error
    {
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 用户登录名
        /// </summary>
        public string Login_Name { get; set; }

        /// <summary>
        /// 生成日志文件
        /// </summary>
        public void Generatelog()
        {
            StringBuilder LogContents = new StringBuilder();
            LogContents.AppendFormat("日志名称：{0}", Title).AppendLine()
                       .AppendFormat("创建时间：{0}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")).AppendLine();

            if (Login_Name != null && Login_Name.Length > 0)
                LogContents.AppendFormat("用户名：{0}", Login_Name).AppendLine();
            LogContents.AppendLine("日志内容：").Append(Content);
            CreateFile(DateTime.Now.ToString("yyyy_MM_dd(HH_mm_ss_ffffff)")+".txt", LogContents);
        }

        /// <summary>
        /// 创建文件
        /// </summary>
        /// <param name="fileName">文件名称（包括扩展名）</param>
        private void CreateFile(string fileName, StringBuilder logContents)
        {
            string folderPathUrl = string.Format("{0}/{1}{2}/{3}/{4}",
                Directory.GetCurrentDirectory(),
                ConfigurationManager.AppSettings["ErrorLog_FolderPathUrl"].ToString(),
                DateTime.Now.Year.ToString(),
                DateTime.Now.Month.ToString(),
                DateTime.Now.Day);

            if (!Directory.Exists(folderPathUrl))
                Directory.CreateDirectory(folderPathUrl);

            string filePathUrl = folderPathUrl + "/" + fileName;      //文件路径地址

            try
            {
                using (StreamWriter sw = new StreamWriter(filePathUrl, true))
                {
                    sw.WriteLine(logContents.ToString());
                }
            }
            catch
            {

            }
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

        ~Log_Error_Generate()
        {
            Dispose(false);
        }

        #endregion


    }
}
