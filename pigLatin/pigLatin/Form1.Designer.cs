namespace pigLatin
{
    partial class pigLatinForm
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
            this.lblEnglish = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtVowels = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Location = new System.Drawing.Point(12, 62);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(178, 13);
            this.lblEnglish.TabIndex = 0;
            this.lblEnglish.Text = "Enter a word or sentence in the box:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(122, 162);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(262, 13);
            this.lblOutput.TabIndex = 1;
            this.lblOutput.Text = "Click the Display button to view your input in Pig Latin:";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(204, 201);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(269, 59);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(190, 20);
            this.txtInput.TabIndex = 3;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(69, 259);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(370, 20);
            this.txtOutput.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(160, 309);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(202, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // txtVowels
            // 
            this.txtVowels.Location = new System.Drawing.Point(160, 356);
            this.txtVowels.Name = "txtVowels";
            this.txtVowels.Size = new System.Drawing.Size(202, 20);
            this.txtVowels.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(429, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 47);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 329);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 47);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Items";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pigLatinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 402);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtVowels);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblEnglish);
            this.Name = "pigLatinForm";
            this.Text = "Pig Latin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtVowels;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
    }
}

