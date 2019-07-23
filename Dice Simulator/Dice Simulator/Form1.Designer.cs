namespace Dice_Simulator
{
    partial class frmDiceSimulator
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
            this.btnUser = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserRoll = new System.Windows.Forms.Label();
            this.lblComputersRoll = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.picComputer2 = new System.Windows.Forms.PictureBox();
            this.picComputer1 = new System.Windows.Forms.PictureBox();
            this.picUser2 = new System.Windows.Forms.PictureBox();
            this.picUser1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(525, 455);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 39);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(203, 404);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(220, 37);
            this.btnUser.TabIndex = 3;
            this.btnUser.Text = "Click to Roll Dice";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(291, 363);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 5;
            this.lblUser.Text = "User";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(253, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 13);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "Dice Simulator Game";
           // this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // lblUserRoll
            // 
            this.lblUserRoll.AutoSize = true;
            this.lblUserRoll.Location = new System.Drawing.Point(33, 140);
            this.lblUserRoll.Name = "lblUserRoll";
            this.lblUserRoll.Size = new System.Drawing.Size(61, 13);
            this.lblUserRoll.TabIndex = 9;
            this.lblUserRoll.Text = "User Rolls: ";
            // 
            // lblComputersRoll
            // 
            this.lblComputersRoll.AutoSize = true;
            this.lblComputersRoll.Location = new System.Drawing.Point(33, 278);
            this.lblComputersRoll.Name = "lblComputersRoll";
            this.lblComputersRoll.Size = new System.Drawing.Size(81, 13);
            this.lblComputersRoll.TabIndex = 10;
            this.lblComputersRoll.Text = "Computer Rolls:";
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(203, 474);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(220, 20);
            this.txtResults.TabIndex = 12;
            // 
            // picComputer2
            // 
            this.picComputer2.Image = global::Dice_Simulator.Properties.Resources.DiceTwo;
            this.picComputer2.Location = new System.Drawing.Point(368, 240);
            this.picComputer2.Name = "picComputer2";
            this.picComputer2.Size = new System.Drawing.Size(105, 91);
            this.picComputer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputer2.TabIndex = 14;
            this.picComputer2.TabStop = false;
            // 
            // picComputer1
            // 
            this.picComputer1.Image = global::Dice_Simulator.Properties.Resources.DiceFour;
            this.picComputer1.Location = new System.Drawing.Point(139, 240);
            this.picComputer1.Name = "picComputer1";
            this.picComputer1.Size = new System.Drawing.Size(104, 91);
            this.picComputer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputer1.TabIndex = 13;
            this.picComputer1.TabStop = false;
            // 
            // picUser2
            // 
            this.picUser2.Image = global::Dice_Simulator.Properties.Resources.DiceThree;
            this.picUser2.Location = new System.Drawing.Point(368, 89);
            this.picUser2.Name = "picUser2";
            this.picUser2.Size = new System.Drawing.Size(105, 106);
            this.picUser2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser2.TabIndex = 2;
            this.picUser2.TabStop = false;
            // 
            // picUser1
            // 
            this.picUser1.Image = global::Dice_Simulator.Properties.Resources.DiceFive;
            this.picUser1.Location = new System.Drawing.Point(139, 89);
            this.picUser1.Name = "picUser1";
            this.picUser1.Size = new System.Drawing.Size(104, 103);
            this.picUser1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser1.TabIndex = 1;
            this.picUser1.TabStop = false;
            // 
            // frmDiceSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 534);
            this.Controls.Add(this.picComputer2);
            this.Controls.Add(this.picComputer1);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblComputersRoll);
            this.Controls.Add(this.lblUserRoll);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.picUser2);
            this.Controls.Add(this.picUser1);
            this.Controls.Add(this.btnExit);
            this.Name = "frmDiceSimulator";
            this.Text = "Dice Simulator Game";
            ((System.ComponentModel.ISupportInitialize)(this.picComputer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picUser1;
        private System.Windows.Forms.PictureBox picUser2;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUserRoll;
        private System.Windows.Forms.Label lblComputersRoll;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.PictureBox picComputer1;
        private System.Windows.Forms.PictureBox picComputer2;
    }
}

