namespace EQ_PersonnelDataSys
{
    partial class EQ_Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EQ_Ribbon()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EQ_Ribbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.Select_Column = this.Factory.CreateRibbonButton();
            this.Select_Template = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Label = "地震局人事管理插件";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.Select_Column);
            this.group1.Items.Add(this.Select_Template);
            this.group1.Label = "生成表格";
            this.group1.Name = "group1";
            // 
            // Select_Column
            // 
            this.Select_Column.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Select_Column.Image = ((System.Drawing.Image)(resources.GetObject("Select_Column.Image")));
            this.Select_Column.Label = "新建查询";
            this.Select_Column.Name = "Select_Column";
            this.Select_Column.ShowImage = true;
            this.Select_Column.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Select_Column_Click);
            // 
            // Select_Template
            // 
            this.Select_Template.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Select_Template.Image = ((System.Drawing.Image)(resources.GetObject("Select_Template.Image")));
            this.Select_Template.Label = "选择模板";
            this.Select_Template.Name = "Select_Template";
            this.Select_Template.ShowImage = true;
            // 
            // EQ_Ribbon
            // 
            this.Name = "EQ_Ribbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EQ_Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Select_Column;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Select_Template;
    }

    partial class ThisRibbonCollection
    {
        internal EQ_Ribbon EQ_Ribbon
        {
            get { return this.GetRibbon<EQ_Ribbon>(); }
        }
    }
}
