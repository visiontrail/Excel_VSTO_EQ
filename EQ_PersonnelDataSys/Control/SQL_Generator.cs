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
        public static string GenerateSQLByTemplate(ColumnTemplate ct)
        {
            string ret = "SELECT ";
            string select_col = "";
            string select_table = "";
            List<string> selTablelist = new List<string>();

            foreach (Column col in ct.ColumnList)
            {
                select_col += " [" + col.TableName + "$]." + col.ColumnName + ", ";
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

            foreach(string tablename in selTablelist)
            {
                select_table += "[" + tablename + "$].姓名";
            }


            return ret;
        }
    }
}
