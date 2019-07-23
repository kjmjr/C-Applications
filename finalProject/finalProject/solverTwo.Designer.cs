namespace finalProject
{
    partial class solverTwo
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
            this.btnClearTwo = new System.Windows.Forms.Button();
            this.btnSolveTwo = new System.Windows.Forms.Button();
            this.txtSolveTwo = new System.Windows.Forms.TextBox();
            this.lblSolveTwo = new System.Windows.Forms.Label();
            this.btnExitTwo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClearTwo
            // 
            this.btnClearTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearTwo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearTwo.ForeColor = System.Drawing.Color.White;
            this.btnClearTwo.Location = new System.Drawing.Point(226, 284);
            this.btnClearTwo.Name = "btnClearTwo";
            this.btnClearTwo.Size = new System.Drawing.Size(319, 49);
            this.btnClearTwo.TabIndex = 9;
            this.btnClearTwo.Text = "Clear Input";
            this.btnClearTwo.UseVisualStyleBackColor = false;
            // 
            // btnSolveTwo
            // 
            this.btnSolveTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSolveTwo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolveTwo.ForeColor = System.Drawing.Color.White;
            this.btnSolveTwo.Location = new System.Drawing.Point(226, 219);
            this.btnSolveTwo.Name = "btnSolveTwo";
            this.btnSolveTwo.Size = new System.Drawing.Size(319, 47);
            this.btnSolveTwo.TabIndex = 8;
            this.btnSolveTwo.Text = "Solve puzzle";
            this.btnSolveTwo.UseVisualStyleBackColor = false;
            // 
            // txtSolveTwo
            // 
            this.txtSolveTwo.Location = new System.Drawing.Point(209, 164);
            this.txtSolveTwo.Name = "txtSolveTwo";
            this.txtSolveTwo.Size = new System.Drawing.Size(379, 20);
            this.txtSolveTwo.TabIndex = 7;
            // 
            // lblSolveTwo
            // 
            this.lblSolveTwo.AutoSize = true;
            this.lblSolveTwo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolveTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSolveTwo.Location = new System.Drawing.Point(182, 46);
            this.lblSolveTwo.Name = "lblSolveTwo";
            this.lblSolveTwo.Size = new System.Drawing.Size(437, 36);
            this.lblSolveTwo.TabIndex = 6;
            this.lblSolveTwo.Text = "Be brave and guess the puzzle?";
            // 
            // btnExitTwo
            // 
            this.btnExitTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExitTwo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitTwo.ForeColor = System.Drawing.Color.White;
            this.btnExitTwo.Location = new System.Drawing.Point(226, 354);
            this.btnExitTwo.Name = "btnExitTwo";
            this.btnExitTwo.Size = new System.Drawing.Size(319, 51);
            this.btnExitTwo.TabIndex = 5;
            this.btnExitTwo.Text = "Exit";
            this.btnExitTwo.UseVisualStyleBackColor = false;
            // 
            // solverTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearTwo);
            this.Controls.Add(this.btnSolveTwo);
            this.Controls.Add(this.txtSolveTwo);
            this.Controls.Add(this.lblSolveTwo);
            this.Controls.Add(this.btnExitTwo);
            this.Name = "solverTwo";
            this.Text = "Wheel of Fortune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnClearTwo;
        public System.Windows.Forms.Button btnSolveTwo;
        public System.Windows.Forms.TextBox txtSolveTwo;
        public System.Windows.Forms.Label lblSolveTwo;
        public System.Windows.Forms.Button btnExitTwo;
    }
}