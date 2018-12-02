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

namespace EQ_PersonnelDataSys.WinForms
{
    public partial class SelectTemplate : Form
    {
        private List<string> template_list;
        public SelectTemplate()
        {
            InitializeComponent();
            JObject jObject = JsonHelper.ReadJsonFileToJobject(ThisAddIn.templatefilepath);
            template_list = new List<string>();

            foreach(var template in jObject["TemplateList"])
            {
                template_list.Add(template["TemplateName"].ToString());
            }

            templates.DataSource = template_list;

        }
    }
}
