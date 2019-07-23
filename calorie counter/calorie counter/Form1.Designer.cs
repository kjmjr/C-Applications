namespace calorie_counter
{
    partial class calorieCounter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calorieCounter));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.banannaPicture = new System.Windows.Forms.PictureBox();
            this.applePicture = new System.Windows.Forms.PictureBox();
            this.orangePicture = new System.Windows.Forms.PictureBox();
            this.pearPicture = new System.Windows.Forms.PictureBox();
            this.lblTotalCalories = new System.Windows.Forms.Label();
            this.lblShowBox = new System.Windows.Forms.Label();
            this.txtTotalBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.banannaPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(440, 376);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(440, 337);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // banannaPicture
            // 
            this.banannaPicture.Image = ((System.Drawing.Image)(resources.GetObject("banannaPicture.Image")));
            this.banannaPicture.Location = new System.Drawing.Point(68, 77);
            this.banannaPicture.Name = "banannaPicture";
            this.banannaPicture.Size = new System.Drawing.Size(128, 155);
            this.banannaPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.banannaPicture.TabIndex = 2;
            this.banannaPicture.TabStop = false;
            this.banannaPicture.Click += new System.EventHandler(this.banannaPicture_Click);
            // 
            // applePicture
            // 
            this.applePicture.Image = ((System.Drawing.Image)(resources.GetObject("applePicture.Image")));
            this.applePicture.Location = new System.Drawing.Point(253, 77);
            this.applePicture.Name = "applePicture";
            this.applePicture.Size = new System.Drawing.Size(128, 155);
            this.applePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.applePicture.TabIndex = 3;
            this.applePicture.TabStop = false;
            this.applePicture.Click += new System.EventHandler(this.applePicture_Click);
            // 
            // orangePicture
            // 
            this.orangePicture.Image = ((System.Drawing.Image)(resources.GetObject("orangePicture.Image")));
            this.orangePicture.Location = new System.Drawing.Point(68, 244);
            this.orangePicture.Name = "orangePicture";
            this.orangePicture.Size = new System.Drawing.Size(128, 155);
            this.orangePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.orangePicture.TabIndex = 4;
            this.orangePicture.TabStop = false;
            this.orangePicture.Click += new System.EventHandler(this.orangePicture_Click);
            // 
            // pearPicture
            // 
            this.pearPicture.Image = ((System.Drawing.Image)(resources.GetObject("pearPicture.Image")));
            this.pearPicture.Location = new System.Drawing.Point(253, 244);
            this.pearPicture.Name = "pearPicture";
            this.pearPicture.Size = new System.Drawing.Size(128, 155);
            this.pearPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pearPicture.TabIndex = 5;
            this.pearPicture.TabStop = false;
            this.pearPicture.Click += new System.EventHandler(this.pearPicture_Click);
            // 
            // lblTotalCalories
            // 
            this.lblTotalCalories.AutoSize = true;
            this.lblTotalCalories.Location = new System.Drawing.Point(444, 95);
            this.lblTotalCalories.Name = "lblTotalCalories";
            this.lblTotalCalories.Size = new System.Drawing.Size(71, 13);
            this.lblTotalCalories.TabIndex = 6;
            this.lblTotalCalories.Text = "Total Calories";
            // 
            // lblShowBox
            // 
            this.lblShowBox.AutoSize = true;
            this.lblShowBox.Location = new System.Drawing.Point(457, 132);
            this.lblShowBox.Name = "lblShowBox";
            this.lblShowBox.Size = new System.Drawing.Size(0, 13);
            this.lblShowBox.TabIndex = 7;
            // 
            // txtTotalBox
            // 
            this.txtTotalBox.Location = new System.Drawing.Point(423, 136);
            this.txtTotalBox.Name = "txtTotalBox";
            this.txtTotalBox.ReadOnly = true;
            this.txtTotalBox.Size = new System.Drawing.Size(127, 20);
            this.txtTotalBox.TabIndex = 8;
            // 
            // calorieCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.txtTotalBox);
            this.Controls.Add(this.lblShowBox);
            this.Controls.Add(this.lblTotalCalories);
            this.Controls.Add(this.pearPicture);
            this.Controls.Add(this.orangePicture);
            this.Controls.Add(this.applePicture);
            this.Controls.Add(this.banannaPicture);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Name = "calorieCounter";
            this.Text = "Calorie Counter";
            ((System.ComponentModel.ISupportInitialize)(this.banannaPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orangePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pearPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox banannaPicture;
        private System.Windows.Forms.PictureBox applePicture;
        private System.Windows.Forms.PictureBox orangePicture;
        private System.Windows.Forms.PictureBox pearPicture;
        private System.Windows.Forms.Label lblTotalCalories;
        private System.Windows.Forms.Label lblShowBox;
        private System.Windows.Forms.TextBox txtTotalBox;
    }
}

