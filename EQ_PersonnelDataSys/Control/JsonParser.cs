using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQ_PersonnelDataSys.Model;
using EQ_PersonnelDataSys;

namespace EQ_PersonnelDataSys.Control
{
    /// <summary>
    /// 解析Json到对应的模型当中;
    /// </summary>
    public class JsonParser
    {
        public static TemplateList FromJsonToTemplate()
        {
            // 读取JSON文件到内存中;
            string json_content = JsonHelper.ReadJsonFileToString(ThisAddIn.templatefilepath);

            TemplateList tl = new TemplateList();
            ColumnTemplate ct = new ColumnTemplate();

            // 如果模板文件不为空，则填入到内存中;
            if ((json_content != ""))
            {
                tl = (TemplateList)ColumnTemplate.JsonToObject(json_content, tl);
            }

            return tl;
        }
    }
}
