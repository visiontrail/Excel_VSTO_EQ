using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
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
        /// 通过VSTO按钮获取Sheet页中的相关信息;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Get_Sheet_Info_Click(object sender, RibbonControlEventArgs e)
        {
            // ____________________获取Sheet的方式____________________________:
           Worksheet wst = ((Worksheet)Globals.ThisAddIn.Application.ActiveSheet);                     // 获取当前的Sheet页;
            //Excel.Sheets st = (Excel.Sheets)Globals.ThisAddIn.Application.Sheets["考核情况"];

            try
            {
                Worksheet wst2 = ((Worksheet)Globals.ThisAddIn.Application.Worksheets["考核情况"]);     // 根据名称获取Sheet页;

                // 获取表中单元格内容;
                var content = wst2.Range["A1"].Value;
                List<string> all_index = new List<string>();
                List<string> all_column = new List<string>();

                // 操作Sheet表:
                Range cell = wst.Range["A8"];
                cell.Value2 = "123";

                int count_num = wst2.UsedRange.Rows.Count;
                int columns_num = wst2.UsedRange.Columns.Count;

                // 取出这个表所有的列;
                foreach (Range all_col in wst2.UsedRange.Columns)
                {
                    all_column.Add(all_col.Value2[1, 1]);
                }


                //foreach (var column_name in wst2.Rows[0])
                //{
                //    if(column_name == null)
                //    {
                //        break;
                //    }
                //    all_column.Add(column_name);
                //}

            }
            catch
            {
                MessageBox.Show("没有考核情况表，请检查");
            }

            // ____________________读取Sheet表____________________________:

            // 获取表名;
            foreach (var sheetlist in Globals.ThisAddIn.Application.Worksheets)
            {
                m_AllSheets.Add(((Worksheet)sheetlist).Name);
            }
            

            
        }
    }
}
