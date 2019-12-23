namespace BilalAhmad_CPRG200_Lab2
{
    partial class CustomerBill
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radIndustrial = new System.Windows.Forms.RadioButton();
            this.radCommercial = new System.Windows.Forms.RadioButton();
            this.radResidential = new System.Windows.Forms.RadioButton();
            this.txtEnergy = new System.Windows.Forms.TextBox();
            this.lblEnergyUsed = new System.Windows.Forms.Label();
            this.lblEnergyUsedkwh = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblPeakHourskwh = new System.Windows.Forms.Label();
            this.lblPeakHours = new System.Windows.Forms.Label();
            this.txtPeakHours = new System.Windows.Forms.TextBox();
            this.lblOffPeakkwh = new System.Windows.Forms.Label();
            this.lblOffPeakHours = new System.Windows.Forms.Label();
            this.txtOffPeakHours = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAccountNo = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalNumberOfCustomers = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalIndCharges = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalComCharges = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalResCharges = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalCharges = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radIndustrial);
            this.groupBox1.Controls.Add(this.radCommercial);
            this.groupBox1.Controls.Add(this.radResidential);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Type:";
            // 
            // radIndustrial
            // 
            this.radIndustrial.AutoSize = true;
            this.radIndustrial.Cursor = System.Windows.Forms.Cursors.Default;
            this.radIndustrial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radIndustrial.Location = new System.Drawing.Point(424, 25);
            this.radIndustrial.Name = "radIndustrial";
            this.radIndustrial.Size = new System.Drawing.Size(111, 29);
            this.radIndustrial.TabIndex = 2;
            this.radIndustrial.TabStop = true;
            this.radIndustrial.Text = "Industrial";
            this.radIndustrial.UseVisualStyleBackColor = true;
            this.radIndustrial.CheckedChanged += new System.EventHandler(this.radIndustrial_CheckedChanged);
            // 
            // radCommercial
            // 
            this.radCommercial.AutoSize = true;
            this.radCommercial.Cursor = System.Windows.Forms.Cursors.Default;
            this.radCommercial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCommercial.Location = new System.Drawing.Point(233, 25);
            this.radCommercial.Name = "radCommercial";
            this.radCommercial.Size = new System.Drawing.Size(137, 29);
            this.radCommercial.TabIndex = 1;
            this.radCommercial.TabStop = true;
            this.radCommercial.Text = "Commercial";
            this.radCommercial.UseVisualStyleBackColor = true;
            this.radCommercial.CheckedChanged += new System.EventHandler(this.radCommercial_CheckedChanged);
            // 
            // radResidential
            // 
            this.radResidential.AutoSize = true;
            this.radResidential.Cursor = System.Windows.Forms.Cursors.Default;
            this.radResidential.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radResidential.Location = new System.Drawing.Point(49, 25);
            this.radResidential.Name = "radResidential";
            this.radResidential.Size = new System.Drawing.Size(128, 29);
            this.radResidential.TabIndex = 0;
            this.radResidential.TabStop = true;
            this.radResidential.Text = "Residential";
            this.radResidential.UseVisualStyleBackColor = true;
            this.radResidential.CheckedChanged += new System.EventHandler(this.radResidential_CheckedChanged);
            // 
            // txtEnergy
            // 
            this.txtEnergy.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnergy.Location = new System.Drawing.Point(249, 172);
            this.txtEnergy.Name = "txtEnergy";
            this.txtEnergy.Size = new System.Drawing.Size(175, 34);
            this.txtEnergy.TabIndex = 3;
            // 
            // lblEnergyUsed
            // 
            this.lblEnergyUsed.AutoSize = true;
            this.lblEnergyUsed.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnergyUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergyUsed.Location = new System.Drawing.Point(58, 175);
            this.lblEnergyUsed.Name = "lblEnergyUsed";
            this.lblEnergyUsed.Size = new System.Drawing.Size(158, 29);
            this.lblEnergyUsed.TabIndex = 2;
            this.lblEnergyUsed.Text = "Energy Used:";
            // 
            // lblEnergyUsedkwh
            // 
            this.lblEnergyUsedkwh.AutoSize = true;
            this.lblEnergyUsedkwh.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblEnergyUsedkwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergyUsedkwh.Location = new System.Drawing.Point(430, 177);
            this.lblEnergyUsedkwh.Name = "lblEnergyUsedkwh";
            this.lblEnergyUsedkwh.Size = new System.Drawing.Size(60, 29);
            this.lblEnergyUsedkwh.TabIndex = 3;
            this.lblEnergyUsedkwh.Text = "kWh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Charge Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(249, 343);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(175, 34);
            this.txtAmount.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalculate.Location = new System.Drawing.Point(63, 268);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(257, 60);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(72, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(177, 57);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Maroon;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.Location = new System.Drawing.Point(313, 387);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(177, 57);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblPeakHourskwh
            // 
            this.lblPeakHourskwh.AutoSize = true;
            this.lblPeakHourskwh.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPeakHourskwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakHourskwh.Location = new System.Drawing.Point(489, 177);
            this.lblPeakHourskwh.Name = "lblPeakHourskwh";
            this.lblPeakHourskwh.Size = new System.Drawing.Size(60, 29);
            this.lblPeakHourskwh.TabIndex = 11;
            this.lblPeakHourskwh.Text = "kWh";
            // 
            // lblPeakHours
            // 
            this.lblPeakHours.AutoSize = true;
            this.lblPeakHours.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPeakHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeakHours.Location = new System.Drawing.Point(14, 175);
            this.lblPeakHours.Name = "lblPeakHours";
            this.lblPeakHours.Size = new System.Drawing.Size(240, 25);
            this.lblPeakHours.TabIndex = 10;
            this.lblPeakHours.Text = "Peak Hours Energy used: ";
            // 
            // txtPeakHours
            // 
            this.txtPeakHours.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtPeakHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakHours.Location = new System.Drawing.Point(318, 172);
            this.txtPeakHours.Name = "txtPeakHours";
            this.txtPeakHours.Size = new System.Drawing.Size(165, 34);
            this.txtPeakHours.TabIndex = 3;
            // 
            // lblOffPeakkwh
            // 
            this.lblOffPeakkwh.AutoSize = true;
            this.lblOffPeakkwh.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOffPeakkwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeakkwh.Location = new System.Drawing.Point(489, 224);
            this.lblOffPeakkwh.Name = "lblOffPeakkwh";
            this.lblOffPeakkwh.Size = new System.Drawing.Size(60, 29);
            this.lblOffPeakkwh.TabIndex = 14;
            this.lblOffPeakkwh.Text = "kWh";
            // 
            // lblOffPeakHours
            // 
            this.lblOffPeakHours.AutoSize = true;
            this.lblOffPeakHours.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOffPeakHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOffPeakHours.Location = new System.Drawing.Point(14, 224);
            this.lblOffPeakHours.Name = "lblOffPeakHours";
            this.lblOffPeakHours.Size = new System.Drawing.Size(281, 25);
            this.lblOffPeakHours.TabIndex = 13;
            this.lblOffPeakHours.Text = "Off - Peak Hours energy used: ";
            // 
            // txtOffPeakHours
            // 
            this.txtOffPeakHours.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtOffPeakHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffPeakHours.Location = new System.Drawing.Point(318, 219);
            this.txtOffPeakHours.Name = "txtOffPeakHours";
            this.txtOffPeakHours.Size = new System.Drawing.Size(165, 34);
            this.txtOffPeakHours.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(195, 455);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Copyright © 2019";
            // 
            // lstCustomers
            // 
            this.lstCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomers.FormattingEnabled = true;
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(650, 49);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(527, 264);
            this.lstCustomers.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(742, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Customers List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Account No:";
            // 
            // txtAccountNo
            // 
            this.txtAccountNo.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtAccountNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountNo.Location = new System.Drawing.Point(140, 84);
            this.txtAccountNo.Name = "txtAccountNo";
            this.txtAccountNo.Size = new System.Drawing.Size(109, 34);
            this.txtAccountNo.TabIndex = 1;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(431, 84);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(165, 34);
            this.txtCustomerName.TabIndex = 2;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Customer Name:";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAddCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddCustomer.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddCustomer.Location = new System.Drawing.Point(350, 268);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(199, 60);
            this.btnAddCustomer.TabIndex = 6;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = false;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(649, 349);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Number of Customers:";
            // 
            // txtTotalNumberOfCustomers
            // 
            this.txtTotalNumberOfCustomers.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalNumberOfCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalNumberOfCustomers.Location = new System.Drawing.Point(902, 343);
            this.txtTotalNumberOfCustomers.Name = "txtTotalNumberOfCustomers";
            this.txtTotalNumberOfCustomers.ReadOnly = true;
            this.txtTotalNumberOfCustomers.Size = new System.Drawing.Size(165, 34);
            this.txtTotalNumberOfCustomers.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(677, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Industrial Customers:";
            // 
            // txtTotalIndCharges
            // 
            this.txtTotalIndCharges.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalIndCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalIndCharges.Location = new System.Drawing.Point(901, 494);
            this.txtTotalIndCharges.Name = "txtTotalIndCharges";
            this.txtTotalIndCharges.ReadOnly = true;
            this.txtTotalIndCharges.Size = new System.Drawing.Size(165, 34);
            this.txtTotalIndCharges.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Default;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(677, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(222, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Commercial Customers:";
            // 
            // txtTotalComCharges
            // 
            this.txtTotalComCharges.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalComCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalComCharges.Location = new System.Drawing.Point(901, 453);
            this.txtTotalComCharges.Name = "txtTotalComCharges";
            this.txtTotalComCharges.ReadOnly = true;
            this.txtTotalComCharges.Size = new System.Drawing.Size(165, 34);
            this.txtTotalComCharges.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(677, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Residential Customers:";
            // 
            // txtTotalResCharges
            // 
            this.txtTotalResCharges.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalResCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalResCharges.Location = new System.Drawing.Point(902, 413);
            this.txtTotalResCharges.Name = "txtTotalResCharges";
            this.txtTotalResCharges.ReadOnly = true;
            this.txtTotalResCharges.Size = new System.Drawing.Size(165, 34);
            this.txtTotalResCharges.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(649, 387);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 25);
            this.label10.TabIndex = 31;
            this.label10.Text = "Total Charges for:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Cursor = System.Windows.Forms.Cursors.Default;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(669, 573);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 25);
            this.label11.TabIndex = 32;
            this.label11.Text = "Sum of all Charges:";
            // 
            // txtTotalCharges
            // 
            this.txtTotalCharges.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtTotalCharges.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCharges.Location = new System.Drawing.Point(902, 567);
            this.txtTotalCharges.Name = "txtTotalCharges";
            this.txtTotalCharges.ReadOnly = true;
            this.txtTotalCharges.Size = new System.Drawing.Size(165, 34);
            this.txtTotalCharges.TabIndex = 33;
            // 
            // CustomerBill
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1189, 622);
            this.ControlBox = false;
            this.Controls.Add(this.txtTotalCharges);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotalResCharges);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalComCharges);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotalIndCharges);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTotalNumberOfCustomers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccountNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstCustomers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOffPeakkwh);
            this.Controls.Add(this.lblOffPeakHours);
            this.Controls.Add(this.txtOffPeakHours);
            this.Controls.Add(this.lblPeakHourskwh);
            this.Controls.Add(this.lblPeakHours);
            this.Controls.Add(this.txtPeakHours);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblEnergyUsedkwh);
            this.Controls.Add(this.lblEnergyUsed);
            this.Controls.Add(this.txtEnergy);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "CustomerBill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Bill";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerBill_FormClosing);
            this.Load += new System.EventHandler(this.CustomerBill_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radIndustrial;
        private System.Windows.Forms.RadioButton radCommercial;
        private System.Windows.Forms.RadioButton radResidential;
        private System.Windows.Forms.TextBox txtEnergy;
        private System.Windows.Forms.Label lblEnergyUsed;
        private System.Windows.Forms.Label lblEnergyUsedkwh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblPeakHourskwh;
        private System.Windows.Forms.Label lblPeakHours;
        private System.Windows.Forms.TextBox txtPeakHours;
        private System.Windows.Forms.Label lblOffPeakkwh;
        private System.Windows.Forms.Label lblOffPeakHours;
        private System.Windows.Forms.TextBox txtOffPeakHours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCustomers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAccountNo;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotalNumberOfCustomers;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalIndCharges;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalComCharges;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalResCharges;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalCharges;
    }
}

