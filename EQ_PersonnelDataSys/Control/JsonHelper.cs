using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;

namespace EQ_PersonnelDataSys.Control
{
    public class JsonHelper
    {
        /// <summary>
        /// 读取Json数据并返回JObject类型;
        /// </summary>
        /// <param name="sFilePath"></param>
        /// <returns></returns>
        public static JObject ReadJsonFile(string sFilePath)
        {
            FileStream fs = new FileStream(sFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            StreamReader sr = new StreamReader(fs, Encoding.GetEncoding("gb2312"));

            JObject JObj = JObject.Parse(sr.ReadToEnd().ToString());
            fs.Close();
            return JObj;
        }

        /// <summary>
        /// 读取Json数据并返回JObject类型;
        /// </summary>
        /// <param name="sFilePath"></param>
        /// <returns></returns>
        public static JObject ReadJsonFileToJobject(string sFilePath)
        {
            StreamReader fs = File.OpenText(sFilePath);

            JObject JObj = (JObject)JToken.ReadFrom(new JsonTextReader(fs));
            fs.Close();
            
            return JObj;
        }

        /// <summary>
        /// 读取Json文件数据并返回string类型;
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns></returns>
        public static string ReadJsonFileToString(string filepath)
        {
            string ret = "";
            try
            {
                if (File.Exists(filepath))
                {
                    using (StreamReader sr = new StreamReader(filepath, Encoding.Default))
                    {
                        ret = sr.ReadToEnd();
                    }
                }
                else
                {
                    MessageBox.Show("没有找到模板文件，请选择新建查询，新增一个查询模板");
                }
            }
            catch (Exception ex)
            {
            }
            return ret;
        }

        /// <summary>
        /// 写入Json文件;
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="content"></param>
        public static void WriteJsonFile(string filepath, string content)
        {
            try
            {
                // 如果文件不存在则创建文件如果存在则覆盖文件;
                FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write);
                fs.SetLength(0);
                StreamWriter sw = new StreamWriter(fs, Encoding.Default);
                sw.Write(content);
                sw.Flush();
                sw.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine("write file " + filepath + " failed:" + e.ToString());
            }
        }
    }
}
