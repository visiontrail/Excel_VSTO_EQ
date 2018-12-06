using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EQ_PersonnelDataSys.Model;

namespace EQ_PersonnelDataSys.Control
{
    public class SQL_Generator
    {
        /// <summary>
        /// 根据模板文件生成一个SQL语句用于查询;
        /// </summary>
        /// <param name="ct"></param>
        /// <returns></returns>
        public static string GenerateSQLByTemplate(ColumnTemplate ct)
        {
            string ret = "SELECT ";
            string select_col = "";
            string select_table = "";
            string where = "";
            List<string> selTablelist = new List<string>();   // 当前用户选择的表;

            // 暂时把主表写死在代码中;
            string personnel_listtable_name = "[花名册$].姓名,";
            string personnel_listtable = "[花名册$], ";

            foreach (Column col in ct.ColumnList)
            {
                select_col += " [" + col.TableName + "$]." + col.ColumnName + ", ";

                // 将要查询的表放入容器;
                if(!selTablelist.Contains(col.TableName))
                {
                    if(col.TableName == "花名册")
                    {
                        continue;
                    }
                    selTablelist.Add(col.TableName);
                }
            }

            ret += personnel_listtable_name;
            ret += select_col.Substring(0, select_col.Length - 2) + " FROM ";

            foreach(string tablename in selTablelist)
            {
                select_table += "[" + tablename + "$], ";
            }

            ret += personnel_listtable;
            ret = ret + select_table.Substring(0, select_table.Length - 2) + " WHERE ";

            foreach(var temptablename in selTablelist)
            {
                where += "[花名册$].姓名" + "=" + "[" + temptablename + "$].姓名 AND ";
            }

            //where = "[" + selTablelist[0] + "$].姓名=" + "[" + selTablelist[1] + "$].姓名";
            ret += where.Substring(0, where.Length - 5);

            return ret;
        }
    }
}
