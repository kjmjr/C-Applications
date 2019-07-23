namespace CarClass
{
    partial class carProgramForm
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
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSpeedBox = new System.Windows.Forms.TextBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.txtNewSpeed = new System.Windows.Forms.TextBox();
            this.lblNewSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(442, 12);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(75, 63);
            this.btnAccelerate.TabIndex = 0;
            this.btnAccelerate.Text = "Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(442, 91);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(75, 60);
            this.btnBrake.TabIndex = 1;
            this.btnBrake.Text = "Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(442, 169);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 68);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View Your Car Information";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(442, 252);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 57);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSpeedBox
            // 
            this.txtSpeedBox.Location = new System.Drawing.Point(67, 243);
            this.txtSpeedBox.Name = "txtSpeedBox";
            this.txtSpeedBox.Size = new System.Drawing.Size(272, 20);
            this.txtSpeedBox.TabIndex = 4;
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Location = new System.Drawing.Point(64, 209);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(269, 13);
            this.lblInstructions.TabIndex = 5;
            this.lblInstructions.Text = "Type any number and then click any button to proceed:";
            // 
            // txtNewSpeed
            // 
            this.txtNewSpeed.Location = new System.Drawing.Point(67, 317);
            this.txtNewSpeed.Name = "txtNewSpeed";
            this.txtNewSpeed.Size = new System.Drawing.Size(272, 20);
            this.txtNewSpeed.TabIndex = 6;
            // 
            // lblNewSpeed
            // 
            this.lblNewSpeed.AutoSize = true;
            this.lblNewSpeed.Location = new System.Drawing.Point(64, 286);
            this.lblNewSpeed.Name = "lblNewSpeed";
            this.lblNewSpeed.Size = new System.Drawing.Size(66, 13);
            this.lblNewSpeed.TabIndex = 7;
            this.lblNewSpeed.Text = "New Speed:";
            // 
            // carProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 386);
            this.Controls.Add(this.lblNewSpeed);
            this.Controls.Add(this.txtNewSpeed);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.txtSpeedBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnAccelerate);
            this.Name = "carProgramForm";
            this.Text = "Car Program";
            this.Load += new System.EventHandler(this.carProgramForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtSpeedBox;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.TextBox txtNewSpeed;
        private System.Windows.Forms.Label lblNewSpeed;
    }
}

