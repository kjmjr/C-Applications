namespace Car_List
{
    partial class carListForm
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
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblCarInfo = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMileage = new System.Windows.Forms.Label();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.lstCarListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(112, 335);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(128, 64);
            this.btnAddCar.TabIndex = 0;
            this.btnAddCar.Text = "Add Car to List";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(533, 335);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(104, 64);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display Car List";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // lblCarInfo
            // 
            this.lblCarInfo.AutoSize = true;
            this.lblCarInfo.Location = new System.Drawing.Point(75, 38);
            this.lblCarInfo.Name = "lblCarInfo";
            this.lblCarInfo.Size = new System.Drawing.Size(78, 13);
            this.lblCarInfo.TabIndex = 2;
            this.lblCarInfo.Text = "Car Information";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(78, 93);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(37, 13);
            this.lblMake.TabIndex = 3;
            this.lblMake.Text = "Make:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(78, 137);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(32, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(81, 182);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(47, 13);
            this.lblMileage.TabIndex = 5;
            this.lblMileage.Text = "Mileage:";
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(155, 85);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(155, 129);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 7;
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(155, 174);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(100, 20);
            this.txtMileage.TabIndex = 8;
            // 
            // lstCarListBox
            // 
            this.lstCarListBox.FormattingEnabled = true;
            this.lstCarListBox.Location = new System.Drawing.Point(441, 85);
            this.lstCarListBox.Name = "lstCarListBox";
            this.lstCarListBox.Size = new System.Drawing.Size(256, 108);
            this.lstCarListBox.TabIndex = 9;
            // 
            // carListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstCarListBox);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblCarInfo);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAddCar);
            this.Name = "carListForm";
            this.Text = "Car List";
            this.Load += new System.EventHandler(this.carListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblCarInfo;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.ListBox lstCarListBox;
    }
}

