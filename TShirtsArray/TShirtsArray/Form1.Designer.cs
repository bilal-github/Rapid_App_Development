namespace TShirtsArray
{
    partial class Form1
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
            this.btnWinning = new System.Windows.Forms.Button();
            this.txtBlack = new System.Windows.Forms.TextBox();
            this.txtWhite = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWinning
            // 
            this.btnWinning.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWinning.Location = new System.Drawing.Point(160, 66);
            this.btnWinning.Name = "btnWinning";
            this.btnWinning.Size = new System.Drawing.Size(468, 193);
            this.btnWinning.TabIndex = 0;
            this.btnWinning.Text = "Get Winning Color";
            this.btnWinning.UseVisualStyleBackColor = true;
            this.btnWinning.Click += new System.EventHandler(this.btnWinning_Click);
            // 
            // txtBlack
            // 
            this.txtBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBlack.Location = new System.Drawing.Point(216, 290);
            this.txtBlack.Name = "txtBlack";
            this.txtBlack.Size = new System.Drawing.Size(100, 34);
            this.txtBlack.TabIndex = 1;
            // 
            // txtWhite
            // 
            this.txtWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWhite.Location = new System.Drawing.Point(216, 330);
            this.txtWhite.Name = "txtWhite";
            this.txtWhite.Size = new System.Drawing.Size(100, 34);
            this.txtWhite.TabIndex = 1;
            // 
            // txtRed
            // 
            this.txtRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRed.Location = new System.Drawing.Point(216, 370);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(100, 34);
            this.txtRed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Black:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(106, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "White:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Red:";
            // 
            // txtWin
            // 
            this.txtWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWin.Location = new System.Drawing.Point(625, 316);
            this.txtWin.Name = "txtWin";
            this.txtWin.Size = new System.Drawing.Size(100, 34);
            this.txtWin.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Winning color: ";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(607, 370);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(172, 29);
            this.lblWin.TabIndex = 2;
            this.lblWin.Text = "Winning color: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRed);
            this.Controls.Add(this.txtWhite);
            this.Controls.Add(this.txtWin);
            this.Controls.Add(this.txtBlack);
            this.Controls.Add(this.btnWinning);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWinning;
        private System.Windows.Forms.TextBox txtBlack;
        private System.Windows.Forms.TextBox txtWhite;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblWin;
    }
}

