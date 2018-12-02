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
            SQL_Generator.GenerateSQLByTemplate(column);
        }
    }
}
