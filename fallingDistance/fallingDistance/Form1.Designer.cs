namespace fallingDistance
{
    partial class frmFallingDistance
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblFallingDistance = new System.Windows.Forms.Label();
            this.lblForTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(320, 295);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(156, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblFallingDistance
            // 
            this.lblFallingDistance.AutoSize = true;
            this.lblFallingDistance.Location = new System.Drawing.Point(285, 40);
            this.lblFallingDistance.Name = "lblFallingDistance";
            this.lblFallingDistance.Size = new System.Drawing.Size(209, 13);
            this.lblFallingDistance.TabIndex = 1;
            this.lblFallingDistance.Text = "Welcome to the Falling Distance Converter";
            // 
            // lblForTime
            // 
            this.lblForTime.AutoSize = true;
            this.lblForTime.Location = new System.Drawing.Point(151, 109);
            this.lblForTime.Name = "lblForTime";
            this.lblForTime.Size = new System.Drawing.Size(155, 13);
            this.lblForTime.TabIndex = 2;
            this.lblForTime.Text = "Please enter a time into the box";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(320, 106);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(156, 20);
            this.txtTime.TabIndex = 3;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(320, 375);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(156, 20);
            this.txtResults.TabIndex = 4;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(151, 375);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(73, 13);
            this.lblAnswer.TabIndex = 5;
            this.lblAnswer.Text = "The answer is";
            // 
            // frmFallingDistance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblForTime);
            this.Controls.Add(this.lblFallingDistance);
            this.Controls.Add(this.btnCalc);
            this.Name = "frmFallingDistance";
            this.Text = "Falling Distance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblFallingDistance;
        private System.Windows.Forms.Label lblForTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblAnswer;
    }
}

