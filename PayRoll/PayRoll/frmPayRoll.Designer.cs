namespace PayRoll
{
    partial class frmPayRoll
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHourlyRate = new System.Windows.Forms.TextBox();
            this.lblRegularPay = new System.Windows.Forms.Label();
            this.lblOvertimePay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegularPay = new System.Windows.Forms.TextBox();
            this.txtOvertimePay = new System.Windows.Forms.TextBox();
            this.txtTotalPayAmount = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of Hours Worked: ";
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoursWorked.Location = new System.Drawing.Point(370, 64);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(215, 30);
            this.txtHoursWorked.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hourly Rate:";
            // 
            // txtHourlyRate
            // 
            this.txtHourlyRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHourlyRate.Location = new System.Drawing.Point(370, 124);
            this.txtHourlyRate.Name = "txtHourlyRate";
            this.txtHourlyRate.Size = new System.Drawing.Size(215, 30);
            this.txtHourlyRate.TabIndex = 3;
            // 
            // lblRegularPay
            // 
            this.lblRegularPay.AutoSize = true;
            this.lblRegularPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegularPay.Location = new System.Drawing.Point(98, 252);
            this.lblRegularPay.Name = "lblRegularPay";
            this.lblRegularPay.Size = new System.Drawing.Size(129, 25);
            this.lblRegularPay.TabIndex = 4;
            this.lblRegularPay.Text = "Regular Pay: ";
            // 
            // lblOvertimePay
            // 
            this.lblOvertimePay.AutoSize = true;
            this.lblOvertimePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvertimePay.Location = new System.Drawing.Point(98, 307);
            this.lblOvertimePay.Name = "lblOvertimePay";
            this.lblOvertimePay.Size = new System.Drawing.Size(136, 25);
            this.lblOvertimePay.TabIndex = 5;
            this.lblOvertimePay.Text = "Overtime Pay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total Pay Amount";
            // 
            // txtRegularPay
            // 
            this.txtRegularPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegularPay.Location = new System.Drawing.Point(370, 247);
            this.txtRegularPay.Name = "txtRegularPay";
            this.txtRegularPay.ReadOnly = true;
            this.txtRegularPay.Size = new System.Drawing.Size(215, 30);
            this.txtRegularPay.TabIndex = 7;
            // 
            // txtOvertimePay
            // 
            this.txtOvertimePay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOvertimePay.Location = new System.Drawing.Point(370, 304);
            this.txtOvertimePay.Name = "txtOvertimePay";
            this.txtOvertimePay.ReadOnly = true;
            this.txtOvertimePay.Size = new System.Drawing.Size(215, 30);
            this.txtOvertimePay.TabIndex = 8;
            // 
            // txtTotalPayAmount
            // 
            this.txtTotalPayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPayAmount.Location = new System.Drawing.Point(370, 361);
            this.txtTotalPayAmount.Name = "txtTotalPayAmount";
            this.txtTotalPayAmount.ReadOnly = true;
            this.txtTotalPayAmount.Size = new System.Drawing.Size(215, 30);
            this.txtTotalPayAmount.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(234, 171);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(239, 53);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmPayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotalPayAmount);
            this.Controls.Add(this.txtOvertimePay);
            this.Controls.Add(this.txtRegularPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblOvertimePay);
            this.Controls.Add(this.lblRegularPay);
            this.Controls.Add(this.txtHourlyRate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoursWorked);
            this.Controls.Add(this.label1);
            this.Name = "frmPayRoll";
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHourlyRate;
        private System.Windows.Forms.Label lblRegularPay;
        private System.Windows.Forms.Label lblOvertimePay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRegularPay;
        private System.Windows.Forms.TextBox txtOvertimePay;
        private System.Windows.Forms.TextBox txtTotalPayAmount;
        private System.Windows.Forms.Button btnCalculate;
    }
}

