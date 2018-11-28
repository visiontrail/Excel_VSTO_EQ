using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EQ_PersonnelDataSys.WinForms
{
    public partial class SelectColumns : Form
    {
        private Dictionary<string, List<string>> all_data = new Dictionary<string, List<string>>();

        public SelectColumns(Dictionary<string, List<string>> add_db_name)
        {
            InitializeComponent();
            all_data = add_db_name;

            this.all_db.DataSource = add_db_name.Keys.ToList();
            this.all_db.SelectedIndexChanged += All_db_SelectedIndexChanged;
            
        }

        private void All_db_SelectedIndexChanged(object sender, EventArgs e)
        {
            string seleted = (sender as ListBox).SelectedItem.ToString();
            
            this.all_col.DataSource = all_data[seleted];

        }

        private void Sel_Column_Click(object sender, EventArgs e)
        {
            if(Template_Col.Items.Contains(all_col.SelectedItem.ToString()))
            {
                MessageBox.Show("已选择相同项");
            }
            this.Template_Col.Items.Add(this.all_col.SelectedItem.ToString());
        }

        private void Del_Column_Click(object sender, EventArgs e)
        {
            this.Template_Col.Items.Remove(this.Template_Col.SelectedItem.ToString());
        }

        /// <summary>
        /// 保存数据模板;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save_Template_Click(object sender, EventArgs e)
        {

        }
    }
}
