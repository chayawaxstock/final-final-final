namespace manageTask
{
    partial class DeleteWorker
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
            this.label1 = new Telerik.WinControls.UI.RadLabel();
            this.lbl_name = new Telerik.WinControls.UI.RadLabel();
            this.cmbx_workers = new System.Windows.Forms.ComboBox();
            this.btn_delete = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(300, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the worker you want to delete";
            // 
            // lbl_name
            // 
            this.lbl_name.Location = new System.Drawing.Point(300, 152);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(76, 18);
            this.lbl_name.TabIndex = 2;
            this.lbl_name.Text = "Worker name:";
            // 
            // cmbx_workers
            // 
            this.cmbx_workers.FormattingEnabled = true;
            this.cmbx_workers.Location = new System.Drawing.Point(382, 152);
            this.cmbx_workers.Name = "cmbx_workers";
            this.cmbx_workers.Size = new System.Drawing.Size(121, 21);
            this.cmbx_workers.TabIndex = 3;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(358, 205);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(110, 24);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete worker";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // DeleteWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.cmbx_workers);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.label1);
            this.Name = "DeleteWorker";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Delete worker";
            this.Load += new System.EventHandler(this.DeleteWorker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbl_name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel label1;
        private Telerik.WinControls.UI.RadLabel lbl_name;
        private System.Windows.Forms.ComboBox cmbx_workers;
        private Telerik.WinControls.UI.RadButton btn_delete;
    }
}