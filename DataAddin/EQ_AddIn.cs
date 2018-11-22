using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;

namespace DataAddin
{
    public partial class EQ_AddIn
    {
        /// <summary>
        /// 控件加载的时候调用;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            // 实验程序，Excel执行保存的时候执行的事件;
            this.Application.WorkbookBeforeSave += new Excel.AppEvents_WorkbookBeforeSaveEventHandler(Application_WorkbookBeforeSave);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        /// <summary>
        /// Excel工作簿保存的时候，执行该函数;
        /// </summary>
        /// <param name="Wb"></param>
        /// <param name="SaveAsUI"></param>
        /// <param name="Cancel"></param>
        void Application_WorkbookBeforeSave(Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            Excel.Worksheet activeWorksheet = ((Excel.Worksheet)Application.ActiveSheet);     // 获取当前的Sheet;
            Excel.Range firstRow = activeWorksheet.get_Range("A1");                           // 获取A1单元格;
            firstRow.EntireRow.Insert(Excel.XlInsertShiftDirection.xlShiftDown);              // 为这个WorkSheet添加一行;
            Excel.Range newFirstRow = activeWorksheet.get_Range("A1");                        // 获取新添加的一行;
            newFirstRow.Value2 = "This text was added by using code";                         // 为新添加的一行数据添加内容;
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
        }
        
        #endregion
    }
}
