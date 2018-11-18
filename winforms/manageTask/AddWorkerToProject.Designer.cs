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
            this.lbl_worker = new Telerik.WinControls.UI.RadLabel();
            this.lbl_project = new Telerik.WinControls.UI.RadLabel();
            this.btn_addProjectToWorker = new Telerik.WinControls.UI.RadButton();
            this.cmbx_projects = new System.Windows.Forms.ComboBox();
            this.checkedListBoxWorkers = new System.Windows.Forms.CheckedListBox();
            this.materialTealTheme1 = new Telerik.WinControls.Themes.MaterialTealTheme();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_project)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addProjectToWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_worker
            // 
            this.lbl_worker.Location = new System.Drawing.Point(29, 59);
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
            this.btn_addProjectToWorker.Location = new System.Drawing.Point(287, 410);
            this.btn_addProjectToWorker.Name = "btn_addProjectToWorker";
            this.btn_addProjectToWorker.Size = new System.Drawing.Size(236, 36);
            this.btn_addProjectToWorker.TabIndex = 4;
            this.btn_addProjectToWorker.Text = "Add the project to the worker";
            this.btn_addProjectToWorker.ThemeName = "MaterialTeal";
            this.btn_addProjectToWorker.Visible = false;
            // 
            // cmbx_projects
            // 
            this.cmbx_projects.FormattingEnabled = true;
            this.cmbx_projects.Location = new System.Drawing.Point(90, 24);
            this.cmbx_projects.Name = "cmbx_projects";
            this.cmbx_projects.Size = new System.Drawing.Size(121, 21);
            this.cmbx_projects.TabIndex = 6;
            this.cmbx_projects.SelectedIndexChanged += new System.EventHandler(this.cmbx_projects_SelectedIndexChanged);
            // 
            // checkedListBoxWorkers
            // 
            this.checkedListBoxWorkers.FormattingEnabled = true;
            this.checkedListBoxWorkers.Location = new System.Drawing.Point(29, 83);
            this.checkedListBoxWorkers.Name = "checkedListBoxWorkers";
<<<<<<< HEAD
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
=======
            this.checkedListBoxWorkers.Size = new System.Drawing.Size(216, 289);
            this.checkedListBoxWorkers.TabIndex = 7;
            this.checkedListBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxWorkers_SelectedIndexChanged);
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(29, 378);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(108, 29);
            this.radButton1.TabIndex = 8;
            this.radButton1.Text = "radButton1";
>>>>>>> ae5ed1a4e5bfa890fc342e9e4214f82fce371fec
            // 
            // AddWorkerToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 477);
            this.Controls.Add(this.radButton1);
            this.Controls.Add(this.checkedListBoxWorkers);
            this.Controls.Add(this.cmbx_projects);
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
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadLabel lbl_worker;
        private Telerik.WinControls.UI.RadLabel lbl_project;
        private Telerik.WinControls.UI.RadButton btn_addProjectToWorker;
        private System.Windows.Forms.ComboBox cmbx_projects;
        private System.Windows.Forms.CheckedListBox checkedListBoxWorkers;
        private Telerik.WinControls.Themes.MaterialTealTheme materialTealTheme1;
        private Telerik.WinControls.UI.RadButton radButton1;
    }
}