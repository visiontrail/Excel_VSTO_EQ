namespace EQ_PersonnelDataSys.WinForms
{
    partial class SelectColumns
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectColumns));
            this.label1 = new System.Windows.Forms.Label();
            this.all_db = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.all_col = new System.Windows.Forms.ListBox();
            this.Sel_Column = new System.Windows.Forms.Button();
            this.Del_Column = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Template_Col = new System.Windows.Forms.ListBox();
            this.Save_Template = new System.Windows.Forms.Button();
            this.Confirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择数据库";
            // 
            // all_db
            // 
            this.all_db.FormattingEnabled = true;
            this.all_db.ItemHeight = 12;
            this.all_db.Location = new System.Drawing.Point(26, 54);
            this.all_db.Name = "all_db";
            this.all_db.Size = new System.Drawing.Size(90, 124);
            this.all_db.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择列";
            // 
            // all_col
            // 
            this.all_col.FormattingEnabled = true;
            this.all_col.ItemHeight = 12;
            this.all_col.Location = new System.Drawing.Point(150, 54);
            this.all_col.Name = "all_col";
            this.all_col.Size = new System.Drawing.Size(90, 124);
            this.all_col.TabIndex = 3;
            // 
            // Sel_Column
            // 
            this.Sel_Column.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Sel_Column.Image = ((System.Drawing.Image)(resources.GetObject("Sel_Column.Image")));
            this.Sel_Column.Location = new System.Drawing.Point(270, 72);
            this.Sel_Column.Name = "Sel_Column";
            this.Sel_Column.Size = new System.Drawing.Size(36, 31);
            this.Sel_Column.TabIndex = 4;
            this.Sel_Column.UseVisualStyleBackColor = true;
            this.Sel_Column.Click += new System.EventHandler(this.Sel_Column_Click);
            // 
            // Del_Column
            // 
            this.Del_Column.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Del_Column.Image = ((System.Drawing.Image)(resources.GetObject("Del_Column.Image")));
            this.Del_Column.Location = new System.Drawing.Point(270, 126);
            this.Del_Column.Name = "Del_Column";
            this.Del_Column.Size = new System.Drawing.Size(36, 31);
            this.Del_Column.TabIndex = 5;
            this.Del_Column.UseVisualStyleBackColor = true;
            this.Del_Column.Click += new System.EventHandler(this.Del_Column_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "生成列";
            // 
            // Template_Col
            // 
            this.Template_Col.FormattingEnabled = true;
            this.Template_Col.ItemHeight = 12;
            this.Template_Col.Location = new System.Drawing.Point(344, 54);
            this.Template_Col.Name = "Template_Col";
            this.Template_Col.Size = new System.Drawing.Size(90, 172);
            this.Template_Col.TabIndex = 7;
            // 
            // Save_Template
            // 
            this.Save_Template.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save_Template.Location = new System.Drawing.Point(458, 72);
            this.Save_Template.Name = "Save_Template";
            this.Save_Template.Size = new System.Drawing.Size(75, 23);
            this.Save_Template.TabIndex = 8;
            this.Save_Template.Text = "保存模板";
            this.Save_Template.UseVisualStyleBackColor = true;
            this.Save_Template.Click += new System.EventHandler(this.Save_Template_Click);
            // 
            // Confirm
            // 
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Confirm.Location = new System.Drawing.Point(458, 126);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(75, 23);
            this.Confirm.TabIndex = 9;
            this.Confirm.Text = "确定";
            this.Confirm.UseVisualStyleBackColor = true;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(346, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "注：第一版本默认使用姓名作为索引";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "请选择数据库和对应的类，或直接选择已保存的模板";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "模板：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(68, 197);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(172, 20);
            this.comboBox1.TabIndex = 13;
            // 
            // SelectColumns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 251);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Save_Template);
            this.Controls.Add(this.Template_Col);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Del_Column);
            this.Controls.Add(this.Sel_Column);
            this.Controls.Add(this.all_col);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.all_db);
            this.Controls.Add(this.label1);
            this.Name = "SelectColumns";
            this.Text = "步骤1：选择列";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox all_db;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox all_col;
        private System.Windows.Forms.Button Sel_Column;
        private System.Windows.Forms.Button Del_Column;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Template_Col;
        private System.Windows.Forms.Button Save_Template;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}