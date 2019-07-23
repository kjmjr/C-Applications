namespace cardIdentifier
{
    partial class cardID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cardID));
            this.btnExit = new System.Windows.Forms.Button();
            this.clickCardLabel = new System.Windows.Forms.Label();
            this.diamondsPictureBox = new System.Windows.Forms.PictureBox();
            this.heartsPictureBox = new System.Windows.Forms.PictureBox();
            this.spadesPictureBox = new System.Windows.Forms.PictureBox();
            this.jokerPictureBox = new System.Windows.Forms.PictureBox();
            this.valueMessage = new System.Windows.Forms.Label();
            this.clubsPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.diamondsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(253, 400);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(189, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // clickCardLabel
            // 
            this.clickCardLabel.AutoSize = true;
            this.clickCardLabel.Location = new System.Drawing.Point(265, 40);
            this.clickCardLabel.Name = "clickCardLabel";
            this.clickCardLabel.Size = new System.Drawing.Size(142, 13);
            this.clickCardLabel.TabIndex = 1;
            this.clickCardLabel.Text = "Click a Card to See its Name";
            this.clickCardLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // diamondsPictureBox
            // 
            this.diamondsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("diamondsPictureBox.Image")));
            this.diamondsPictureBox.Location = new System.Drawing.Point(142, 80);
            this.diamondsPictureBox.Name = "diamondsPictureBox";
            this.diamondsPictureBox.Size = new System.Drawing.Size(100, 132);
            this.diamondsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.diamondsPictureBox.TabIndex = 3;
            this.diamondsPictureBox.TabStop = false;
            this.diamondsPictureBox.Click += new System.EventHandler(this.diamondsPictureBox_Click);
            // 
            // heartsPictureBox
            // 
            this.heartsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("heartsPictureBox.Image")));
            this.heartsPictureBox.Location = new System.Drawing.Point(295, 80);
            this.heartsPictureBox.Name = "heartsPictureBox";
            this.heartsPictureBox.Size = new System.Drawing.Size(100, 132);
            this.heartsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heartsPictureBox.TabIndex = 4;
            this.heartsPictureBox.TabStop = false;
            this.heartsPictureBox.Click += new System.EventHandler(this.heartsPictureBox_Click);
            // 
            // spadesPictureBox
            // 
            this.spadesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("spadesPictureBox.Image")));
            this.spadesPictureBox.Location = new System.Drawing.Point(445, 80);
            this.spadesPictureBox.Name = "spadesPictureBox";
            this.spadesPictureBox.Size = new System.Drawing.Size(100, 132);
            this.spadesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spadesPictureBox.TabIndex = 5;
            this.spadesPictureBox.TabStop = false;
            this.spadesPictureBox.Click += new System.EventHandler(this.spadesPictureBox_Click);
            // 
            // jokerPictureBox
            // 
            this.jokerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("jokerPictureBox.Image")));
            this.jokerPictureBox.Location = new System.Drawing.Point(373, 209);
            this.jokerPictureBox.Name = "jokerPictureBox";
            this.jokerPictureBox.Size = new System.Drawing.Size(100, 132);
            this.jokerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.jokerPictureBox.TabIndex = 6;
            this.jokerPictureBox.TabStop = false;
            this.jokerPictureBox.Click += new System.EventHandler(this.jokerPictureBox_Click);
            // 
            // valueMessage
            // 
            this.valueMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueMessage.Location = new System.Drawing.Point(173, 353);
            this.valueMessage.Name = "valueMessage";
            this.valueMessage.Size = new System.Drawing.Size(335, 33);
            this.valueMessage.TabIndex = 7;
            this.valueMessage.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // clubsPictureBox
            // 
            this.clubsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("clubsPictureBox.Image")));
            this.clubsPictureBox.Location = new System.Drawing.Point(189, 209);
            this.clubsPictureBox.Name = "clubsPictureBox";
            this.clubsPictureBox.Size = new System.Drawing.Size(100, 132);
            this.clubsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clubsPictureBox.TabIndex = 8;
            this.clubsPictureBox.TabStop = false;
            this.clubsPictureBox.Click += new System.EventHandler(this.clubsPictureBox_Click_1);
            // 
            // cardID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.clubsPictureBox);
            this.Controls.Add(this.valueMessage);
            this.Controls.Add(this.jokerPictureBox);
            this.Controls.Add(this.spadesPictureBox);
            this.Controls.Add(this.heartsPictureBox);
            this.Controls.Add(this.diamondsPictureBox);
            this.Controls.Add(this.clickCardLabel);
            this.Controls.Add(this.btnExit);
            this.Name = "cardID";
            this.Text = "Card Identifier application";
            ((System.ComponentModel.ISupportInitialize)(this.diamondsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heartsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spadesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jokerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clubsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label clickCardLabel;
        private System.Windows.Forms.PictureBox diamondsPictureBox;
        private System.Windows.Forms.PictureBox heartsPictureBox;
        private System.Windows.Forms.PictureBox spadesPictureBox;
        private System.Windows.Forms.PictureBox jokerPictureBox;
        private System.Windows.Forms.Label valueMessage;
        private System.Windows.Forms.PictureBox clubsPictureBox;
    }
}

