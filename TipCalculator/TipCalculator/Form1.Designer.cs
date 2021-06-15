
namespace TipCalculator
{
    partial class CalculatorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTotalPerPerson = new System.Windows.Forms.Label();
            this.labelTipPerPerson = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numPeople = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numTipPercent = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTipPercent)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalPerPerson
            // 
            this.labelTotalPerPerson.AutoSize = true;
            this.labelTotalPerPerson.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalPerPerson.Location = new System.Drawing.Point(408, 143);
            this.labelTotalPerPerson.Name = "labelTotalPerPerson";
            this.labelTotalPerPerson.Size = new System.Drawing.Size(72, 37);
            this.labelTotalPerPerson.TabIndex = 29;
            this.labelTotalPerPerson.Text = "$0.0";
            // 
            // labelTipPerPerson
            // 
            this.labelTipPerPerson.AutoSize = true;
            this.labelTipPerPerson.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTipPerPerson.Location = new System.Drawing.Point(408, 57);
            this.labelTipPerPerson.Name = "labelTipPerPerson";
            this.labelTipPerPerson.Size = new System.Drawing.Size(68, 37);
            this.labelTipPerPerson.TabIndex = 28;
            this.labelTipPerPerson.Text = "$0.0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(272, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 21);
            this.label9.TabIndex = 27;
            this.label9.Text = "Per Person";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(272, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 26;
            this.label8.Text = "Per Person";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(287, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(287, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tip";
            // 
            // numPeople
            // 
            this.numPeople.Location = new System.Drawing.Point(42, 157);
            this.numPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPeople.Name = "numPeople";
            this.numPeople.Size = new System.Drawing.Size(161, 23);
            this.numPeople.TabIndex = 23;
            this.numPeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPeople.ValueChanged += new System.EventHandler(this.numPeople_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 21);
            this.label3.TabIndex = 22;
            this.label3.Text = "Number of People";
            // 
            // numTipPercent
            // 
            this.numTipPercent.Location = new System.Drawing.Point(42, 107);
            this.numTipPercent.Name = "numTipPercent";
            this.numTipPercent.Size = new System.Drawing.Size(161, 23);
            this.numTipPercent.TabIndex = 21;
            this.numTipPercent.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numTipPercent.ValueChanged += new System.EventHandler(this.numTipPercent_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(42, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tip %";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(42, 57);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(161, 23);
            this.txtAmount.TabIndex = 19;
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Bill";
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 234);
            this.Controls.Add(this.labelTotalPerPerson);
            this.Controls.Add(this.labelTipPerPerson);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPeople);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTipPercent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorForm";
            this.Text = "TipCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.numPeople)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTipPercent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalPerPerson;
        private System.Windows.Forms.Label labelTipPerPerson;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numPeople;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTipPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
    }
}

