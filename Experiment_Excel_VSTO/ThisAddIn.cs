using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace Experiment_Excel_VSTO
{
    public partial class ThisAddIn
    {
        public static string filepath;    // 当前打开文档的路径;

        /// <summary>
        /// 当整个Excel程序启动的时候;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            //MessageBox.Show("ThisAddIn_StartUP!");
        }

        /// <summary>
        /// 当整个Excel程序关闭的时候;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
            //MessageBox.Show("ThisAddIn_Shutdown!");
        }

        /// <summary>
        /// 当用户保存工作表的时候,即用户Ctrl + S的时候;
        /// </summary>
        /// <param name="Wb"></param>
        /// <param name="SaveAsUI"></param>
        /// <param name="Cancel"></param>
        private void Application_WorkbookBeforeSave(Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            //MessageBox.Show("WorkbookBeforeSave!");
        }

        /// <summary>
        /// 当一个WorkSheet被用户选中的时候;
        /// </summary>
        /// <param name="Sh"></param>
        private void Application_SheetActivate(object Sh)
        {
            //MessageBox.Show("Sheet Active!");
        }

        /// <summary>
        /// 当Sheet页被用户改动的时候;
        /// </summary>
        /// <param name="Sh"></param>
        /// <param name="Target"></param>
        private void Application_SheetChange(object Sh, Excel.Range Target)
        {
            //MessageBox.Show("Sheet Change!" + Target.Value2);
        }

        /// <summary>
        /// 当用户打开了一个工作表的时候;
        /// </summary>
        /// <param name="Wb"></param>
        private void Application_WorkbookOpen(Excel.Workbook Wb)
        {
            // 获取Excel文件的路径，用于在其他地方使用OleDB连接该Excel;
            filepath = Wb.Path + "\\" + Wb.Name;
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
        
        #endregion
    }
}
