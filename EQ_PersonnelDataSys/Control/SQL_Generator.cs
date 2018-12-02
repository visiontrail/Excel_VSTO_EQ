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
            List<string> selTablelist = new List<string>();

            foreach (Column col in ct.ColumnList)
            {
                select_col += " [" + col.TableName + "$]." + col.ColumnName + ", ";

                // 将要查询的表放入容器;
                if(!selTablelist.Contains(col.TableName))
                {
                    selTablelist.Add(col.TableName);
                }
            }
            
            ret = ret + select_col.Substring(0, select_col.Length - 2) + " FROM ";

            foreach(string tablename in selTablelist)
            {
                select_table += "[" + tablename + "$], ";
            }

            ret = ret + select_table.Substring(0, select_table.Length - 2) + " WHERE ";

            //foreach (string tablename in selTablelist)
            //{
            //    where += "[" + tablename + "$].姓名";
            //}

            where = "[" + selTablelist[0] + "$].姓名=" + "[" + selTablelist[1] + "$].姓名";
            ret += where;

            return ret;
        }
    }
}
