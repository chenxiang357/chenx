using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx.UI
{
    public class Admin_Manage_UserControl : UserControl
    {


        /// <summary>
        /// 按钮图片
        /// </summary>
        /// <param name="ImagesUrl">图片地址</param>
        /// <returns></returns>
        protected Image ButtonImage(string ImagesUrl)
        {
            if (ImagesUrl != null && ImagesUrl.Length > 0)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + ImagesUrl))
                {
                    return Image.FromFile(Directory.GetCurrentDirectory() + ImagesUrl);
                }
            }
            return null;
        }

        //private void InitializeComponent()
        //{
        //    this.SuspendLayout();
        //    // 
        //    // AdminUserControl
        //    // 
        //    this.Name = "AdminUserControl";
        //    this.Size = new System.Drawing.Size(393, 321);
        //    this.ResumeLayout(false);

        //}
    }
}
