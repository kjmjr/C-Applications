namespace finalProject
{
    partial class guesserTwo
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
            this.lblGuessTwo = new System.Windows.Forms.Label();
            this.btnClearTwo = new System.Windows.Forms.Button();
            this.btnGuessTwo = new System.Windows.Forms.Button();
            this.btnExitTwo = new System.Windows.Forms.Button();
            this.txtGuessTwo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGuessTwo
            // 
            this.lblGuessTwo.AutoSize = true;
            this.lblGuessTwo.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGuessTwo.Location = new System.Drawing.Point(171, 47);
            this.lblGuessTwo.Name = "lblGuessTwo";
            this.lblGuessTwo.Size = new System.Drawing.Size(337, 55);
            this.lblGuessTwo.TabIndex = 1;
            this.lblGuessTwo.Text = "Guess a Letter!";
            // 
            // btnClearTwo
            // 
            this.btnClearTwo.BackColor = System.Drawing.Color.Gray;
            this.btnClearTwo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTwo.Location = new System.Drawing.Point(181, 280);
            this.btnClearTwo.Name = "btnClearTwo";
            this.btnClearTwo.Size = new System.Drawing.Size(360, 51);
            this.btnClearTwo.TabIndex = 8;
            this.btnClearTwo.Text = "Clear Input";
            this.btnClearTwo.UseVisualStyleBackColor = false;
            this.btnClearTwo.Click += new System.EventHandler(this.btnClearTwo_Click);
            // 
            // btnGuessTwo
            // 
            this.btnGuessTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuessTwo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessTwo.Location = new System.Drawing.Point(181, 191);
            this.btnGuessTwo.Name = "btnGuessTwo";
            this.btnGuessTwo.Size = new System.Drawing.Size(360, 62);
            this.btnGuessTwo.TabIndex = 7;
            this.btnGuessTwo.Text = "See if the letter matches?";
            this.btnGuessTwo.UseVisualStyleBackColor = false;
            this.btnGuessTwo.Click += new System.EventHandler(this.btnGuessTwo_Click);
            // 
            // btnExitTwo
            // 
            this.btnExitTwo.BackColor = System.Drawing.Color.Red;
            this.btnExitTwo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitTwo.Location = new System.Drawing.Point(181, 345);
            this.btnExitTwo.Name = "btnExitTwo";
            this.btnExitTwo.Size = new System.Drawing.Size(360, 61);
            this.btnExitTwo.TabIndex = 6;
            this.btnExitTwo.Text = "Exit";
            this.btnExitTwo.UseVisualStyleBackColor = false;
            this.btnExitTwo.Click += new System.EventHandler(this.btnExitTwo_Click);
            // 
            // txtGuessTwo
            // 
            this.txtGuessTwo.Location = new System.Drawing.Point(181, 149);
            this.txtGuessTwo.Name = "txtGuessTwo";
            this.txtGuessTwo.Size = new System.Drawing.Size(360, 20);
            this.txtGuessTwo.TabIndex = 5;
            // 
            // guesserTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearTwo);
            this.Controls.Add(this.btnGuessTwo);
            this.Controls.Add(this.btnExitTwo);
            this.Controls.Add(this.txtGuessTwo);
            this.Controls.Add(this.lblGuessTwo);
            this.Name = "guesserTwo";
            this.Text = "Wheel of Fortune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessTwo;
        private System.Windows.Forms.Button btnClearTwo;
        private System.Windows.Forms.Button btnGuessTwo;
        private System.Windows.Forms.Button btnExitTwo;
        public System.Windows.Forms.TextBox txtGuessTwo;
    }
}