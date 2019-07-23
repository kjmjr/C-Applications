namespace finalProject
{
    partial class guesserThree
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
            this.btnClearThree = new System.Windows.Forms.Button();
            this.btnGuessThree = new System.Windows.Forms.Button();
            this.btnExitThree = new System.Windows.Forms.Button();
            this.txtGuessThree = new System.Windows.Forms.TextBox();
            this.lblGuessThree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClearThree
            // 
            this.btnClearThree.BackColor = System.Drawing.Color.Gray;
            this.btnClearThree.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearThree.Location = new System.Drawing.Point(225, 279);
            this.btnClearThree.Name = "btnClearThree";
            this.btnClearThree.Size = new System.Drawing.Size(360, 51);
            this.btnClearThree.TabIndex = 13;
            this.btnClearThree.Text = "Clear Input";
            this.btnClearThree.UseVisualStyleBackColor = false;
            this.btnClearThree.Click += new System.EventHandler(this.btnClearThree_Click);
            // 
            // btnGuessThree
            // 
            this.btnGuessThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuessThree.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuessThree.Location = new System.Drawing.Point(225, 190);
            this.btnGuessThree.Name = "btnGuessThree";
            this.btnGuessThree.Size = new System.Drawing.Size(360, 62);
            this.btnGuessThree.TabIndex = 12;
            this.btnGuessThree.Text = "See if the letter matches?";
            this.btnGuessThree.UseVisualStyleBackColor = false;
            this.btnGuessThree.Click += new System.EventHandler(this.btnGuessThree_Click);
            // 
            // btnExitThree
            // 
            this.btnExitThree.BackColor = System.Drawing.Color.Red;
            this.btnExitThree.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitThree.Location = new System.Drawing.Point(225, 344);
            this.btnExitThree.Name = "btnExitThree";
            this.btnExitThree.Size = new System.Drawing.Size(360, 61);
            this.btnExitThree.TabIndex = 11;
            this.btnExitThree.Text = "Exit";
            this.btnExitThree.UseVisualStyleBackColor = false;
            this.btnExitThree.Click += new System.EventHandler(this.btnExitThree_Click);
            // 
            // txtGuessThree
            // 
            this.txtGuessThree.Location = new System.Drawing.Point(225, 148);
            this.txtGuessThree.Name = "txtGuessThree";
            this.txtGuessThree.Size = new System.Drawing.Size(360, 20);
            this.txtGuessThree.TabIndex = 10;
            // 
            // lblGuessThree
            // 
            this.lblGuessThree.AutoSize = true;
            this.lblGuessThree.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuessThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblGuessThree.Location = new System.Drawing.Point(215, 46);
            this.lblGuessThree.Name = "lblGuessThree";
            this.lblGuessThree.Size = new System.Drawing.Size(337, 55);
            this.lblGuessThree.TabIndex = 9;
            this.lblGuessThree.Text = "Guess a Letter!";
            // 
            // guesserThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearThree);
            this.Controls.Add(this.btnGuessThree);
            this.Controls.Add(this.btnExitThree);
            this.Controls.Add(this.txtGuessThree);
            this.Controls.Add(this.lblGuessThree);
            this.Name = "guesserThree";
            this.Text = "Wheel of Fortune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearThree;
        private System.Windows.Forms.Button btnGuessThree;
        private System.Windows.Forms.Button btnExitThree;
        public System.Windows.Forms.TextBox txtGuessThree;
        private System.Windows.Forms.Label lblGuessThree;
    }
}