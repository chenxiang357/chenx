using chenx.Log;
using chenx.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace chenx.DAL
{
    public class Account_DAL
    {
        /// <summary>
        /// 地址路劲
        /// </summary>
        private string UrlPath;

        public Account_DAL()
        {
            UrlPath = Directory.GetCurrentDirectory() + ConfigurationManager.AppSettings["StorageAddress"];
        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Add(string value)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(FileGeneration,value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
            return 1;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Update(string value)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(FileGeneration, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
            return 1;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="value"></param>
        /// <returns>-1为失败/大于-1为成功</returns>
        public int Delete(string value)
        {
            try
            {
                ThreadPool.QueueUserWorkItem(FileGeneration, value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return -1;
            }
            return 1;
        }

        /// <summary>
        /// 实体列表
        /// </summary>
        /// <returns>返回实体列表</returns>
        public string QueryData()
        {
            try
            {
                if (File.Exists(UrlPath))
                {
                    return File.ReadAllText(UrlPath);
                }
                else
                {
                    return "[]";
                }
            }
            catch (Exception ex)
            {
                using (ILog_Error log = new Log_Error_Generate())
                {
                    log.Title = ex.Message;
                    log.Content = ex.StackTrace;
                    log.Generatelog();
                }
                return "[]";
            }
        }

        /// <summary>
        /// 文件生成
        /// </summary>
        private void FileGeneration(object obj)
        {
            FileStream s = File.Create(UrlPath);
            byte[] contents = new UTF8Encoding(true).GetBytes(obj.ToString());
            s.Write(contents, 0, contents.Length);
            s.Close();
        }

    }
}
