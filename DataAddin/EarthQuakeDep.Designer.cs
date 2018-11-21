using Microsoft.Office.Tools.Ribbon;
using System.Collections.Generic;

namespace DataAddin
{
    partial class EarthQuakeDep : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EarthQuakeDep()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EarthQuakeDep));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.SelectColums = this.Factory.CreateRibbonButton();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.group5 = this.Factory.CreateRibbonGroup();
            this.group4 = this.Factory.CreateRibbonGroup();
            this.toggleButton1 = this.Factory.CreateRibbonToggleButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.group4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.group5);
            this.tab1.Groups.Add(this.group4);
            this.tab1.Label = "地震局人事管理";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.SelectColums);
            this.group1.Label = "表格生成区";
            this.group1.Name = "group1";
            // 
            // SelectColums
            // 
            this.SelectColums.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SelectColums.Image = ((System.Drawing.Image)(resources.GetObject("SelectColums.Image")));
            this.SelectColums.Label = "选择列";
            this.SelectColums.Name = "SelectColums";
            this.SelectColums.ShowImage = true;
            this.SelectColums.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.SelectColums_Click);
            // 
            // group2
            // 
            this.group2.Label = "步骤2：选择列";
            this.group2.Name = "group2";
            // 
            // group3
            // 
            this.group3.Label = "步骤3：确认列";
            this.group3.Name = "group3";
            // 
            // group5
            // 
            this.group5.Label = "group5";
            this.group5.Name = "group5";
            // 
            // group4
            // 
            this.group4.Items.Add(this.toggleButton1);
            this.group4.Items.Add(this.button1);
            this.group4.Label = "功能选项";
            this.group4.Name = "group4";
            // 
            // toggleButton1
            // 
            this.toggleButton1.Label = "XXX开关";
            this.toggleButton1.Name = "toggleButton1";
            // 
            // button1
            // 
            this.button1.Label = "保存表格";
            this.button1.Name = "button1";
            // 
            // EarthQuakeDep
            // 
            this.Name = "EarthQuakeDep";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EarthQuakeDep_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.group4.ResumeLayout(false);
            this.group4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal RibbonGroup group3;
        internal RibbonGroup group4;
        internal RibbonToggleButton toggleButton1;
        internal RibbonGroup group5;
        internal RibbonButton button1;
        internal RibbonButton SelectColums;
    }

    partial class ThisRibbonCollection
    {
        internal EarthQuakeDep EarthQuakeDep
        {
            get { return this.GetRibbon<EarthQuakeDep>(); }
        }
    }
}
