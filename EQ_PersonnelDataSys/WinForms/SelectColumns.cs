using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQ_PersonnelDataSys.WinForms
{
    /// <summary>
    /// 用于用户选择Excel表格中已经存在的数据表;
    /// </summary>
    public partial class SelectColumns : Form
    {
        /// <summary>
        /// 保存数据;
        /// Key：数据表;
        /// Value：数据表包含的列;
        /// </summary>
        private Dictionary<string, List<string>> all_data = new Dictionary<string, List<string>>();


        public SelectColumns(Dictionary<string, List<string>> add_db_name)
        {
            InitializeComponent();
            all_data = add_db_name;

            this.all_db.DataSource = add_db_name.Keys.ToList();
            this.all_db.SelectedIndexChanged += All_db_SelectedIndexChanged;
            
        }

        private void All_db_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleted = (sender as ListBox).SelectedItem.ToString();
            
            this.all_col.DataSource = all_data[seleted];

        }

        /// <summary>
        /// 用户选择列;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sel_Column_Click(object sender, EventArgs e)
        {
            if(Template_Col.Items.Contains(all_col.SelectedItem.ToString()))
            {
                MessageBox.Show("已选择相同项!");
            }
            this.Template_Col.Items.Add(this.all_col.SelectedItem.ToString());
        }

        /// <summary>
        /// 删除已经选择好的列;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Del_Column_Click(object sender, EventArgs e)
        {
            this.Template_Col.Items.Remove(this.Template_Col.SelectedItem.ToString());
        }

        /// <summary>
        /// 保存数据模板;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Template_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 用户选择完成想要查询的列，开始进行查询;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Confirm_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = EQ_Ribbon.ds.Tables[0];
            DataRow[] dtRow = dt.Select("姓名=安艳芬"); //根据查询条件，筛选出所有满足条件的列
            foreach (DataRow item in dtRow)//把满足条件的所有列赛到新表中
            {
                //item.ItemArray;
            }
        }
    }
}
