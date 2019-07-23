namespace CarClass
{
    partial class Information
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
            this.lblCarYear = new System.Windows.Forms.Label();
            this.lblCarMake = new System.Windows.Forms.Label();
            this.txtCarYear = new System.Windows.Forms.TextBox();
            this.txtCarMake = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCarYear
            // 
            this.lblCarYear.AutoSize = true;
            this.lblCarYear.Location = new System.Drawing.Point(59, 64);
            this.lblCarYear.Name = "lblCarYear";
            this.lblCarYear.Size = new System.Drawing.Size(103, 13);
            this.lblCarYear.TabIndex = 0;
            this.lblCarYear.Text = "The Year of the Car:";
            // 
            // lblCarMake
            // 
            this.lblCarMake.AutoSize = true;
            this.lblCarMake.Location = new System.Drawing.Point(59, 144);
            this.lblCarMake.Name = "lblCarMake";
            this.lblCarMake.Size = new System.Drawing.Size(107, 13);
            this.lblCarMake.TabIndex = 1;
            this.lblCarMake.Text = "The make of the Car:";
            // 
            // txtCarYear
            // 
            this.txtCarYear.Location = new System.Drawing.Point(208, 64);
            this.txtCarYear.Name = "txtCarYear";
            this.txtCarYear.Size = new System.Drawing.Size(203, 20);
            this.txtCarYear.TabIndex = 2;
            // 
            // txtCarMake
            // 
            this.txtCarMake.Location = new System.Drawing.Point(208, 136);
            this.txtCarMake.Name = "txtCarMake";
            this.txtCarMake.Size = new System.Drawing.Size(203, 20);
            this.txtCarMake.TabIndex = 3;
            // 
            // Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.txtCarMake);
            this.Controls.Add(this.txtCarYear);
            this.Controls.Add(this.lblCarMake);
            this.Controls.Add(this.lblCarYear);
            this.Name = "Information";
            this.Text = "Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCarYear;
        private System.Windows.Forms.Label lblCarMake;
        public System.Windows.Forms.TextBox txtCarYear;
        public System.Windows.Forms.TextBox txtCarMake;
    }
}