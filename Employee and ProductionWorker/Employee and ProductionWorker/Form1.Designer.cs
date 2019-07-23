namespace Employee_and_ProductionWorker
{
    partial class EmployeeAndProductionWorker
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
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.radShiftSupervisor = new System.Windows.Forms.RadioButton();
            this.radProductionWorker = new System.Windows.Forms.RadioButton();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblShiftNumber = new System.Windows.Forms.Label();
            this.lblHourlyPayRate = new System.Windows.Forms.Label();
            this.lblAnnualSalary = new System.Windows.Forms.Label();
            this.lblAnnualProductionBonus = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtShiftNumber = new System.Windows.Forms.TextBox();
            this.txtHourlyPayRate = new System.Windows.Forms.TextBox();
            this.txtAnnualSalary = new System.Windows.Forms.TextBox();
            this.txtAnnualProductionBonus = new System.Windows.Forms.TextBox();
            this.lblProductionWorkerInfo = new System.Windows.Forms.Label();
            this.lblShiftSupervisorInfo = new System.Windows.Forms.Label();
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.grpEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.radShiftSupervisor);
            this.grpEmployee.Controls.Add(this.radProductionWorker);
            this.grpEmployee.Location = new System.Drawing.Point(275, 23);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(200, 100);
            this.grpEmployee.TabIndex = 0;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Employee";
            // 
            // radShiftSupervisor
            // 
            this.radShiftSupervisor.AutoSize = true;
            this.radShiftSupervisor.Location = new System.Drawing.Point(16, 68);
            this.radShiftSupervisor.Name = "radShiftSupervisor";
            this.radShiftSupervisor.Size = new System.Drawing.Size(99, 17);
            this.radShiftSupervisor.TabIndex = 1;
            this.radShiftSupervisor.TabStop = true;
            this.radShiftSupervisor.Text = "Shift Supervisor";
            this.radShiftSupervisor.UseVisualStyleBackColor = true;
            this.radShiftSupervisor.CheckedChanged += new System.EventHandler(this.radShiftSupervisor_CheckedChanged);
            // 
            // radProductionWorker
            // 
            this.radProductionWorker.AutoSize = true;
            this.radProductionWorker.Checked = true;
            this.radProductionWorker.Location = new System.Drawing.Point(16, 31);
            this.radProductionWorker.Name = "radProductionWorker";
            this.radProductionWorker.Size = new System.Drawing.Size(114, 17);
            this.radProductionWorker.TabIndex = 0;
            this.radProductionWorker.TabStop = true;
            this.radProductionWorker.Text = "Production Worker";
            this.radProductionWorker.UseVisualStyleBackColor = true;
            this.radProductionWorker.CheckedChanged += new System.EventHandler(this.radProductionWorker_CheckedChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(70, 179);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(87, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Employee Name:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(395, 182);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(96, 13);
            this.lblNumber.TabIndex = 2;
            this.lblNumber.Text = "Employee Number:";
            // 
            // lblShiftNumber
            // 
            this.lblShiftNumber.AutoSize = true;
            this.lblShiftNumber.Location = new System.Drawing.Point(170, 285);
            this.lblShiftNumber.Name = "lblShiftNumber";
            this.lblShiftNumber.Size = new System.Drawing.Size(71, 13);
            this.lblShiftNumber.TabIndex = 3;
            this.lblShiftNumber.Text = "Shift Number:";
            // 
            // lblHourlyPayRate
            // 
            this.lblHourlyPayRate.AutoSize = true;
            this.lblHourlyPayRate.Location = new System.Drawing.Point(170, 358);
            this.lblHourlyPayRate.Name = "lblHourlyPayRate";
            this.lblHourlyPayRate.Size = new System.Drawing.Size(87, 13);
            this.lblHourlyPayRate.TabIndex = 4;
            this.lblHourlyPayRate.Text = "Hourly Pay Rate:";
            // 
            // lblAnnualSalary
            // 
            this.lblAnnualSalary.AutoSize = true;
            this.lblAnnualSalary.Location = new System.Drawing.Point(416, 285);
            this.lblAnnualSalary.Name = "lblAnnualSalary";
            this.lblAnnualSalary.Size = new System.Drawing.Size(75, 13);
            this.lblAnnualSalary.TabIndex = 5;
            this.lblAnnualSalary.Text = "Annual Salary:";
            // 
            // lblAnnualProductionBonus
            // 
            this.lblAnnualProductionBonus.AutoSize = true;
            this.lblAnnualProductionBonus.Location = new System.Drawing.Point(412, 358);
            this.lblAnnualProductionBonus.Name = "lblAnnualProductionBonus";
            this.lblAnnualProductionBonus.Size = new System.Drawing.Size(167, 13);
            this.lblAnnualProductionBonus.TabIndex = 6;
            this.lblAnnualProductionBonus.Text = "Annual Production Bonus Earned:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(173, 176);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(507, 179);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 8;
            // 
            // txtShiftNumber
            // 
            this.txtShiftNumber.Location = new System.Drawing.Point(173, 315);
            this.txtShiftNumber.Name = "txtShiftNumber";
            this.txtShiftNumber.Size = new System.Drawing.Size(100, 20);
            this.txtShiftNumber.TabIndex = 9;
            // 
            // txtHourlyPayRate
            // 
            this.txtHourlyPayRate.Location = new System.Drawing.Point(173, 389);
            this.txtHourlyPayRate.Name = "txtHourlyPayRate";
            this.txtHourlyPayRate.Size = new System.Drawing.Size(100, 20);
            this.txtHourlyPayRate.TabIndex = 10;
            // 
            // txtAnnualSalary
            // 
            this.txtAnnualSalary.Location = new System.Drawing.Point(415, 315);
            this.txtAnnualSalary.Name = "txtAnnualSalary";
            this.txtAnnualSalary.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualSalary.TabIndex = 11;
            // 
            // txtAnnualProductionBonus
            // 
            this.txtAnnualProductionBonus.Location = new System.Drawing.Point(415, 389);
            this.txtAnnualProductionBonus.Name = "txtAnnualProductionBonus";
            this.txtAnnualProductionBonus.Size = new System.Drawing.Size(100, 20);
            this.txtAnnualProductionBonus.TabIndex = 12;
            // 
            // lblProductionWorkerInfo
            // 
            this.lblProductionWorkerInfo.AutoSize = true;
            this.lblProductionWorkerInfo.Location = new System.Drawing.Point(143, 252);
            this.lblProductionWorkerInfo.Name = "lblProductionWorkerInfo";
            this.lblProductionWorkerInfo.Size = new System.Drawing.Size(151, 13);
            this.lblProductionWorkerInfo.TabIndex = 13;
            this.lblProductionWorkerInfo.Text = "Production Worker Information";
            // 
            // lblShiftSupervisorInfo
            // 
            this.lblShiftSupervisorInfo.AutoSize = true;
            this.lblShiftSupervisorInfo.Location = new System.Drawing.Point(395, 252);
            this.lblShiftSupervisorInfo.Name = "lblShiftSupervisorInfo";
            this.lblShiftSupervisorInfo.Size = new System.Drawing.Size(136, 13);
            this.lblShiftSupervisorInfo.TabIndex = 14;
            this.lblShiftSupervisorInfo.Text = "Shift Supervisor Information";
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(291, 453);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(164, 53);
            this.btnCreateObject.TabIndex = 15;
            this.btnCreateObject.Text = "Create Object";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // EmployeeAndProductionWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 527);
            this.Controls.Add(this.btnCreateObject);
            this.Controls.Add(this.lblShiftSupervisorInfo);
            this.Controls.Add(this.lblProductionWorkerInfo);
            this.Controls.Add(this.txtAnnualProductionBonus);
            this.Controls.Add(this.txtAnnualSalary);
            this.Controls.Add(this.txtHourlyPayRate);
            this.Controls.Add(this.txtShiftNumber);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAnnualProductionBonus);
            this.Controls.Add(this.lblAnnualSalary);
            this.Controls.Add(this.lblHourlyPayRate);
            this.Controls.Add(this.lblShiftNumber);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.grpEmployee);
            this.Name = "EmployeeAndProductionWorker";
            this.Text = "Employee and ProductionWorker ";
            this.grpEmployee.ResumeLayout(false);
            this.grpEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.RadioButton radShiftSupervisor;
        private System.Windows.Forms.RadioButton radProductionWorker;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblShiftNumber;
        private System.Windows.Forms.Label lblHourlyPayRate;
        private System.Windows.Forms.Label lblAnnualSalary;
        private System.Windows.Forms.Label lblAnnualProductionBonus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtShiftNumber;
        private System.Windows.Forms.TextBox txtHourlyPayRate;
        private System.Windows.Forms.TextBox txtAnnualSalary;
        private System.Windows.Forms.TextBox txtAnnualProductionBonus;
        private System.Windows.Forms.Label lblProductionWorkerInfo;
        private System.Windows.Forms.Label lblShiftSupervisorInfo;
        private System.Windows.Forms.Button btnCreateObject;
    }
}

