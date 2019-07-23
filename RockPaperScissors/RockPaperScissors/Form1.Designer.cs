namespace RockPaperScissors
{
    partial class frmRockPaperScisscors
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnResults = new System.Windows.Forms.Button();
            this.txtUserChoice = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.txtComputerChoice = new System.Windows.Forms.TextBox();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblResults = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(319, 97);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(74, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Click a picture";
            // 
            // btnResults
            // 
            this.btnResults.Location = new System.Drawing.Point(150, 310);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(177, 34);
            this.btnResults.TabIndex = 3;
            this.btnResults.Text = "See if you won";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // txtUserChoice
            // 
            this.txtUserChoice.Location = new System.Drawing.Point(588, 310);
            this.txtUserChoice.Name = "txtUserChoice";
            this.txtUserChoice.Size = new System.Drawing.Size(177, 20);
            this.txtUserChoice.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(147, 276);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(164, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Click the button to see if you won";
            // 
            // picPaper
            // 
            this.picPaper.Image = global::RockPaperScissors.Properties.Resources.Paper;
            this.picPaper.Location = new System.Drawing.Point(135, 161);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(113, 86);
            this.picPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPaper.TabIndex = 6;
            this.picPaper.TabStop = false;
            // 
            // picRock
            // 
            this.picRock.Image = global::RockPaperScissors.Properties.Resources.Rock;
            this.picRock.Location = new System.Drawing.Point(322, 161);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(115, 86);
            this.picRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRock.TabIndex = 7;
            this.picRock.TabStop = false;
            // 
            // picScissors
            // 
            this.picScissors.Image = global::RockPaperScissors.Properties.Resources.Scissors;
            this.picScissors.Location = new System.Drawing.Point(507, 161);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(103, 86);
            this.picScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picScissors.TabIndex = 8;
            this.picScissors.TabStop = false;
            // 
            // txtComputerChoice
            // 
            this.txtComputerChoice.Location = new System.Drawing.Point(588, 348);
            this.txtComputerChoice.Name = "txtComputerChoice";
            this.txtComputerChoice.Size = new System.Drawing.Size(177, 20);
            this.txtComputerChoice.TabIndex = 9;
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(588, 386);
            this.txtResults.Name = "txtResults";
            this.txtResults.Size = new System.Drawing.Size(177, 20);
            this.txtResults.TabIndex = 10;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(434, 310);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(64, 13);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "Your choice";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Location = new System.Drawing.Point(437, 348);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(115, 13);
            this.lblComputer.TabIndex = 12;
            this.lblComputer.Text = "The Computers Choice";
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(440, 386);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(42, 13);
            this.lblResults.TabIndex = 13;
            this.lblResults.Text = "Results";
            // 
            // frmRockPaperScisscors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.txtComputerChoice);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.txtUserChoice);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.lbl1);
            this.Name = "frmRockPaperScisscors";
            this.Text = "Rock Paper Scissors Game";
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox txtUserChoice;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.TextBox txtComputerChoice;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblResults;
    }
}

