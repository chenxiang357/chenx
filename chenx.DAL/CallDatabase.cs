using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DatabaseOperating;
using System.Configuration;

namespace chenx.DAL
{

    public class CallDatabase : AbstractCallDatabase
    {

        private static string ConnectionString;

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="type"></param>
        public CallDatabase()
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
        
        ~CallDatabase()
        {
            Dispose(false);
        }

    }
}
