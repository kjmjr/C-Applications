namespace distanceConverter
{
    partial class distanceConverter
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
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtDistance = new System.Windows.Forms.TextBox();
            this.grpFrom = new System.Windows.Forms.GroupBox();
            this.lstFromBox = new System.Windows.Forms.ListBox();
            this.grpTo = new System.Windows.Forms.GroupBox();
            this.lstToBox = new System.Windows.Forms.ListBox();
            this.lblConverted = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpFrom.SuspendLayout();
            this.grpTo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(48, 48);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(138, 13);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter a distance to convert:";
            // 
            // txtDistance
            // 
            this.txtDistance.Location = new System.Drawing.Point(248, 48);
            this.txtDistance.Name = "txtDistance";
            this.txtDistance.Size = new System.Drawing.Size(181, 20);
            this.txtDistance.TabIndex = 1;
            // 
            // grpFrom
            // 
            this.grpFrom.Controls.Add(this.lstFromBox);
            this.grpFrom.Location = new System.Drawing.Point(40, 129);
            this.grpFrom.Name = "grpFrom";
            this.grpFrom.Size = new System.Drawing.Size(167, 129);
            this.grpFrom.TabIndex = 2;
            this.grpFrom.TabStop = false;
            this.grpFrom.Text = "From";
            // 
            // lstFromBox
            // 
            this.lstFromBox.FormattingEnabled = true;
            this.lstFromBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lstFromBox.Location = new System.Drawing.Point(26, 16);
            this.lstFromBox.Name = "lstFromBox";
            this.lstFromBox.Size = new System.Drawing.Size(120, 95);
            this.lstFromBox.TabIndex = 0;
           // this.lstFromBox.SelectedIndexChanged += new System.EventHandler(this.lstFromBox_SelectedIndexChanged);
            // 
            // grpTo
            // 
            this.grpTo.Controls.Add(this.lstToBox);
            this.grpTo.Location = new System.Drawing.Point(248, 129);
            this.grpTo.Name = "grpTo";
            this.grpTo.Size = new System.Drawing.Size(181, 129);
            this.grpTo.TabIndex = 3;
            this.grpTo.TabStop = false;
            this.grpTo.Text = "To";
            // 
            // lstToBox
            // 
            this.lstToBox.FormattingEnabled = true;
            this.lstToBox.HorizontalScrollbar = true;
            this.lstToBox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.lstToBox.Location = new System.Drawing.Point(41, 17);
            this.lstToBox.Name = "lstToBox";
            this.lstToBox.Size = new System.Drawing.Size(120, 95);
            this.lstToBox.TabIndex = 0;
           // this.lstToBox.SelectedIndexChanged += new System.EventHandler(this.lstToBox_SelectedIndexChanged);
            // 
            // lblConverted
            // 
            this.lblConverted.AutoSize = true;
            this.lblConverted.Location = new System.Drawing.Point(67, 333);
            this.lblConverted.Name = "lblConverted";
            this.lblConverted.Size = new System.Drawing.Size(104, 13);
            this.lblConverted.TabIndex = 4;
            this.lblConverted.Text = "Converted Distance:";
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(245, 325);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(184, 20);
            this.txtAnswer.TabIndex = 5;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(70, 394);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(101, 23);
            this.btnConvert.TabIndex = 6;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(234, 394);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // distanceConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblConverted);
            this.Controls.Add(this.grpTo);
            this.Controls.Add(this.grpFrom);
            this.Controls.Add(this.txtDistance);
            this.Controls.Add(this.lblEnter);
            this.Name = "distanceConverter";
            this.Text = "Distance Converter";
            this.grpFrom.ResumeLayout(false);
            this.grpTo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.GroupBox grpFrom;
        private System.Windows.Forms.GroupBox grpTo;
        private System.Windows.Forms.Label lblConverted;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox lstFromBox;
        private System.Windows.Forms.ListBox lstToBox;
    }
}

