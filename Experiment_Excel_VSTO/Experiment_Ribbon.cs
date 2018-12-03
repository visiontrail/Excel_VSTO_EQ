using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
using ExcelTools = Microsoft.Office.Tools;
using System.Windows.Forms;


namespace Experiment_Excel_VSTO
{
    public partial class Experiment_Ribbon
    {
        private List<string> m_AllSheets;

        private void Experiment_Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            // 初始化数据;
            m_AllSheets = new List<string>();
        }

        /// <summary>
        /// 基础：读写Excel表中的信息;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Get_Sheet_Info_Click(object sender, RibbonControlEventArgs e)
        {
            // ____________________获取Sheet的方式____________________________:
           Worksheet wst = ((Worksheet)Globals.ThisAddIn.Application.ActiveSheet);                     // 获取当前选中的Sheet页;

            // 读写某一个Sheet表中的数据;
            try
            {
                Worksheet wst2 = ((Worksheet)Globals.ThisAddIn.Application.Worksheets["考核情况"]);     // 根据名称获取Sheet页;

                // 获取表中单元格内容;
                var content = wst2.Range["A1"].Value;
                List<string> all_index = new List<string>();
                List<string> all_column = new List<string>();

                // 写入Sheet表中的单元格:
                ((Range)wst.Range["A8"]).Value = "111";

                // 删除某一行;
                ((Range)wst2.Rows[2, Type.Missing]).Delete(XlDeleteShiftDirection.xlShiftToLeft);

                // 删除一列数据;
                ((Range)wst2.Cells[1, 2]).EntireColumn.Delete(0);

                // 选择一个单元格;
                ((Range)wst2.Cells[1, 2]).Select();

                int count_num = wst2.UsedRange.Rows.Count;
                int columns_num = wst2.UsedRange.Columns.Count;

                // 取出这个表所有的列;
                // 如果不用UsedRange的话，就会获取到Excel包含空白的所有列;
                foreach (Range all_col in wst2.UsedRange.Columns)
                {
                    all_column.Add(all_col.Value2[1, 1]);
                }
                
            }
            catch
            {
                MessageBox.Show("没有考核情况表，请检查");
            }

            // ____________________读取Sheet表____________________________:

            // 获取当前Excel表的所有表名;
            foreach (var sheetlist in Globals.ThisAddIn.Application.Worksheets)
            {
                m_AllSheets.Add(((Worksheet)sheetlist).Name);
            }
            
        }
        
        /// <summary>
        /// 通过SQL语句获取数据，并保存到DataSet的DataTable当中;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetDatatoDataSet_Click(object sender, RibbonControlEventArgs e)
        {
            // OleDB获取Excel数据库;
            string connectionString = string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};" +
                "Extended Properties=Excel 8.0;", ThisAddIn.filepath);

            // 创建一个DataSet;
            DataSet ds = new DataSet();

            // 创建一个新的Sheet页;
            Worksheet wst;
            wst = (Worksheet)Globals.ThisAddIn.Application.Worksheets.Add();     
            wst.Name = "新建Sheet页";

            // 添加一个ListObject到WorkSheet;
            ExcelTools.Excel.Worksheet worksheet = Globals.Factory.GetVstoObject(wst);
            ExcelTools.Excel.ListObject list1;
            Range cell = worksheet.Range["$A$1:$Z$9999"];
            list1 = worksheet.Controls.AddListObject(cell, "list1");
            list1.AutoSetDataBoundColumnHeaders = true;

            // 通过OleDB联表查询;
            using (OleDbConnection con = new OleDbConnection(connectionString))
            {
                var dataTable = new System.Data.DataTable();
                //string query = string.Format("SELECT * FROM [{0}]", "考核情况" + "$" + "left join [政治面貌$]");
                //string query = string.Format("SELECT [政治面貌$].姓名, [政治面貌$].政治面貌, [考核情况$].考核结果,[考核情况$].考核时间, [行政职务$].职务层次, [行政职务$].职务名称" +
                //    " FROM [政治面貌$],[考核情况$],[行政职务$]" +
                //    " WHERE [政治面貌$].姓名 = [考核情况$].姓名 AND [政治面貌$].姓名 = [行政职务$].姓名");

                string query = string.Format("SELECT [政治面貌$].姓名, [政治面貌$].政治面貌, [考核情况$].考核结果,[考核情况$].考核时间, [行政职务$].职务层次, [行政职务$].职务名称" +
                    " FROM [政治面貌$],[考核情况$],[行政职务$]" +
                    " WHERE [政治面貌$].姓名 = [考核情况$].姓名");

                //string query = string.Format("SELECT [政治面貌$].姓名, [政治面貌$].政治面貌, [考核情况$].考核结果,[考核情况$].考核时间, [行政职务$].职务层次, [行政职务$].职务名称" +
                //    " FROM [政治面貌$] as A INNER JOIN [考核情况$] as B" +
                //    " ON A.姓名=B.姓名 INNER JOIN [行政职务$] as C ON A.姓名=C.姓名 ORDER BY A.姓名");

                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);

                adapter.Fill(dataTable);
                ds.Tables.Add(dataTable);
                con.Close();

                list1.SetDataBinding(dataTable, null, "姓名","考核时间", "政治面貌", "考核结果", "职务层次", "职务名称");
            }

            // 循环遍历DataTable当中的所有数据，并打印(但是在Excel开发中好像打印不出来……);
//             foreach (System.Data.DataTable dt in ds.Tables)
//             {
//                 foreach (DataRow dr in dt.Rows)
//                     foreach (DataColumn dc in dt.Columns)
//                         Console.WriteLine("1:" + dt.TableName + "2:" + dc.ColumnName + "3:" + dr[dc]);
//             }
        }

        /// <summary>
        /// 新建一个Sheet页;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void new_sheet_Click(object sender, RibbonControlEventArgs e)
        {
            Worksheet wst;

            wst = (Worksheet)Globals.ThisAddIn.Application.Worksheets.Add();
            wst.Name = "新建Sheet页";
        }

    }
}
