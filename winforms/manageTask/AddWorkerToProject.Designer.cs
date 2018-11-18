namespace manageTask
{
    partial class AddWorkerToProject
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            this.lbl_worker = new Telerik.WinControls.UI.RadLabel();
            this.lbl_project = new Telerik.WinControls.UI.RadLabel();
            this.btn_addProjectToWorker = new Telerik.WinControls.UI.RadButton();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.btn_checkAll = new Telerik.WinControls.UI.RadButton();
            this.checkedListBoxWorkers = new Telerik.WinControls.UI.RadCheckedListBox();
            this.DropDownListProject = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addProjectToWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_checkAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxWorkers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropDownListProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_worker
            // 
            this.lbl_worker.Location = new System.Drawing.Point(348, 24);
            this.lbl_worker.Name = "lbl_worker";
            this.lbl_worker.Size = new System.Drawing.Size(61, 21);
            this.lbl_worker.TabIndex = 1;
            this.lbl_worker.Text = "Workers";
            this.lbl_worker.ThemeName = "MaterialTeal";
            // 
            // lbl_project
            // 
            this.lbl_project.Location = new System.Drawing.Point(29, 24);
            this.lbl_project.Name = "lbl_project";
            this.lbl_project.Size = new System.Drawing.Size(53, 21);
            this.lbl_project.TabIndex = 3;
            this.lbl_project.Text = "Project";
            this.lbl_project.ThemeName = "MaterialTeal";
            // 
            // btn_addProjectToWorker
            // 
            this.btn_addProjectToWorker.Location = new System.Drawing.Point(551, 406);
            this.btn_addProjectToWorker.Name = "btn_addProjectToWorker";
            this.btn_addProjectToWorker.Size = new System.Drawing.Size(236, 36);
            this.btn_addProjectToWorker.TabIndex = 4;
            this.btn_addProjectToWorker.Text = "Add the project to the worker";
            this.btn_addProjectToWorker.ThemeName = "MaterialTeal";
            this.btn_addProjectToWorker.Visible = false;
            this.btn_addProjectToWorker.Click += new System.EventHandler(this.btn_addProjectToWorker_Click);
            // 
            // btn_checkAll
            // 
            this.btn_checkAll.Location = new System.Drawing.Point(351, 356);
            this.btn_checkAll.Name = "btn_checkAll";
            this.btn_checkAll.Size = new System.Drawing.Size(115, 41);
            this.btn_checkAll.TabIndex = 8;
            this.btn_checkAll.Text = "Check all";
            this.btn_checkAll.ThemeName = "MaterialTeal";
            this.btn_checkAll.Click += new System.EventHandler(this.btn_checkAll_Click);
            // 
            // checkedListBoxWorkers
            // 
            this.checkedListBoxWorkers.GroupItemSize = new System.Drawing.Size(200, 36);
            this.checkedListBoxWorkers.ItemSize = new System.Drawing.Size(200, 36);
            this.checkedListBoxWorkers.Location = new System.Drawing.Point(348, 51);
            this.checkedListBoxWorkers.Name = "checkedListBoxWorkers";
            this.checkedListBoxWorkers.Size = new System.Drawing.Size(182, 289);
            this.checkedListBoxWorkers.TabIndex = 9;
            this.checkedListBoxWorkers.ThemeName = "MaterialTeal";
            this.checkedListBoxWorkers.ItemCheckedChanged += new Telerik.WinControls.UI.ListViewItemEventHandler(this.checkedListBoxWorkers_ItemCheckedChanged);
            // 
            // DropDownListProject
            // 
            radListDataItem1.Tag = "hhhhh";
            radListDataItem1.Text = "nnnn";
            this.DropDownListProject.Items.Add(radListDataItem1);
            this.DropDownListProject.Location = new System.Drawing.Point(98, 18);
            this.DropDownListProject.Name = "DropDownListProject";
            this.DropDownListProject.Size = new System.Drawing.Size(197, 36);
            this.DropDownListProject.TabIndex = 10;
            this.DropDownListProject.ThemeName = "MaterialTeal";
            this.DropDownListProject.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.DropDownListProject_SelectedIndexChanged);
            // 
            // AddWorkerToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 477);
            this.Controls.Add(this.DropDownListProject);
            this.Controls.Add(this.checkedListBoxWorkers);
            this.Controls.Add(this.btn_checkAll);
            this.Controls.Add(this.btn_addProjectToWorker);
            this.Controls.Add(this.lbl_project);
            this.Controls.Add(this.lbl_worker);
            this.Name = "AddWorkerToProject";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Add a worker to a project";
            this.ThemeName = "MaterialTeal";
            this.Load += new System.EventHandler(this.AddWorkerToProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lbl_worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_project)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addProjectToWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_checkAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkedListBoxWorkers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DropDownListProject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel lbl_worker;
        private Telerik.WinControls.UI.RadLabel lbl_project;
        private Telerik.WinControls.UI.RadButton btn_addProjectToWorker;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadButton btn_checkAll;
        private Telerik.WinControls.UI.RadCheckedListBox checkedListBoxWorkers;
        private Telerik.WinControls.UI.RadDropDownList DropDownListProject;
    }
}