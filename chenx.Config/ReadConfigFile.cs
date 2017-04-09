using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Config
{
    /// <summary>
    /// 读取配置文件
    /// </summary>
    public class ReadConfigFile
    {
        /// <summary>
        /// 用户登陆信息
        /// </summary>
        public static User_Login_Config UserLongInfo { get; set; }

        /// <summary>
        /// 文本配置
        /// </summary>
        public static TextConfigInfo Text_Config { get; set; }

        /// <summary>
        /// 读取文本配置
        /// </summary>
        /// <param name="entity"></param>
        public void Read_Text_Contents(TextConfigInfo entity)
        {
            if (entity != null)
            {
                Text_Config = entity;
            }
            else
            {
                Text_Config = new TextConfigInfo();
            }
        }
    }
}
