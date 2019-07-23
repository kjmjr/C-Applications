namespace Sales
{
    partial class totalSales
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
            this.lstArray = new System.Windows.Forms.ListBox();
            this.btnArrayClick = new System.Windows.Forms.Button();
            this.lblLargest = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblSmallest = new System.Windows.Forms.Label();
            this.txtLargest = new System.Windows.Forms.TextBox();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.txtSmallest = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstArray
            // 
            this.lstArray.FormattingEnabled = true;
            this.lstArray.Location = new System.Drawing.Point(67, 42);
            this.lstArray.Name = "lstArray";
            this.lstArray.Size = new System.Drawing.Size(120, 95);
            this.lstArray.TabIndex = 0;
            // 
            // btnArrayClick
            // 
            this.btnArrayClick.Location = new System.Drawing.Point(15, 158);
            this.btnArrayClick.Name = "btnArrayClick";
            this.btnArrayClick.Size = new System.Drawing.Size(231, 23);
            this.btnArrayClick.TabIndex = 1;
            this.btnArrayClick.Text = "Show and Calculate Array";
            this.btnArrayClick.UseVisualStyleBackColor = true;
            this.btnArrayClick.Click += new System.EventHandler(this.btnArrayClick_Click);
            // 
            // lblLargest
            // 
            this.lblLargest.AutoSize = true;
            this.lblLargest.Location = new System.Drawing.Point(12, 231);
            this.lblLargest.Name = "lblLargest";
            this.lblLargest.Size = new System.Drawing.Size(72, 13);
            this.lblLargest.TabIndex = 2;
            this.lblLargest.Text = "Largest Value";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(129, 231);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(47, 13);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average";
            // 
            // lblSmallest
            // 
            this.lblSmallest.AutoSize = true;
            this.lblSmallest.Location = new System.Drawing.Point(216, 231);
            this.lblSmallest.Name = "lblSmallest";
            this.lblSmallest.Size = new System.Drawing.Size(76, 13);
            this.lblSmallest.TabIndex = 4;
            this.lblSmallest.Text = "Smallest Value";
            // 
            // txtLargest
            // 
            this.txtLargest.Location = new System.Drawing.Point(15, 261);
            this.txtLargest.Name = "txtLargest";
            this.txtLargest.ReadOnly = true;
            this.txtLargest.Size = new System.Drawing.Size(69, 20);
            this.txtLargest.TabIndex = 5;
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(118, 261);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(69, 20);
            this.txtAverage.TabIndex = 6;
            // 
            // txtSmallest
            // 
            this.txtSmallest.Location = new System.Drawing.Point(219, 261);
            this.txtSmallest.Name = "txtSmallest";
            this.txtSmallest.ReadOnly = true;
            this.txtSmallest.Size = new System.Drawing.Size(73, 20);
            this.txtSmallest.TabIndex = 7;
            // 
            // totalSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 328);
            this.Controls.Add(this.txtSmallest);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.txtLargest);
            this.Controls.Add(this.lblSmallest);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblLargest);
            this.Controls.Add(this.btnArrayClick);
            this.Controls.Add(this.lstArray);
            this.Name = "totalSales";
            this.Text = "Total Sales App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstArray;
        private System.Windows.Forms.Button btnArrayClick;
        private System.Windows.Forms.Label lblLargest;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblSmallest;
        private System.Windows.Forms.TextBox txtLargest;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.TextBox txtSmallest;
    }
}

