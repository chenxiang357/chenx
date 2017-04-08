using DatabaseOperating;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chenx.Log
{
    public class CallDatabase_Log : AbstractCallDatabase
    {
        private static string ConnectionString;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="type"></param>
        public CallDatabase_Log()
        {
            if (ConnectionString == null)
                ConnectionString = ConfigurationManager.ConnectionStrings["ChenxData"].ToString();
            InitConnection(ConnectionString);
        }

        /// <summary>
        /// 初始调用的化数据库
        /// </summary>
        protected override void NewDatabase()
        {
            Database = new SqlServerDatabase();
        }

        ~CallDatabase_Log()
        {
            Dispose(false);
        }
    }

}
