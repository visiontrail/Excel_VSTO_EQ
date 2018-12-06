using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EQ_PersonnelDataSys.Control;
using EQ_PersonnelDataSys;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using EQ_PersonnelDataSys.Model;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using ExcelTools = Microsoft.Office.Tools;

namespace EQ_PersonnelDataSys.WinForms
{
    public partial class SelectTemplate : Form
    {
        private List<string> template_list;
        public SelectTemplate()
        {
            InitializeComponent();
            //JObject jObject = JsonHelper.ReadJsonFileToJobject(ThisAddIn.templatefilepath);
            //template_list = new List<string>();

            //foreach (var template in jObject["TemplateList"])
            //{
            //    template_list.Add(template["TemplateName"].ToString());
            //}

            // 获取当前保存的模板;
            TemplateList tl = JsonParser.FromJsonToTemplate();

            templates.DataSource = tl.Template_list;
            templates.DisplayMember = "TemplateName";
        }

        private void comfirm_Click(object sender, EventArgs e)
        {
            ColumnTemplate column = this.templates.SelectedItem as ColumnTemplate;
            string sheetname = (this.templates.SelectedItem as ColumnTemplate).TemplateName;
            List<string> sheetcolumn = new List<string>();

            sheetcolumn.Add("姓名");

            foreach (Column iter in (this.templates.SelectedItem as ColumnTemplate).ColumnList)
            {
                sheetcolumn.Add(iter.ColumnName);
            }
            

            string[] sheetnames = sheetcolumn.ToArray();
            // OleDB获取Excel数据库;
            string connectionString = string.Format("provider=Microsoft.Jet.OLEDB.4.0; data source={0};" +
                "Extended Properties=Excel 8.0;", ThisAddIn.filepath);

            // 创建一个DataSet;
            DataSet ds = new DataSet();

            // 创建一个新的Sheet页;
            Worksheet wst;
            wst = (Worksheet)Globals.ThisAddIn.Application.Worksheets.Add();
            wst.Name = sheetname;

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
                string query = SQL_Generator.GenerateSQLByTemplate(column);
                con.Open();
                OleDbDataAdapter adapter = new OleDbDataAdapter(query, con);

                adapter.Fill(dataTable);
                ds.Tables.Add(dataTable);
                con.Close();

                list1.SetDataBinding(dataTable, null, sheetnames);
            }

            this.Close();
        }
    }
}
