namespace manageTask
{
    partial class Report
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem1 = new Telerik.WinControls.UI.ListViewDataItem("excel");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem2 = new Telerik.WinControls.UI.ListViewDataItem("clv");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem3 = new Telerik.WinControls.UI.ListViewDataItem("html");
            Telerik.WinControls.UI.ListViewDataItem listViewDataItem4 = new Telerik.WinControls.UI.ListViewDataItem("pdf");
            Telerik.WinControls.UI.RadPrintWatermark radPrintWatermark1 = new Telerik.WinControls.UI.RadPrintWatermark();
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.btn_print = new Telerik.WinControls.UI.RadButton();
            this.btn_printPerview = new Telerik.WinControls.UI.RadButton();
            this.btn_printSetting = new Telerik.WinControls.UI.RadButton();
            this.btn_export = new Telerik.WinControls.UI.RadButton();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.ListViewOption = new Telerik.WinControls.UI.RadListView();
            this.radPrintDocument1 = new Telerik.WinControls.UI.RadPrintDocument();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.radComboBoxSummaries = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_printPerview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_printSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_export)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListViewOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(72, 12);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(116, 38);
            this.btn_print.TabIndex = 0;
            this.btn_print.Text = "print";
            this.btn_print.ThemeName = "MaterialTeal";
            this.btn_print.Click += new System.EventHandler(this.radButtonPrint_Click);
            // 
            // btn_printPerview
            // 
            this.btn_printPerview.Location = new System.Drawing.Point(215, 13);
            this.btn_printPerview.Name = "btn_printPerview";
            this.btn_printPerview.Size = new System.Drawing.Size(127, 37);
            this.btn_printPerview.TabIndex = 1;
            this.btn_printPerview.Text = "printPerview";
            this.btn_printPerview.ThemeName = "MaterialTeal";
            this.btn_printPerview.Click += new System.EventHandler(this.radButtonPrintPreview_Click);
            // 
            // btn_printSetting
            // 
            this.btn_printSetting.Location = new System.Drawing.Point(366, 13);
            this.btn_printSetting.Name = "btn_printSetting";
            this.btn_printSetting.Size = new System.Drawing.Size(116, 37);
            this.btn_printSetting.TabIndex = 1;
            this.btn_printSetting.Text = "printSetting";
            this.btn_printSetting.ThemeName = "MaterialTeal";
            this.btn_printSetting.Click += new System.EventHandler(this.radButtonPrintSettings_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(610, 267);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(116, 51);
            this.btn_export.TabIndex = 1;
            this.btn_export.Text = "export";
            this.btn_export.ThemeName = "MaterialTeal";
            this.btn_export.Click += new System.EventHandler(this.radButtonExport_Click);
            // 
            // radGridView1
            // 
            this.radGridView1.Location = new System.Drawing.Point(12, 56);
            // 
            // 
            // 
            this.radGridView1.MasterTemplate.AllowAddNewRow = false;
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.ReadOnly = true;
            this.radGridView1.Size = new System.Drawing.Size(581, 320);
            this.radGridView1.TabIndex = 2;
            this.radGridView1.ThemeName = "MaterialTeal";
            // 
            // ListViewOption
            // 
            this.ListViewOption.GroupItemSize = new System.Drawing.Size(200, 36);
            listViewDataItem1.Text = "excel";
            listViewDataItem2.Text = "clv";
            listViewDataItem3.Text = "html";
            listViewDataItem4.Text = "pdf";
            this.ListViewOption.Items.AddRange(new Telerik.WinControls.UI.ListViewDataItem[] {
            listViewDataItem1,
            listViewDataItem2,
            listViewDataItem3,
            listViewDataItem4});
            this.ListViewOption.ItemSize = new System.Drawing.Size(200, 36);
            this.ListViewOption.Location = new System.Drawing.Point(615, 48);
            this.ListViewOption.Name = "ListViewOption";
            this.ListViewOption.Size = new System.Drawing.Size(113, 113);
            this.ListViewOption.TabIndex = 3;
            this.ListViewOption.ThemeName = "MaterialTeal";
            this.ListViewOption.SelectedIndexChanged += new System.EventHandler(this.radListBox1_SelectedIndexChanged);
            // 
            // radPrintDocument1
            // 
            this.radPrintDocument1.FooterFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radPrintDocument1.HeaderFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.radPrintDocument1.Watermark = radPrintWatermark1;
            // 
            // radComboBoxSummaries
            // 
            radListDataItem1.Text = "ExportAll";
            radListDataItem2.Text = "ExportOnlyTop";
            radListDataItem3.Text = "ExportOnlyBottom";
            radListDataItem4.Text = "DoNotExport";
            this.radComboBoxSummaries.Items.Add(radListDataItem1);
            this.radComboBoxSummaries.Items.Add(radListDataItem2);
            this.radComboBoxSummaries.Items.Add(radListDataItem3);
            this.radComboBoxSummaries.Items.Add(radListDataItem4);
            this.radComboBoxSummaries.Location = new System.Drawing.Point(609, 214);
            this.radComboBoxSummaries.Name = "radComboBoxSummaries";
            this.radComboBoxSummaries.Size = new System.Drawing.Size(116, 36);
            this.radComboBoxSummaries.TabIndex = 4;
            this.radComboBoxSummaries.ThemeName = "MaterialTeal";
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 388);
            this.Controls.Add(this.radComboBoxSummaries);
            this.Controls.Add(this.ListViewOption);
            this.Controls.Add(this.radGridView1);
            this.Controls.Add(this.btn_printPerview);
            this.Controls.Add(this.btn_printSetting);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_print);
            this.Name = "Report";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Report";
            this.ThemeName = "MaterialTeal";
            ((System.ComponentModel.ISupportInitialize)(this.btn_print)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_printPerview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_printSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_export)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListViewOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radComboBoxSummaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton btn_print;
        private Telerik.WinControls.UI.RadButton btn_printPerview;
        private Telerik.WinControls.UI.RadButton btn_printSetting;
        private Telerik.WinControls.UI.RadButton btn_export;
        private Telerik.WinControls.UI.RadGridView radGridView1;
        private Telerik.WinControls.UI.RadListView ListViewOption;
        private Telerik.WinControls.UI.RadPrintDocument radPrintDocument1;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private Telerik.WinControls.UI.RadDropDownList radComboBoxSummaries;
    }
}
