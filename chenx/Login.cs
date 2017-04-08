using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx
{
    public partial class Login : Form
    {

        //窗体的位置;
        private Point p;        //点击之后的坐标（窗体之内的坐标）

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //System_Title_Label.Font = new Font("隶书", 18);
        }

        #region 窗体移动

        /// <summary>
        /// 鼠标按下时的操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                p = new Point(e.X, e.Y);
            }
        }

        /// <summary>
        /// 鼠标移动，窗体跟随
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                Point tt = new Point(p.X - e.X, p.Y - e.Y);
                this.Location = new Point(this.Location.X - tt.X, this.Location.Y - tt.Y);
            }
        }

        #endregion

        private void EixtButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Index i = new Index();
            i.Show();
        }

     
    }
}
