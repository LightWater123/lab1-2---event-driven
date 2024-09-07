﻿namespace CalculatorApplication
{
    partial class FrmCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxInput1 = new System.Windows.Forms.TextBox();
            this.txtBoxInput2 = new System.Windows.Forms.TextBox();
            this.lblDisplayTotal = new System.Windows.Forms.Label();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.btnEqual = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Second Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Answer:";
            // 
            // txtBoxInput1
            // 
            this.txtBoxInput1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput1.Location = new System.Drawing.Point(186, 53);
            this.txtBoxInput1.Name = "txtBoxInput1";
            this.txtBoxInput1.Size = new System.Drawing.Size(133, 26);
            this.txtBoxInput1.TabIndex = 3;
            // 
            // txtBoxInput2
            // 
            this.txtBoxInput2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInput2.Location = new System.Drawing.Point(186, 114);
            this.txtBoxInput2.Name = "txtBoxInput2";
            this.txtBoxInput2.Size = new System.Drawing.Size(133, 26);
            this.txtBoxInput2.TabIndex = 4;
            // 
            // lblDisplayTotal
            // 
            this.lblDisplayTotal.AutoSize = true;
            this.lblDisplayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayTotal.Location = new System.Drawing.Point(183, 157);
            this.lblDisplayTotal.Name = "lblDisplayTotal";
            this.lblDisplayTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDisplayTotal.Size = new System.Drawing.Size(0, 20);
            this.lblDisplayTotal.TabIndex = 5;
            // 
            // cbOperator
            // 
            this.cbOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(217, 87);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(70, 21);
            this.cbOperator.TabIndex = 6;
            // 
            // btnEqual
            // 
            this.btnEqual.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEqual.Location = new System.Drawing.Point(187, 191);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(118, 33);
            this.btnEqual.TabIndex = 7;
            this.btnEqual.Text = "Calculate";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "______________________";
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 291);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.lblDisplayTotal);
            this.Controls.Add(this.txtBoxInput2);
            this.Controls.Add(this.txtBoxInput1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCalculator";
            this.Load += new System.EventHandler(this.FrmCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxInput1;
        private System.Windows.Forms.TextBox txtBoxInput2;
        private System.Windows.Forms.Label lblDisplayTotal;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Label label4;
    }
}

