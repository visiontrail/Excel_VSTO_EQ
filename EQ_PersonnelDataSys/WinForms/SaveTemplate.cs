using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EQ_PersonnelDataSys.Model;
using EQ_PersonnelDataSys.Control;

namespace EQ_PersonnelDataSys.WinForms
{
    /// <summary>
    /// 保存模板名称;
    /// </summary>
    public partial class SaveTemplate : Form
    {
        private List<Column> columns = new List<Column>();
        public SaveTemplate(List<Column> col)
        {
            InitializeComponent();
            columns = col;
        }

        /// <summary>
        /// 将选择好的模板保存到Json文件当中;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if((template_name.Text == "") || (template_name.Text == null))
            {
                MessageBox.Show("名称不能为空！");
            }
            
            // 返回当前已经存储的TemplateList;
            TemplateList tl = JsonParser.FromJsonToTemplate();

            // 获取当前要新建的ColumnList;
            ColumnTemplate ct = new ColumnTemplate();
            ct.TemplateName = this.template_name.Text.ToString();
            ct.ColumnList = columns;

            // 将新建的ColumnList追加至TemplateList;
            tl.Template_list.Add(ct);
            
            // 将组合好的Json回填到Template文件中;
            string s_json = ColumnTemplate.ObjectToJson(tl);
            JsonHelper.WriteJsonFile(ThisAddIn.templatefilepath, s_json);


            this.Close();
        }
    }
}
