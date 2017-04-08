using chenx.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace chenx.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class LogError_BLL
    {

        /// <summary>
        /// 返回文件价目录列表
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public IEnumerable<int> Get_Folder_List(string url)
        {
            return Folder_Sort(Directory.GetDirectories(url));
        }

        /// <summary>
        /// 文件列表
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public IList<ErrorLog_FileInfo> GetEntityList(string url)
        {
            return ErrorLogList(Directory.GetFiles(url, "*.txt")).ToList();
        }

        /// <summary>
        /// 文件夹排序
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        private IEnumerable<int> Folder_Sort(string[] v)
        {
            int[] data = new int[v.Count()];
            for (int i = 0; i < v.Length; i++)
                data[i] = int.Parse(Path.GetFileName(v[i]));
            return data.OrderBy(o => o);
        }

        /// <summary>
        /// 错误日志文件列表
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private IEnumerable<ErrorLog_FileInfo> ErrorLogList(string[] data)
        {
            foreach (var item in data.OrderByDescending(o => o))
                yield return new ErrorLog_FileInfo()
                {
                    FilePathUrl = item,
                    FileTitle = Path.GetFileNameWithoutExtension(item),
                };
        }

    }
}
