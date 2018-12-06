namespace Experiment_Excel_VSTO
{
    partial class Experiment_Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Experiment_Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.Get_Sheet_Info = this.Factory.CreateRibbonButton();
            this.GetDatatoDataSet = this.Factory.CreateRibbonButton();
            this.new_sheet = this.Factory.CreateRibbonButton();
            this.add_Chart = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "实验用Tab";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.Get_Sheet_Info);
            this.group1.Items.Add(this.GetDatatoDataSet);
            this.group1.Items.Add(this.new_sheet);
            this.group1.Items.Add(this.add_Chart);
            this.group1.Label = "基本操作1";
            this.group1.Name = "group1";
            // 
            // Get_Sheet_Info
            // 
            this.Get_Sheet_Info.Label = "读写Sheet页中信息";
            this.Get_Sheet_Info.Name = "Get_Sheet_Info";
            this.Get_Sheet_Info.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Get_Sheet_Info_Click);
            // 
            // GetDatatoDataSet
            // 
            this.GetDatatoDataSet.Label = "通过SQL获取数据并存入DataSet";
            this.GetDatatoDataSet.Name = "GetDatatoDataSet";
            this.GetDatatoDataSet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GetDatatoDataSet_Click);
            // 
            // new_sheet
            // 
            this.new_sheet.Label = "新建一个Sheet页";
            this.new_sheet.Name = "new_sheet";
            this.new_sheet.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.new_sheet_Click);
            // 
            // add_Chart
            // 
            this.add_Chart.Label = "添加一个图表到WorkSheet";
            this.add_Chart.Name = "add_Chart";
            this.add_Chart.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.add_Chart_Click);
            // 
            // Experiment_Ribbon
            // 
            this.Name = "Experiment_Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Experiment_Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Get_Sheet_Info;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton GetDatatoDataSet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton new_sheet;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton add_Chart;
    }

    partial class ThisRibbonCollection
    {
        internal Experiment_Ribbon Experiment_Ribbon
        {
            get { return this.GetRibbon<Experiment_Ribbon>(); }
        }
    }
}
