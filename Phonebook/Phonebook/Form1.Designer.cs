namespace Phonebook
{
    partial class phoneBookForm
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
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSelect = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameListBox
            // 
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(607, 169);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.Size = new System.Drawing.Size(120, 95);
            this.nameListBox.TabIndex = 0;
            this.nameListBox.SelectedIndexChanged += new System.EventHandler(this.nameListBox_SelectedIndexChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(299, 142);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(78, 13);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Location = new System.Drawing.Point(630, 130);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(77, 13);
            this.lblSelect.TabIndex = 2;
            this.lblSelect.Text = "Select a Name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(339, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Location = new System.Drawing.Point(302, 180);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(100, 20);
            this.phoneLabel.TabIndex = 4;
            // 
            // phoneBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblSelect);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.nameListBox);
            this.Name = "phoneBookForm";
            this.Text = "PhoneBook";
            this.Load += new System.EventHandler(this.phoneBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSelect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox phoneLabel;
    }
}

