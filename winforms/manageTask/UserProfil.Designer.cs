namespace manageTask
{
    partial class UserProfil
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_log_out = new Telerik.WinControls.UI.RadButton();
            this.name_value = new Telerik.WinControls.UI.RadLabel();
            this.department_value = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.btn_log_out)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_log_out
            // 
            this.btn_log_out.Location = new System.Drawing.Point(313, 21);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(67, 24);
            this.btn_log_out.TabIndex = 3;
            this.btn_log_out.Text = "Log out";
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // name_value
            // 
            this.name_value.Location = new System.Drawing.Point(40, 21);
            this.name_value.Name = "name_value";
            this.name_value.Size = new System.Drawing.Size(2, 2);
            this.name_value.TabIndex = 6;
            // 
            // department_value
            // 
            this.department_value.Location = new System.Drawing.Point(147, 21);
            this.department_value.Name = "department_value";
            this.department_value.Size = new System.Drawing.Size(2, 2);
            this.department_value.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(462, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UserProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.department_value);
            this.Controls.Add(this.name_value);
            this.Controls.Add(this.btn_log_out);
            this.Name = "UserProfil";
            this.Size = new System.Drawing.Size(592, 66);
            ((System.ComponentModel.ISupportInitialize)(this.btn_log_out)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.name_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.department_value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Telerik.WinControls.UI.RadButton btn_log_out;
        private Telerik.WinControls.UI.RadLabel name_value;
        private Telerik.WinControls.UI.RadLabel department_value;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
