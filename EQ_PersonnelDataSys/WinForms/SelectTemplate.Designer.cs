namespace EQ_PersonnelDataSys.WinForms
{
    partial class SelectTemplate
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
            this.templates = new System.Windows.Forms.ComboBox();
            this.comfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // templates
            // 
            this.templates.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.templates.FormattingEnabled = true;
            this.templates.Location = new System.Drawing.Point(48, 24);
            this.templates.Name = "templates";
            this.templates.Size = new System.Drawing.Size(235, 20);
            this.templates.TabIndex = 0;
            // 
            // comfirm
            // 
            this.comfirm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comfirm.Location = new System.Drawing.Point(123, 69);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(75, 23);
            this.comfirm.TabIndex = 1;
            this.comfirm.Text = "确定";
            this.comfirm.UseVisualStyleBackColor = true;
            // 
            // SelectTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 114);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.templates);
            this.Name = "SelectTemplate";
            this.Text = "选择模板";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox templates;
        private System.Windows.Forms.Button comfirm;
    }
}