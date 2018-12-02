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
using Microsoft.Office.Tools;
using EQ_PersonnelDataSys.Model;

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
        private Dictionary<string, List<Column>> all_data = new Dictionary<string, List<Column>>();
        ColumnTemplate columnTemplate = new ColumnTemplate();
        List<Column> columns = new List<Column>();

        public SelectColumns(Dictionary<string, List<Column>> add_db_name)
        {
            InitializeComponent();
            all_data = add_db_name;

            this.all_db.DataSource = add_db_name.Keys.ToList();
            this.all_db.SelectedIndexChanged += All_db_SelectedIndexChanged;
            
        }

        /// <summary>
        /// 当用户选择表之后;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void All_db_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = (sender as ListBox).SelectedItem.ToString();
            
            // 数据Binding并确认需要显示的内容;
            this.all_col.DataSource = all_data[selected];
            this.all_col.DisplayMember = "ColumnName";
        }

        /// <summary>
        /// 用户选择列;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sel_Column_Click(object sender, EventArgs e)
        {
            if(Template_Col.Items.Contains(all_col.SelectedItem))
            {
                MessageBox.Show("已选择相同项!");
            }

            this.Template_Col.Items.Add(this.all_col.SelectedItem);
            this.Template_Col.DisplayMember = "ColumnName";

            // 每一次用户选择，都把它保存到columns当中;
            columns.Add(this.all_col.SelectedItem as Column);
        }

        /// <summary>
        /// 删除已经选择好的列;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Del_Column_Click(object sender, EventArgs e)
        {
            Column Rm_column = this.Template_Col.SelectedItem as Column;

            if(columns.Remove(Rm_column))
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Fail!");
            }

            this.Template_Col.Items.Remove(this.Template_Col.SelectedItem);
        }

        /// <summary>
        /// 保存数据模板;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Template_Click(object sender, EventArgs e)
        {
            SaveTemplate st_window = new SaveTemplate(columns);
            st_window.Show();
        }

        /// <summary>
        /// 用户选择完成想要查询的列，开始进行查询;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Confirm_Click(object sender, EventArgs e)
        {
            // 连接当前打开的文档到OleDB;
            string connectionString = string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};" +
                "Extended Properties=Excel 8.0;", ThisAddIn.filepath);

            DataSet ds = new DataSet();

            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                var dataTable = new System.Data.DataTable();

                string query = string.Format("SELECT [政治面貌$].姓名, [政治面貌$].政治面貌, [考核情况$].考核结果" +
                    " FROM [政治面貌$], [考核情况$]" +
                    " WHERE [政治面貌$].姓名 = [考核情况$].姓名 ");

                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);

                adapter.Fill(dataTable);
                ds.Tables.Add(dataTable);
                con.Close();
            }
            
        }
    }
}
