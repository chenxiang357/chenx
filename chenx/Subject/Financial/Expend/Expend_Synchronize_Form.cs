using chenx.BLL;
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
    public partial class Expend_Synchronize_Form : BasicSettingsForm
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 支付类型
        /// </summary>
        public DataTable Binding_Parameter_Data
        {
            set { expend_Controls1.Binding_Parameter_Data = value; }
        }


        private Expend_BLL Expend;

        public Expend_Synchronize_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            Expend = new Expend_BLL();
            var entity = Expend.Get_Entity(int.Parse(Id));
            entity.ExpendDate = DateTime.Now;
            expend_Controls1.Expend_Entity = entity;
            base.OnLoad(e);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var entity = expend_Controls1.Expend_Entity;
            if (Expend.RepeatVerify_Add(entity))
            {
                if (Expend.Add(entity) > -1)
                {
                    expend_Controls1.Dispose();
                    this.DialogResult = MessageBox.Show("复制支出成功!", "支出提示", MessageBoxButtons.OK); //DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show(Expend.Messages, "支出提示");
            }
        }

    }
}
