namespace ChangingAreaPerZach
{
    partial class frmChangingAreaPer
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtLegthInput = new System.Windows.Forms.TextBox();
            this.txtWidthInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(52, 57);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(57, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length (m)";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(52, 124);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(52, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width (m)";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(52, 218);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(94, 13);
            this.lblPerimeter.TabIndex = 2;
            this.lblPerimeter.Text = "The perimeter is:   ";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(52, 263);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(63, 13);
            this.lblArea.TabIndex = 3;
            this.lblArea.Text = "The area is:";
            // 
            // txtLegthInput
            // 
            this.txtLegthInput.Location = new System.Drawing.Point(153, 57);
            this.txtLegthInput.Name = "txtLegthInput";
            this.txtLegthInput.Size = new System.Drawing.Size(100, 20);
            this.txtLegthInput.TabIndex = 4;
            this.txtLegthInput.TextChanged += new System.EventHandler(this.txtLegthInput_TextChanged);
            // 
            // txtWidthInput
            // 
            this.txtWidthInput.Location = new System.Drawing.Point(153, 117);
            this.txtWidthInput.Name = "txtWidthInput";
            this.txtWidthInput.Size = new System.Drawing.Size(100, 20);
            this.txtWidthInput.TabIndex = 5;
            // 
            // frmChangingAreaPer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 310);
            this.Controls.Add(this.txtWidthInput);
            this.Controls.Add(this.txtLegthInput);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Name = "frmChangingAreaPer";
            this.Text = "Changing Area and Perimeter Zach";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtLegthInput;
        private System.Windows.Forms.TextBox txtWidthInput;
    }
}

