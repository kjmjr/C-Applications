namespace Telephone_unformat
{
    partial class telephoneUnformatForm
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUnformat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtNumberBox = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(233, 339);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUnformat
            // 
            this.btnUnformat.Location = new System.Drawing.Point(365, 339);
            this.btnUnformat.Name = "btnUnformat";
            this.btnUnformat.Size = new System.Drawing.Size(75, 23);
            this.btnUnformat.TabIndex = 1;
            this.btnUnformat.Text = "Unformat";
            this.btnUnformat.UseVisualStyleBackColor = true;
            this.btnUnformat.Click += new System.EventHandler(this.btnUnformat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(505, 339);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtNumberBox
            // 
            this.txtNumberBox.Location = new System.Drawing.Point(233, 281);
            this.txtNumberBox.Name = "txtNumberBox";
            this.txtNumberBox.Size = new System.Drawing.Size(339, 20);
            this.txtNumberBox.TabIndex = 3;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(297, 146);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(172, 13);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Enter a telephone number in format";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(284, 176);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(217, 13);
            this.lblInfo2.TabIndex = 5;
            this.lblInfo2.Text = "(XXX)XXX-XXXX and I will unformat it for you";
            // 
            // telephoneUnformatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtNumberBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUnformat);
            this.Controls.Add(this.btnClear);
            this.Name = "telephoneUnformatForm";
            this.Text = "Telephone Unformat Application";
            this.Load += new System.EventHandler(this.telephoneUnformatForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUnformat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtNumberBox;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblInfo2;
    }
}

