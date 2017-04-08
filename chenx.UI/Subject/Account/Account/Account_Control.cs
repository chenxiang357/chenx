using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using chenx.Model;
using System.Configuration;

namespace chenx.UI
{
    public partial class Account_Control : UserControl
    {
        private AccountNumber _AccountNumber_Entity;

        /// <summary>
        /// 实体
        /// </summary>
        public AccountNumber AccountNumber_Entity
        {
            get
            {
                if (_AccountNumber_Entity == null)
                {
                    _AccountNumber_Entity = new AccountNumber();
                }

                return Get_Entity(_AccountNumber_Entity);
            }
            set { Set_Entity(value); }
        }

        /// <summary>
        /// 账号分类
        /// </summary>
        public IEnumerable<IGrouping<string, string>> AccountType_Data
        {
            set
            {
                foreach (var item in value)
                {
                    AccountType_ComboBox.Items.Add(item.Key);
                }
            }
        }

        /// <summary>
        /// 是否显示密码
        /// </summary>
        public char PasswordChar
        {
            set { Paw_TextBox.PasswordChar = value; }
        }

        public Account_Control()
        {
            InitializeComponent();
        }

        private void Account_Control_Load(object sender, EventArgs e)
        {
         
        }

        /// <summary>
        /// 空间是否可用
        /// </summary>
        public bool Is_ReadOnly_Control
        {
            set
            {
                Name_TextBox.ReadOnly = value;
                UrlAddress_TextBox.ReadOnly = value;
                LogName_TextBox.ReadOnly = value;
                Paw_TextBox.ReadOnly = value;
                RegistrationDate_DateTimePicker.Enabled = !value;
                Description_TextBox.ReadOnly = value;
                Remarks_TextBox.ReadOnly = value;
                AccountType_ComboBox.Enabled = !value;
            }
        }

        /// <summary>
        /// 获取控件的值
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        private AccountNumber Get_Entity(AccountNumber entity)
        {
            entity.Name = Name_TextBox.Text;
            entity.UrlAddress = UrlAddress_TextBox.Text;
            entity.LogName = LogName_TextBox.Text;
            entity.Paw = Paw_TextBox.Text;
            entity.RegistrationDate = RegistrationDate_DateTimePicker.Value;
            entity.Description = Description_TextBox.Text;
            entity.Remarks = Remarks_TextBox.Text;
            entity.AccountType = AccountType_ComboBox.Text;
            entity.CreatedDate = DateTime.Now;
            entity.Id = Guid.NewGuid().ToString("N");
            return entity;
        }

        /// <summary>
        /// 给控件赋值
        /// </summary>
        /// <param name="entity">实体</param>
        private void Set_Entity(AccountNumber entity)
        {
            if (entity != null)
            {
                _AccountNumber_Entity = entity;
                Name_TextBox.Text = entity.Name;
                UrlAddress_TextBox.Text = entity.UrlAddress;
                LogName_TextBox.Text = entity.LogName;
                Paw_TextBox.Text = entity.Paw;
                RegistrationDate_DateTimePicker.Text = entity.RegistrationDate.ToString("yyyy-MM-dd");
                Description_TextBox.Text = entity.Description;
                Remarks_TextBox.Text = entity.Remarks;
                AccountType_ComboBox.Text = entity.AccountType;
            }
        }

    }
}
