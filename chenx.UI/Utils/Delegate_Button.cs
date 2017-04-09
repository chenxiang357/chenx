using chenx.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace chenx.UI
{
    /// <summary>
    /// 表格中委托
    /// </summary>
    /// <param name="id">主键</param>
    public delegate void Button_Click_Id(string id);

    /// <summary>
    /// 分页绑定数据
    /// </summary>
    /// <param name="pageIndex">当前页</param>
    public delegate void Paging_DataGridView(int pageIndex);

    /// <summary>
    /// 读取账号委托
    /// </summary>
    /// <param name="id">主键</param>
    public delegate void Read_AccountNumber(string id);

    /// <summary>
    /// 单击树形节点
    /// </summary>
    /// <param name="nodes">节点</param>
    public delegate void Click_TreeNode(TreeNode nodes);

    /// <summary>
    /// 委托文本
    /// </summary>
    /// <param name="value">值</param>
    public delegate void DelegateString(string value);

    ///// <summary>
    ///// 弹出窗口
    ///// </summary>
    ///// <param name="Id">主键</param>
    //public delegate void Click_Delegate(string id);

    public class Delegate_Button
    {

    }
}
