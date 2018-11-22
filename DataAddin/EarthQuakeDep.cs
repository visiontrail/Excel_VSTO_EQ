﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;

namespace DataAddin
{
    public partial class EarthQuakeDep
    {
        private void EarthQuakeDep_Load(object sender, RibbonUIEventArgs e)
        {
        }

        /// <summary>
        /// 选择所有表格对应的列，并生成新的表格;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectColums_Click(object sender, RibbonControlEventArgs e)
        {
            Excel.Worksheet wst = ((Excel.Worksheet)Globals.ThisAddIn.Application.ActiveSheet);
            Excel.Range cell = wst.Range["A1"];
            cell.Value2 = "123";
        }
    }
}
