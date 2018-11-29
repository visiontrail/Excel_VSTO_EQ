using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
using EQ_PersonnelDataSys.WinForms;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace EQ_PersonnelDataSys
{
    public partial class EQ_Ribbon
    {
        public static DataSet ds = new DataSet();

        private void EQ_Ribbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        /// <summary>
        /// 选择所有表格对应的列，并生成新的表格;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_Column_Click(object sender, RibbonControlEventArgs e)
        {
            Dictionary<string, List<string>> DbColumnPairs = new Dictionary<string, List<string>>();
            string connectionString = string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};" +
                "Extended Properties=Excel 8.0;", ThisAddIn.filepath);

            // 获取打开工作表的所有表的名字;
            foreach (var sheetlist in Globals.ThisAddIn.Application.Worksheets)
            {
                string sheet_name = ((Worksheet)sheetlist).Name;
                List<string> all_column = new List<string>();

                // 获取这个WorkSheet，如果列数小于1的话，则不进行任何处理;
                Worksheet wst = ((Worksheet)Globals.ThisAddIn.Application.Worksheets[sheet_name]);
                if((wst.UsedRange.Columns.Count == 1) || (wst.UsedRange.Count == 0))
                {
                    continue;
                }

                // 将所有表都保存到DataSet当中;
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    var dataTable = new System.Data.DataTable();
                    string query = string.Format("SELECT * FROM [{0}]", sheet_name + "$");
                    con.Open();
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    
                    adapter.Fill(dataTable);
                    ds.Tables.Add(dataTable);
                }

                // 取出这个表所有的列;
                foreach (Range all_col in wst.UsedRange.Columns)
                {
                    var temp = all_col.Value2;
                    try
                    {
                        // 如果是姓名则不显示，默认用它作为索引;
                        string ret = (string)all_col.Value2[1, 1];
                        if(ret == "姓名")
                        {
                            continue;
                        }
                        all_column.Add(ret);
                    }
                    catch
                    {

                    }
                }

                // 将表和表包含的列填入一个字典中;
                DbColumnPairs.Add(((Worksheet)sheetlist).Name, all_column);
            }
            
            SelectColumns sc_window = new SelectColumns(DbColumnPairs);
            sc_window.Show();
        }

        private void Select_Template_Click(object sender, RibbonControlEventArgs e)
        {
            System.Data.DataTable dt = ds.Tables["考核情况$"];
            DataRow[] dtRow = dt.Select("姓名=‘安艳芬’"); //根据查询条件，筛选出所有满足条件的列
            foreach (DataRow item in dtRow)//把满足条件的所有列赛到新表中
            {
                //item.ItemArray;
            }
        }
    }
}
