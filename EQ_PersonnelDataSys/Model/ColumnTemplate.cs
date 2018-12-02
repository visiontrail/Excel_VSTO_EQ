using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EQ_PersonnelDataSys.Model
{
    /// <summary>
    /// 模板列表;
    /// </summary>
    public class TemplateList
    {
        public TemplateList()
        {
            Template_list = new List<ColumnTemplate>();
        }
        public List<ColumnTemplate> Template_list { get; set; }
    }

    /// <summary>
    /// 列表模板;
    /// </summary>
    public class ColumnTemplate
    {
        public string TemplateName { get; set; }
        public List<Column> ColumnList { get; set; }

        public static object JsonToObject(string jsonString, object obj)
        {
            return JsonConvert.DeserializeObject(jsonString, obj.GetType());
        }

        public static string ObjectToJson(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }

    /// <summary>
    /// 列模板;
    /// </summary>
    public class Column
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
    }
}
