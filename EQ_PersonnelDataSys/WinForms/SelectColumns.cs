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
    }
}
