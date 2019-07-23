namespace finalProject
{
    partial class solver
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblSolve = new System.Windows.Forms.Label();
            this.txtSolve = new System.Windows.Forms.TextBox();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(71, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(319, 51);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblSolve
            // 
            this.lblSolve.AutoSize = true;
            this.lblSolve.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSolve.Location = new System.Drawing.Point(27, 44);
            this.lblSolve.Name = "lblSolve";
            this.lblSolve.Size = new System.Drawing.Size(437, 36);
            this.lblSolve.TabIndex = 1;
            this.lblSolve.Text = "Be brave and guess the puzzle?";
            // 
            // txtSolve
            // 
            this.txtSolve.Location = new System.Drawing.Point(54, 162);
            this.txtSolve.Name = "txtSolve";
            this.txtSolve.Size = new System.Drawing.Size(379, 20);
            this.txtSolve.TabIndex = 2;
            // 
            // btnSolve
            // 
            this.btnSolve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSolve.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.ForeColor = System.Drawing.Color.White;
            this.btnSolve.Location = new System.Drawing.Point(71, 217);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(319, 47);
            this.btnSolve.TabIndex = 3;
            this.btnSolve.Text = "Solve puzzle";
            this.btnSolve.UseVisualStyleBackColor = false;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(71, 282);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(319, 49);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Input";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // solver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.txtSolve);
            this.Controls.Add(this.lblSolve);
            this.Controls.Add(this.btnExit);
            this.Name = "solver";
            this.Text = "Wheel of Fortune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblSolve;
        private System.Windows.Forms.TextBox txtSolve;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnClear;
    }
}