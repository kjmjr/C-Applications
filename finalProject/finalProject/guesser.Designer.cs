namespace finalProject
{
    partial class guesser
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
            this.lblGuessOne = new System.Windows.Forms.Label();
            this.txtGuessOne = new System.Windows.Forms.TextBox();
            this.btnExitOne = new System.Windows.Forms.Button();
            this.btnGuessOne = new System.Windows.Forms.Button();
            this.btnClearOne = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGuessOne
            // 
            this.lblGuessOne.AutoSize = true;
            this.lblGuessOne.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGuessOne.Location = new System.Drawing.Point(44, 58);
            this.lblGuessOne.Name = "lblGuessOne";
            this.lblGuessOne.Size = new System.Drawing.Size(337, 55);
            this.lblGuessOne.TabIndex = 0;
            this.lblGuessOne.Text = "Guess a Letter!";
            // 
            // txtGuessOne
            // 
            this.txtGuessOne.Location = new System.Drawing.Point(41, 168);
            this.txtGuessOne.Name = "txtGuessOne";
            this.txtGuessOne.Size = new System.Drawing.Size(360, 20);
            this.txtGuessOne.TabIndex = 1;
            // 
            // btnExitOne
            // 
            this.btnExitOne.BackColor = System.Drawing.Color.Red;
            this.btnExitOne.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitOne.Location = new System.Drawing.Point(41, 364);
            this.btnExitOne.Name = "btnExitOne";
            this.btnExitOne.Size = new System.Drawing.Size(360, 61);
            this.btnExitOne.TabIndex = 2;
            this.btnExitOne.Text = "Exit";
            this.btnExitOne.UseVisualStyleBackColor = false;
            this.btnExitOne.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnGuessOne
            // 
            this.btnGuessOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuessOne.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessOne.Location = new System.Drawing.Point(41, 210);
            this.btnGuessOne.Name = "btnGuessOne";
            this.btnGuessOne.Size = new System.Drawing.Size(360, 62);
            this.btnGuessOne.TabIndex = 3;
            this.btnGuessOne.Text = "See if the letter matches?";
            this.btnGuessOne.UseVisualStyleBackColor = false;
            this.btnGuessOne.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // btnClearOne
            // 
            this.btnClearOne.BackColor = System.Drawing.Color.Gray;
            this.btnClearOne.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearOne.Location = new System.Drawing.Point(41, 299);
            this.btnClearOne.Name = "btnClearOne";
            this.btnClearOne.Size = new System.Drawing.Size(360, 51);
            this.btnClearOne.TabIndex = 4;
            this.btnClearOne.Text = "Clear Input";
            this.btnClearOne.UseVisualStyleBackColor = false;
            this.btnClearOne.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // guesser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 450);
            this.Controls.Add(this.btnClearOne);
            this.Controls.Add(this.btnGuessOne);
            this.Controls.Add(this.btnExitOne);
            this.Controls.Add(this.txtGuessOne);
            this.Controls.Add(this.lblGuessOne);
            this.Name = "guesser";
            this.Text = "Wheel of Fortune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessOne;
        private System.Windows.Forms.Button btnExitOne;
        private System.Windows.Forms.Button btnGuessOne;
        private System.Windows.Forms.Button btnClearOne;
        public System.Windows.Forms.TextBox txtGuessOne;
    }
}