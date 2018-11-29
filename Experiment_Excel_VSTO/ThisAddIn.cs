using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;

namespace Experiment_Excel_VSTO
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO 生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
            this.Application.WorkbookOpen += Application_WorkbookOpen;
            this.Application.SheetChange += Application_SheetChange;
            this.Application.SheetActivate += Application_SheetActivate;
            this.Application.WorkbookBeforeSave += Application_WorkbookBeforeSave;
        }

        private void Application_WorkbookBeforeSave(Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            MessageBox.Show("WorkbookBeforeSave!");
        }

        private void Application_SheetActivate(object Sh)
        {
            MessageBox.Show("Sheet Active!");
        }

        private void Application_SheetChange(object Sh, Excel.Range Target)
        {
            MessageBox.Show("Sheet Change!" + Target.Value2);
        }

        private void Application_WorkbookOpen(Excel.Workbook Wb)
        {
            MessageBox.Show("WorkBook Active!" + Wb.Name);
        }

        #endregion
    }
}
