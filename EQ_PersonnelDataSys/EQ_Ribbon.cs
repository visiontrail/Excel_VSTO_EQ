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
using EQ_PersonnelDataSys.Model;

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
            Dictionary<string, List<Column>> DbColumnPairs = new Dictionary<string, List<Column>>();

            // 获取打开工作表的所有表的名字;
            foreach (var sheetlist in Globals.ThisAddIn.Application.Worksheets)
            {
                string sheet_name = ((Worksheet)sheetlist).Name;
                List<Column> all_column = new List<Column>();

                // 获取这个WorkSheet，如果列数小于1的话，则不进行任何处理;
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
                        // 地震局人事系统专用：如果是姓名则不显示，默认用它作为索引;
                        string ret = (string)all_col.Value2[1, 1];
                        if(ret == "姓名")
                        {
                            continue;
                        }

                        Column column = new Column();
                        column.ColumnName = ret;
                        column.TableName = sheet_name;
                        all_column.Add(column);
                    }
                    catch
                    {

                    }
                }

                // 将表和表包含的列填入一个字典中;
                DbColumnPairs.Add(sheet_name, all_column);
            }
            
            SelectColumns sc_window = new SelectColumns(DbColumnPairs);
            sc_window.Show();
        }

        /// <summary>
        /// 弹出选择模板的对话框;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Select_Template_Click(object sender, RibbonControlEventArgs e)
        {
            SelectTemplate window = new SelectTemplate();
            window.Show();
        }
    }
}
