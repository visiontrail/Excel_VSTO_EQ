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
            this.group2 = this.Factory.CreateRibbonGroup();
            this.UseRAMDB = this.Factory.CreateRibbonCheckBox();
            this.ChangeSameTime = this.Factory.CreateRibbonCheckBox();
            this.Select_Column = this.Factory.CreateRibbonButton();
            this.Select_Template = this.Factory.CreateRibbonButton();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group2.SuspendLayout();
            this.group3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
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
            // group2
            // 
            this.group2.Items.Add(this.UseRAMDB);
            this.group2.Items.Add(this.label1);
            this.group2.Items.Add(this.ChangeSameTime);
            this.group2.Label = "功能选项";
            this.group2.Name = "group2";
            // 
            // UseRAMDB
            // 
            this.UseRAMDB.Enabled = false;
            this.UseRAMDB.Label = "高效查询(开发中)";
            this.UseRAMDB.Name = "UseRAMDB";
            // 
            // ChangeSameTime
            // 
            this.ChangeSameTime.Enabled = false;
            this.ChangeSameTime.Label = "同步修改（开发中）";
            this.ChangeSameTime.Name = "ChangeSameTime";
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
            this.Select_Template.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Select_Template_Click);
            // 
            // group3
            // 
            this.group3.Items.Add(this.button1);
            this.group3.Label = "便捷功能";
            this.group3.Name = "group3";
            // 
            // button1
            // 
            this.button1.Label = "生成并计算XX";
            this.button1.Name = "button1";
            // 
            // label1
            // 
            this.label1.Label = "（开启高效查询，请勿再修改表中内容）";
            this.label1.Name = "label1";
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
            this.group2.ResumeLayout(false);
            this.group2.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Select_Column;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Select_Template;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox UseRAMDB;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox ChangeSameTime;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
    }

    partial class ThisRibbonCollection
    {
        internal EQ_Ribbon EQ_Ribbon
        {
            get { return this.GetRibbon<EQ_Ribbon>(); }
        }
    }
}
