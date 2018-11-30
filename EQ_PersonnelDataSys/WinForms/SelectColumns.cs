using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
            // 实验代码，遍历了所有表所有行的所有数据;
            //foreach (DataTable dt in EQ_Ribbon.ds.Tables)
            //{
            //    foreach (DataRow dr in dt.Rows)
            //        foreach (DataColumn dc in dt.Columns)
            //            Console.WriteLine("1:" + dt.TableName + "2:" + dc.ColumnName + "3:" + dr[dc]);
            //}
            string connectionString = string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};" +
                "Extended Properties=Excel 8.0;", ThisAddIn.filepath);

            DataSet ds = new DataSet();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                var dataTable = new System.Data.DataTable();
                //string query = string.Format("SELECT * FROM [{0}]", "考核情况" + "$" + "left join [政治面貌$]");
                string query = string.Format("SELECT [政治面貌$].姓名, [政治面貌$].政治面貌, [考核情况$].考核结果" +
                    " FROM [政治面貌$], [考核情况$]" +
                    " WHERE [政治面貌$].姓名 = [考核情况$].姓名 ");

                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);

                adapter.Fill(dataTable);
                ds.Tables.Add(dataTable);
                con.Close();
            }

            foreach (DataTable dt in ds.Tables)
            {
                foreach (DataRow dr in dt.Rows)
                    foreach (DataColumn dc in dt.Columns)
                        Console.WriteLine("1:" + dt.TableName + "2:" + dc.ColumnName + "3:" + dr[dc]);
            }

        }
    }
}
