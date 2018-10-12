namespace Cash_Register
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
            this.numberPlatesInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numberFriesInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberDrinksInput = new System.Windows.Forms.TextBox();
            this.calculateTotalsButton = new System.Windows.Forms.Button();
            this.totalCostOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.printReciptButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberPlatesInput
            // 
            this.numberPlatesInput.Location = new System.Drawing.Point(127, 42);
            this.numberPlatesInput.Name = "numberPlatesInput";
            this.numberPlatesInput.Size = new System.Drawing.Size(45, 20);
            this.numberPlatesInput.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Plates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Desserts";
            // 
            // numberFriesInput
            // 
            this.numberFriesInput.Location = new System.Drawing.Point(127, 75);
            this.numberFriesInput.Name = "numberFriesInput";
            this.numberFriesInput.Size = new System.Drawing.Size(45, 20);
            this.numberFriesInput.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Number of Drinks";
            // 
            // numberDrinksInput
            // 
            this.numberDrinksInput.Location = new System.Drawing.Point(127, 109);
            this.numberDrinksInput.Name = "numberDrinksInput";
            this.numberDrinksInput.Size = new System.Drawing.Size(45, 20);
            this.numberDrinksInput.TabIndex = 6;
            // 
            // calculateTotalsButton
            // 
            this.calculateTotalsButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.calculateTotalsButton.Location = new System.Drawing.Point(25, 135);
            this.calculateTotalsButton.Name = "calculateTotalsButton";
            this.calculateTotalsButton.Size = new System.Drawing.Size(137, 23);
            this.calculateTotalsButton.TabIndex = 7;
            this.calculateTotalsButton.Text = "Calculate Totals";
            this.calculateTotalsButton.UseVisualStyleBackColor = true;
            this.calculateTotalsButton.Click += new System.EventHandler(this.calculateTotalsButton_Click);
            // 
            // totalCostOutput
            // 
            this.totalCostOutput.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostOutput.Location = new System.Drawing.Point(99, 173);
            this.totalCostOutput.Name = "totalCostOutput";
            this.totalCostOutput.Size = new System.Drawing.Size(73, 114);
            this.totalCostOutput.TabIndex = 8;
            this.totalCostOutput.Click += new System.EventHandler(this.totalCostOutput_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(99, 270);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(73, 20);
            this.tenderedInput.TabIndex = 10;
            // 
            // changeButton
            // 
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.changeButton.Location = new System.Drawing.Point(25, 297);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(137, 23);
            this.changeButton.TabIndex = 11;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            // 
            // printReciptButton
            // 
            this.printReciptButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.printReciptButton.Location = new System.Drawing.Point(25, 326);
            this.printReciptButton.Name = "printReciptButton";
            this.printReciptButton.Size = new System.Drawing.Size(137, 23);
            this.printReciptButton.TabIndex = 12;
            this.printReciptButton.Text = "Print Recipt";
            this.printReciptButton.UseVisualStyleBackColor = true;
            this.printReciptButton.Click += new System.EventHandler(this.printReciptButton_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(241, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "New Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 84);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sub Total\r\n\r\nTax\r\n\r\nTotal\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(435, 373);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.printReciptButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.totalCostOutput);
            this.Controls.Add(this.calculateTotalsButton);
            this.Controls.Add(this.numberDrinksInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numberFriesInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberPlatesInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox numberPlatesInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox numberFriesInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberDrinksInput;
        private System.Windows.Forms.Button calculateTotalsButton;
        public System.Windows.Forms.Label totalCostOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button printReciptButton;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label5;
    }
}

