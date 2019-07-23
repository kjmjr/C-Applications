namespace finalProject
{
    partial class winner
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
            this.lblWinner = new System.Windows.Forms.Label();
            this.txtWinner = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblWinner.Location = new System.Drawing.Point(74, 79);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(229, 55);
            this.lblWinner.TabIndex = 0;
            this.lblWinner.Text = "Congrats!";
            // 
            // txtWinner
            // 
            this.txtWinner.BackColor = System.Drawing.Color.Silver;
            this.txtWinner.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinner.Location = new System.Drawing.Point(156, 213);
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.ReadOnly = true;
            this.txtWinner.Size = new System.Drawing.Size(219, 20);
            this.txtWinner.TabIndex = 1;
            this.txtWinner.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(156, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(219, 53);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.BackColor = System.Drawing.Color.Silver;
            this.txtTotalAmount.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(156, 271);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(219, 22);
            this.txtTotalAmount.TabIndex = 3;
            this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(56, 213);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(54, 15);
            this.lblPlayer.TabIndex = 4;
            this.lblPlayer.Text = "Winner:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(34, 274);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(105, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total Money Won:";
            // 
            // winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.txtTotalAmount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtWinner);
            this.Controls.Add(this.lblWinner);
            this.Name = "winner";
            this.Text = "Wheel of Fortune";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnExit;
        public System.Windows.Forms.TextBox txtWinner;
        public System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblTotal;
    }
}