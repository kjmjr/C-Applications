namespace passwordValidator
{
    partial class passwordValidationForm
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.lblRequirments = new System.Windows.Forms.Label();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblTwo = new System.Windows.Forms.Label();
            this.lblThree = new System.Windows.Forms.Label();
            this.lblFour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(144, 330);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 50);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "Check Password";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(276, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 50);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(144, 276);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(207, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Location = new System.Drawing.Point(197, 230);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(89, 13);
            this.lblEnter.TabIndex = 3;
            this.lblEnter.Text = "Enter a password";
            // 
            // lblRequirments
            // 
            this.lblRequirments.AutoSize = true;
            this.lblRequirments.Location = new System.Drawing.Point(144, 24);
            this.lblRequirments.Name = "lblRequirments";
            this.lblRequirments.Size = new System.Drawing.Size(225, 13);
            this.lblRequirments.TabIndex = 4;
            this.lblRequirments.Text = "A valid password must enter these requirments";
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(144, 64);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(187, 13);
            this.lblOne.TabIndex = 5;
            this.lblOne.Text = "1. It must be at least 8 characters long";
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Location = new System.Drawing.Point(144, 94);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(225, 13);
            this.lblTwo.TabIndex = 6;
            this.lblTwo.Text = "2. It must contain at least one uppercase letter";
            // 
            // lblThree
            // 
            this.lblThree.AutoSize = true;
            this.lblThree.Location = new System.Drawing.Point(147, 131);
            this.lblThree.Name = "lblThree";
            this.lblThree.Size = new System.Drawing.Size(226, 13);
            this.lblThree.TabIndex = 7;
            this.lblThree.Text = "3. It must contain at lease one lowercase letter";
            // 
            // lblFour
            // 
            this.lblFour.AutoSize = true;
            this.lblFour.Location = new System.Drawing.Point(150, 166);
            this.lblFour.Name = "lblFour";
            this.lblFour.Size = new System.Drawing.Size(208, 13);
            this.lblFour.TabIndex = 8;
            this.lblFour.Text = "4. It must contain at least one numeric digit";
            // 
            // passwordValidationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.lblFour);
            this.Controls.Add(this.lblThree);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.lblRequirments);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Name = "passwordValidationForm";
            this.Text = "Password Validation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Label lblRequirments;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.Label lblThree;
        private System.Windows.Forms.Label lblFour;
    }
}

