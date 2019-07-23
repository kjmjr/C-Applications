namespace TicTacToeGame
{
    partial class ticTacToeForm
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.A1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(337, 417);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = " &Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(173, 417);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 32);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(173, 355);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(239, 20);
            this.txtResult.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(207, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(151, 13);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "Click a button to make a move";
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.DarkRed;
            this.A1.Location = new System.Drawing.Point(140, 55);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(94, 80);
            this.A1.TabIndex = 13;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.btn_click_show);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.ForeColor = System.Drawing.Color.DarkRed;
            this.A2.Location = new System.Drawing.Point(243, 55);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(97, 80);
            this.A2.TabIndex = 14;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.btn_click_show);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.ForeColor = System.Drawing.Color.DarkRed;
            this.A3.Location = new System.Drawing.Point(346, 55);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(97, 80);
            this.A3.TabIndex = 15;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.btn_click_show);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.ForeColor = System.Drawing.Color.DarkRed;
            this.B3.Location = new System.Drawing.Point(346, 141);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(97, 80);
            this.B3.TabIndex = 18;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.btn_click_show);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.ForeColor = System.Drawing.Color.DarkRed;
            this.B2.Location = new System.Drawing.Point(243, 141);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(97, 80);
            this.B2.TabIndex = 17;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.btn_click_show);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.ForeColor = System.Drawing.Color.DarkRed;
            this.B1.Location = new System.Drawing.Point(140, 141);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(94, 80);
            this.B1.TabIndex = 16;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.btn_click_show);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.ForeColor = System.Drawing.Color.DarkRed;
            this.C3.Location = new System.Drawing.Point(346, 236);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(97, 80);
            this.C3.TabIndex = 21;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.btn_click_show);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.ForeColor = System.Drawing.Color.DarkRed;
            this.C2.Location = new System.Drawing.Point(243, 236);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(97, 80);
            this.C2.TabIndex = 20;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.btn_click_show);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.ForeColor = System.Drawing.Color.DarkRed;
            this.C1.Location = new System.Drawing.Point(140, 236);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(94, 80);
            this.C1.TabIndex = 19;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.btn_click_show);
            // 
            // ticTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 520);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnExit);
            this.Name = "ticTacToeForm";
            this.Text = "Tic - Tac - Toe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C1;
    }
}

