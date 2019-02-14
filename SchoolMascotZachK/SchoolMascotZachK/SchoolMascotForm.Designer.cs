namespace SchoolMascotZachK
{
    partial class frmSchoolMascot
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
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblSchoolMascot = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.mnuSchools = new System.Windows.Forms.MenuStrip();
            this.mniSchool = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMotherTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStMark = new System.Windows.Forms.ToolStripMenuItem();
            this.grbSchool.SuspendLayout();
            this.mnuSchools.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblSchoolMascot);
            this.grbSchool.Controls.Add(this.lblSchoolName);
            this.grbSchool.Location = new System.Drawing.Point(27, 126);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(220, 105);
            this.grbSchool.TabIndex = 0;
            this.grbSchool.TabStop = false;
            // 
            // lblSchoolMascot
            // 
            this.lblSchoolMascot.AutoSize = true;
            this.lblSchoolMascot.Location = new System.Drawing.Point(37, 68);
            this.lblSchoolMascot.Name = "lblSchoolMascot";
            this.lblSchoolMascot.Size = new System.Drawing.Size(42, 13);
            this.lblSchoolMascot.TabIndex = 1;
            this.lblSchoolMascot.Text = "Mascot";
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Location = new System.Drawing.Point(37, 26);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(35, 13);
            this.lblSchoolName.TabIndex = 0;
            this.lblSchoolName.Text = "Name";
            // 
            // mnuSchools
            // 
            this.mnuSchools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchool});
            this.mnuSchools.Location = new System.Drawing.Point(0, 0);
            this.mnuSchools.Name = "mnuSchools";
            this.mnuSchools.Size = new System.Drawing.Size(284, 24);
            this.mnuSchools.TabIndex = 1;
            this.mnuSchools.Text = "menuStrip1";
            // 
            // mniSchool
            // 
            this.mniSchool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniMotherTeresa,
            this.mniImmaculata,
            this.mniStMark});
            this.mniSchool.Name = "mniSchool";
            this.mniSchool.Size = new System.Drawing.Size(55, 20);
            this.mniSchool.Text = "School";
            // 
            // mniMotherTeresa
            // 
            this.mniMotherTeresa.Name = "mniMotherTeresa";
            this.mniMotherTeresa.Size = new System.Drawing.Size(149, 22);
            this.mniMotherTeresa.Text = "Mother Teresa";
            this.mniMotherTeresa.Click += new System.EventHandler(this.mniMotherTeresa_Click);
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(149, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click_1);
            // 
            // mniStMark
            // 
            this.mniStMark.Name = "mniStMark";
            this.mniStMark.Size = new System.Drawing.Size(149, 22);
            this.mniStMark.Text = "St. Mark\'s";
            this.mniStMark.Click += new System.EventHandler(this.mniStMark_Click);
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuSchools);
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot by Zach K";
            this.Load += new System.EventHandler(this.SchoolMascotForm_Load);
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.mnuSchools.ResumeLayout(false);
            this.mnuSchools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblSchoolMascot;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.MenuStrip mnuSchools;
        private System.Windows.Forms.ToolStripMenuItem mniSchool;
        private System.Windows.Forms.ToolStripMenuItem mniMotherTeresa;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniStMark;
    }
}

