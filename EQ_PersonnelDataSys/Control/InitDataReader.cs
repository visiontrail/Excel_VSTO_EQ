using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EQ_PersonnelDataSys;
using Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace EQ_PersonnelDataSys.Control
{
    /// <summary>
    /// 实现在WorkBook被打开的时候，在后台将数据全部读取到DataSet当中方便快速存取;
    /// </summary>
    class InitDataReader
    {
        public static DataSet InitReadExcelData()
        {
            DataSet ds = new DataSet();
            string connectionString = string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};" +
                "Extended Properties=Excel 8.0;", ThisAddIn.filepath);

            // 遍历当前Excel中的所有表;
            foreach (var sheetlist in Globals.ThisAddIn.Application.Worksheets)
            {
                string sheet_name = ((Worksheet)sheetlist).Name;

                // 获取这个WorkSheet，如果列数小于1的话，则不进行任何处理;
                Worksheet wst = ((Worksheet)Globals.ThisAddIn.Application.Worksheets[sheet_name]);
                if ((wst.UsedRange.Columns.Count == 1) || (wst.UsedRange.Count == 0))
                {
                    continue;
                }

                // 将所有表都保存到DataSet当中;
                // 保存到内存中，后续使用内存数据库查询会更快;
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    var dataTable = new System.Data.DataTable();
                    dataTable.TableName = sheet_name;
                    string query = string.Format("SELECT * FROM [{0}]", sheet_name + "$");
                    con.Open();

                    // 通过OleDB查询的数据填充到DataSet的DataTable当中;
                    OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);
                    adapter.Fill(dataTable);
                    ds.Tables.Add(dataTable);
                }
            }

            return ds;
        }
    }
}
