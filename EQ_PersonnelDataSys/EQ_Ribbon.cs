using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
using EQ_PersonnelDataSys.WinForms;

namespace EQ_PersonnelDataSys
{
    public partial class EQ_Ribbon
    {
        
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

            // 获取表名;
            foreach (var sheetlist in Globals.ThisAddIn.Application.Worksheets)
            {
                string sheet_name = ((Worksheet)sheetlist).Name;
                List<string> all_column = new List<string>();

                // 获取这个WorkSheet;
                Worksheet wst = ((Worksheet)Globals.ThisAddIn.Application.Worksheets[sheet_name]);

                if((wst.UsedRange.Columns.Count == 1) || (wst.UsedRange.Count == 0))
                {
                    continue;
                }

                // 取出这个表所有的列;
                foreach (Range all_col in wst.UsedRange.Columns)
                {
                    var temp = all_col.Value2;
                    try
                    {
                        string ret = (string)all_col.Value2[1, 1];
                        all_column.Add(ret);
                    }
                    catch
                    {

                    }
                }

                DbColumnPairs.Add(((Worksheet)sheetlist).Name, all_column);
            }

            SelectColumns sc_window = new SelectColumns(DbColumnPairs);
            sc_window.Show();
        }
    }
}
