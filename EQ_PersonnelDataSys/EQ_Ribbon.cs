using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
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
            SelectColumns sc_window = new SelectColumns();
            sc_window.Show();
        }
    }
}
