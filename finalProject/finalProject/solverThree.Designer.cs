namespace finalProject
{
    partial class solverThree
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
            this.btnSolveThree = new System.Windows.Forms.Button();
            this.txtSolveThree = new System.Windows.Forms.TextBox();
            this.lblSolveThree = new System.Windows.Forms.Label();
            this.btnExitThree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClearThree
            // 
            this.btnClearThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClearThree.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearThree.ForeColor = System.Drawing.Color.White;
            this.btnClearThree.Location = new System.Drawing.Point(226, 284);
            this.btnClearThree.Name = "btnClearThree";
            this.btnClearThree.Size = new System.Drawing.Size(319, 49);
            this.btnClearThree.TabIndex = 9;
            this.btnClearThree.Text = "Clear Input";
            this.btnClearThree.UseVisualStyleBackColor = false;
            // 
            // btnSolveThree
            // 
            this.btnSolveThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSolveThree.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolveThree.ForeColor = System.Drawing.Color.White;
            this.btnSolveThree.Location = new System.Drawing.Point(226, 219);
            this.btnSolveThree.Name = "btnSolveThree";
            this.btnSolveThree.Size = new System.Drawing.Size(319, 47);
            this.btnSolveThree.TabIndex = 8;
            this.btnSolveThree.Text = "Solve puzzle";
            this.btnSolveThree.UseVisualStyleBackColor = false;
            // 
            // txtSolveThree
            // 
            this.txtSolveThree.Location = new System.Drawing.Point(209, 164);
            this.txtSolveThree.Name = "txtSolveThree";
            this.txtSolveThree.Size = new System.Drawing.Size(379, 20);
            this.txtSolveThree.TabIndex = 7;
            // 
            // lblSolveThree
            // 
            this.lblSolveThree.AutoSize = true;
            this.lblSolveThree.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolveThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSolveThree.Location = new System.Drawing.Point(182, 46);
            this.lblSolveThree.Name = "lblSolveThree";
            this.lblSolveThree.Size = new System.Drawing.Size(437, 36);
            this.lblSolveThree.TabIndex = 6;
            this.lblSolveThree.Text = "Be brave and guess the puzzle?";
            // 
            // btnExitThree
            // 
            this.btnExitThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExitThree.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitThree.ForeColor = System.Drawing.Color.White;
            this.btnExitThree.Location = new System.Drawing.Point(226, 354);
            this.btnExitThree.Name = "btnExitThree";
            this.btnExitThree.Size = new System.Drawing.Size(319, 51);
            this.btnExitThree.TabIndex = 5;
            this.btnExitThree.Text = "Exit";
            this.btnExitThree.UseVisualStyleBackColor = false;
            // 
            // solverThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearThree);
            this.Controls.Add(this.btnSolveThree);
            this.Controls.Add(this.txtSolveThree);
            this.Controls.Add(this.lblSolveThree);
            this.Controls.Add(this.btnExitThree);
            this.Name = "solverThree";
            this.Text = "Wheel of Fortune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearThree;
        private System.Windows.Forms.Button btnSolveThree;
        private System.Windows.Forms.TextBox txtSolveThree;
        private System.Windows.Forms.Label lblSolveThree;
        private System.Windows.Forms.Button btnExitThree;
    }
}