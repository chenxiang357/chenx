using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace chenx.Config
{
    /// <summary>
    /// 文本配置信息
    /// </summary>
    public class TextConfigInfo
    {
        private string _LoginTitle;

        /// <summary>
        /// 登陆标题
        /// </summary>
        public string LoginTitle
        {
            get
            {
                if (_LoginTitle!=null && _LoginTitle.Length>0)
                {
                    return _LoginTitle;
                }
                return "登录";
            }
            set { _LoginTitle = value; }
        }

        private string _LoginTitleFont;

        /// <summary>
        /// 登陆标题字体
        /// </summary>
        public string LoginTitleFont
        {
            get
            {
                if (_LoginTitleFont != null && _LoginTitleFont.Length > 0)
                {
                    return _LoginTitleFont;
                }
                return "宋体";
            }
            set { _LoginTitleFont = value; }
        }

        private int _LoginTitleFontSize;

        /// <summary>
        /// 登陆标题字体大小
        /// </summary>
        public int LoginTitleFontSize
        {
            get
            {
                if (_LoginTitleFontSize > 0)
                {
                    return _LoginTitleFontSize;
                }
                return 12;
            }
            set { _LoginTitleFontSize = value; }
        }

        private string _SystemName;

        /// <summary>
        /// 系统名称
        /// </summary>
        public string SystemName
        {
            get
            {
                if (_SystemName != null && _SystemName.Length > 0)
                {
                    return _SystemName;
                }
                return "系统名称";
            }
            set { _SystemName = value; }
        }

        private string _MenuBarName;

        /// <summary>
        /// 菜单栏名称
        /// </summary>
        public string MenuBarName
        {
            get
            {
                if (_MenuBarName != null && _MenuBarName.Length > 0)
                {
                    return _MenuBarName;
                }
                return "菜单栏名称";
            }
            set { _MenuBarName = value; }
        }

    }
}
