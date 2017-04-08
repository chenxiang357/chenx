using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace chenx.UI
{
    /// <summary>
    /// 绑定方法（扩展）
    /// </summary>
    public static class BindingComboBox
    {

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="bindingControls">控件</param>
        /// <param name="dataArray">数组</param>
        /// <returns></returns>
        public static ComboBox BindingData<T>(this ComboBox bindingControls, T[] dataArray)
        {
            bindingControls.DataSource = dataArray;
            return bindingControls;
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="bindingControls">控件</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static ComboBox BindingData<T>(this ComboBox bindingControls, IEnumerable<T> data)
        {
            bindingControls.DataSource = data;
            return bindingControls;
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="bindingControls">控件</param>
        /// <param name="dataList">数据列表</param>
        /// <param name="value">值</param>
        /// <returns></returns>
        public static ComboBox BindingData(this ComboBox bindingControls, DataTable dataList, string value)
        {
            bindingControls.DataSource = dataList;
            bindingControls.DisplayMember = value;
            bindingControls.ValueMember = value;
            return bindingControls;
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <param name="bindingControls">控件</param>
        /// <param name="dataList">数据列表</param>
        /// <param name="value">值</param>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static ComboBox BindingData(this ComboBox bindingControls, DataTable dataList, string value, string key)
        {
            bindingControls.DataSource = dataList;
            bindingControls.DisplayMember = value;
            bindingControls.ValueMember = key;
            return bindingControls;
        }

        /// <summary>
        /// 绑定数据
        /// </summary>
        /// <typeparam name="T">实体</typeparam>
        /// <param name="bindingControls">控件</param>
        /// <param name="dataList">数据列表</param>
        /// <param name="value">值</param>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static ComboBox BindingData<T>(this ComboBox bindingControls,  IEnumerable<T> dataList, string value, string key)
        {
            bindingControls.DataSource = dataList;
            bindingControls.DisplayMember = value;
            bindingControls.ValueMember = key;
            return bindingControls;
        }

        /// <summary>
        /// 默认选择第一行
        /// </summary>
        /// <param name="bindingControls"></param>
        /// <returns></returns>
        public static ComboBox SelectedOne(this ComboBox bindingControls)
        {
            bindingControls.SelectedIndex = (bindingControls.Items.Count > 0 ? 0 : -1);
            return bindingControls;
        }

        /// <summary>
        /// 默认选中值
        /// </summary>
        /// <param name="bindingControls">控件</param>
        /// <param name="key">键</param>
        /// <returns></returns>
        public static ComboBox Selected(this ComboBox bindingControls, string key = "")
        {
            bindingControls.SelectedValue = key;
            return bindingControls;
        }

    }
}
