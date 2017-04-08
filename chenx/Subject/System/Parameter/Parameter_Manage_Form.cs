using chenx.BLL;
using chenx.Model;
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
    public partial class Parameter_Manage_Form : BasicSettingsForm
    {
        private ParameterName_BLL ParameterName;

        private ParameterValue_BLL ParameterValueBLL;

        /// <summary>
        /// 当前选中的节点
        /// </summary>
        private TreeNode SelectedNode { get; set; }

        public Parameter_Manage_Form()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            parameter_Name_Manage_Controls1.UpdateClick = UpdateClick;        //更新委托
            parameter_Name_Manage_Controls1.StateCheckData = Parameter_Name_StateCheckData;  //显示当前状态数据列表
            parameter_Name_Manage_Controls1.Click_Node = TreeNodes_NodeClick; //单击节点委托
            parameter_Name_Manage_Controls1.StatusUpdateClick = Parameter_Name_StateUpdate;   //状态更新委托

            parameter_Value_Manage_Controls1.StateCheckData = StateCheckData_Parametere_Value;  // 参数值根据状态显示数据委托
            parameter_Value_Manage_Controls1.DataGridView_Update_Button = Parameter_Value_Update_Click; //参数值-点击更新图片来修改参数值
            parameter_Value_Manage_Controls1.DataGridView_Status_Button = Parameter_Value_Status_Click; //参数值-点击启用或禁用

            ParameterName = new ParameterName_BLL();
            ParameterValueBLL = new ParameterValue_BLL();
            parameter_Name_Manage_Controls1.EntityList = ParameterName.Get_Enabled_Data();
            base.OnLoad(e);
        }

        #region 参数名称

        /// <summary>
        /// 添加参数名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parameter_Name_Add_Click(object sender, EventArgs e)
        {
            Parameter_Name_Add_Form parameter_Name_Add = new Parameter_Name_Add_Form();
            parameter_Name_Add.ParameterName = ParameterName;
            if (parameter_Name_Add.ShowDialog() == DialogResult.OK)
            {
                if (parameter_Name_Manage_Controls1.Status == "1")
                {
                    parameter_Name_Manage_Controls1.EntityList = ParameterName.Get_Data("1");
                }
            }
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="id">主键</param>
        private void UpdateClick(string id)
        {
            Parameter_Name_Update_Form parameter_Name_Updates = new Parameter_Name_Update_Form();
            parameter_Name_Updates.ParameterName = ParameterName;
            parameter_Name_Updates.Id = Convert.ToInt32(id);
            if (parameter_Name_Updates.ShowDialog() == DialogResult.OK)
            {
                parameter_Name_Manage_Controls1.EntityList = ParameterName.Get_Data(parameter_Name_Manage_Controls1.Status);
            }
        }

        /// <summary>
        /// 显示状态数据
        /// </summary>
        /// <param name="state">状态</param>
        private void Parameter_Name_StateCheckData(string state)
        {
            parameter_Name_Manage_Controls1.EntityList = ParameterName.Get_Data(state);
            parameter_Value_Manage_Controls1.ParameterValue_Entity_List = null;
            SelectedNode = null;
        }

        /// <summary>
        /// 状态更新委托
        /// </summary>
        /// <param name="id">主键</param>
        private void Parameter_Name_StateUpdate(string id)
        {
            string status = parameter_Name_Manage_Controls1.Status;
            ParameterName.UpdateStatus((status == "1" ? "0" : "1"), Convert.ToInt32(id));
            parameter_Name_Manage_Controls1.EntityList = ParameterName.Get_Data(status);
            SelectedNode = null;
        }

        /// <summary>
        /// 单击树形节点
        /// </summary>
        /// <param name="nodes">节点</param>
        private void TreeNodes_NodeClick(TreeNode nodes)
        {
            if (ParameterValueBLL == null)
                ParameterValueBLL = new ParameterValue_BLL();
            SelectedNode = nodes;
            ParameterValueBLL.Get_Entity_List(Convert.ToInt32(SelectedNode.Name));
            StateCheckData_Parametere_Value(parameter_Value_Manage_Controls1.Status);
        }

        #endregion

        #region 参数值

        /// <summary>
        /// 参数值显示
        /// </summary>
        /// <param name="state">状态</param>
        private void StateCheckData_Parametere_Value(string state)
        {
            parameter_Value_Manage_Controls1.ParameterValue_Entity_List = ParameterValueBLL.Get_Status_Data(state);
        }

        /// <summary>
        /// 参数值添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Parameter_Value_Add_Click(object sender, EventArgs e)
        {
            if (SelectedNode != null)
            {
                Parameter_Value_Add_Form parameter_Value_Add = new Parameter_Value_Add_Form();
                parameter_Value_Add.P_Id = Convert.ToInt32(parameter_Name_Manage_Controls1.SelectedNodes.Name);
                parameter_Value_Add.ParameterName = parameter_Name_Manage_Controls1.SelectedNodes.Text;
                parameter_Value_Add.ParameterValueBLL = ParameterValueBLL;
                if (parameter_Value_Add.ShowDialog() == DialogResult.OK)
                {
                    StateCheckData_Parametere_Value(parameter_Value_Manage_Controls1.Status);
                }
            }
            else
            {
                MessageBox.Show("请先选择参数名称！", "参数名称提醒");
            }
        }

        /// <summary>
        /// 参数值更新
        /// </summary>
        /// <param name="id">主键</param>
        private void Parameter_Value_Update_Click(string id)
        {
            Parameter_Value_Update_Form Parameter_Value_Update = new Parameter_Value_Update_Form();
            Parameter_Value_Update.ParameterName = SelectedNode.Text;
            Parameter_Value_Update.Id = Convert.ToInt32(id);
            Parameter_Value_Update.ParameterValueBLL = ParameterValueBLL;
            if (Parameter_Value_Update.ShowDialog() == DialogResult.OK)
            {
                parameter_Value_Manage_Controls1.ParameterValue_Entity_List = ParameterValueBLL.Get_Status_Data(parameter_Value_Manage_Controls1.Status); ;
            }
        }

        /// <summary>
        /// 参数值更新
        /// </summary>
        /// <param name="id">主键</param>
        private void Parameter_Value_Status_Click(string id)
        {
            string status = parameter_Value_Manage_Controls1.Status;
            ParameterValueBLL.UpdateStatus((status == "1" ? "0" : "1"), Convert.ToInt32(id));
            parameter_Value_Manage_Controls1.ParameterValue_Entity_List = ParameterValueBLL.Get_Status_Data(status);
        }

        #endregion

    }
}
