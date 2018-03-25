namespace Vending_Machine
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
            this.cashLabel = new System.Windows.Forms.Label();
            this.nickelButton = new System.Windows.Forms.Button();
            this.dimeButton = new System.Windows.Forms.Button();
            this.quarterButton = new System.Windows.Forms.Button();
            this.loonButton = new System.Windows.Forms.Button();
            this.toonButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.a4 = new System.Windows.Forms.Button();
            this.a5 = new System.Windows.Forms.Button();
            this.a6 = new System.Windows.Forms.Button();
            this.a7 = new System.Windows.Forms.Button();
            this.a8 = new System.Windows.Forms.Button();
            this.a9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cashLabel
            // 
            this.cashLabel.AutoSize = true;
            this.cashLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashLabel.Location = new System.Drawing.Point(606, 64);
            this.cashLabel.Name = "cashLabel";
            this.cashLabel.Size = new System.Drawing.Size(94, 32);
            this.cashLabel.TabIndex = 0;
            this.cashLabel.Text = "Cash:";
            this.cashLabel.Click += new System.EventHandler(this.cashLabel_Click);
            // 
            // nickelButton
            // 
            this.nickelButton.Location = new System.Drawing.Point(733, 35);
            this.nickelButton.Name = "nickelButton";
            this.nickelButton.Size = new System.Drawing.Size(75, 23);
            this.nickelButton.TabIndex = 2;
            this.nickelButton.Text = "$ 0.05";
            this.nickelButton.UseVisualStyleBackColor = true;
            this.nickelButton.Click += new System.EventHandler(this.nickelButton_Click);
            // 
            // dimeButton
            // 
            this.dimeButton.Location = new System.Drawing.Point(828, 35);
            this.dimeButton.Name = "dimeButton";
            this.dimeButton.Size = new System.Drawing.Size(75, 23);
            this.dimeButton.TabIndex = 3;
            this.dimeButton.Text = "$ 0.10";
            this.dimeButton.UseVisualStyleBackColor = true;
            this.dimeButton.Click += new System.EventHandler(this.dimeButton_Click);
            // 
            // quarterButton
            // 
            this.quarterButton.Location = new System.Drawing.Point(733, 73);
            this.quarterButton.Name = "quarterButton";
            this.quarterButton.Size = new System.Drawing.Size(75, 23);
            this.quarterButton.TabIndex = 4;
            this.quarterButton.Text = "$ 0.25";
            this.quarterButton.UseVisualStyleBackColor = true;
            this.quarterButton.Click += new System.EventHandler(this.quarterButton_Click);
            // 
            // loonButton
            // 
            this.loonButton.Location = new System.Drawing.Point(828, 73);
            this.loonButton.Name = "loonButton";
            this.loonButton.Size = new System.Drawing.Size(75, 23);
            this.loonButton.TabIndex = 5;
            this.loonButton.Text = "$ 1.00";
            this.loonButton.UseVisualStyleBackColor = true;
            this.loonButton.Click += new System.EventHandler(this.loonButton_Click);
            // 
            // toonButton
            // 
            this.toonButton.Location = new System.Drawing.Point(733, 111);
            this.toonButton.Name = "toonButton";
            this.toonButton.Size = new System.Drawing.Size(75, 23);
            this.toonButton.TabIndex = 6;
            this.toonButton.Text = "$ 2.00";
            this.toonButton.UseVisualStyleBackColor = true;
            this.toonButton.Click += new System.EventHandler(this.toonButton_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(622, 160);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(78, 28);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "Total:";
            this.totalLabel.Click += new System.EventHandler(this.totalLabel_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(720, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 37);
            this.button6.TabIndex = 8;
            this.button6.Text = "Change";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(68, 165);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 70);
            this.a1.TabIndex = 10;
            this.a1.Text = "A1";
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.a1_Click);
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(149, 165);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 70);
            this.a2.TabIndex = 11;
            this.a2.Text = "A2";
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.a2_Click);
            // 
            // a3
            // 
            this.a3.Location = new System.Drawing.Point(230, 165);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 70);
            this.a3.TabIndex = 12;
            this.a3.Text = "A3";
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.a3_Click);
            // 
            // a4
            // 
            this.a4.Location = new System.Drawing.Point(68, 241);
            this.a4.Name = "a4";
            this.a4.Size = new System.Drawing.Size(75, 70);
            this.a4.TabIndex = 13;
            this.a4.Text = "B1";
            this.a4.UseVisualStyleBackColor = true;
            this.a4.Click += new System.EventHandler(this.a4_Click);
            // 
            // a5
            // 
            this.a5.Location = new System.Drawing.Point(149, 241);
            this.a5.Name = "a5";
            this.a5.Size = new System.Drawing.Size(75, 70);
            this.a5.TabIndex = 14;
            this.a5.Text = "B2";
            this.a5.UseVisualStyleBackColor = true;
            this.a5.Click += new System.EventHandler(this.a5_Click);
            // 
            // a6
            // 
            this.a6.Location = new System.Drawing.Point(230, 241);
            this.a6.Name = "a6";
            this.a6.Size = new System.Drawing.Size(75, 70);
            this.a6.TabIndex = 15;
            this.a6.Text = "B3";
            this.a6.UseVisualStyleBackColor = true;
            this.a6.Click += new System.EventHandler(this.a6_Click);
            // 
            // a7
            // 
            this.a7.Location = new System.Drawing.Point(68, 317);
            this.a7.Name = "a7";
            this.a7.Size = new System.Drawing.Size(75, 70);
            this.a7.TabIndex = 16;
            this.a7.Text = "C1";
            this.a7.UseVisualStyleBackColor = true;
            this.a7.Click += new System.EventHandler(this.a7_Click);
            // 
            // a8
            // 
            this.a8.Location = new System.Drawing.Point(149, 317);
            this.a8.Name = "a8";
            this.a8.Size = new System.Drawing.Size(75, 70);
            this.a8.TabIndex = 17;
            this.a8.Text = "C2";
            this.a8.UseVisualStyleBackColor = true;
            this.a8.Click += new System.EventHandler(this.a8_Click);
            // 
            // a9
            // 
            this.a9.Location = new System.Drawing.Point(230, 317);
            this.a9.Name = "a9";
            this.a9.Size = new System.Drawing.Size(75, 70);
            this.a9.TabIndex = 18;
            this.a9.Text = "C3";
            this.a9.UseVisualStyleBackColor = true;
            this.a9.Click += new System.EventHandler(this.a9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(744, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 22);
            this.label3.TabIndex = 19;
            this.label3.Text = "$ 0.00";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 44);
            this.label1.TabIndex = 20;
            this.label1.Text = "1. Place your tokens to the right \n2. Choose any item below.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 415);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.a9);
            this.Controls.Add(this.a8);
            this.Controls.Add(this.a7);
            this.Controls.Add(this.a6);
            this.Controls.Add(this.a5);
            this.Controls.Add(this.a4);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.toonButton);
            this.Controls.Add(this.loonButton);
            this.Controls.Add(this.quarterButton);
            this.Controls.Add(this.dimeButton);
            this.Controls.Add(this.nickelButton);
            this.Controls.Add(this.cashLabel);
            this.Name = "Form1";
            this.Text = "Vending Machine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cashLabel;
        private System.Windows.Forms.Button nickelButton;
        private System.Windows.Forms.Button dimeButton;
        private System.Windows.Forms.Button quarterButton;
        private System.Windows.Forms.Button loonButton;
        private System.Windows.Forms.Button toonButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button a4;
        private System.Windows.Forms.Button a5;
        private System.Windows.Forms.Button a6;
        private System.Windows.Forms.Button a7;
        private System.Windows.Forms.Button a8;
        private System.Windows.Forms.Button a9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

