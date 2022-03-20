namespace Program2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.peopleInput = new System.Windows.Forms.TextBox();
            this.distanceInput = new System.Windows.Forms.TextBox();
            this.deliveryInput = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.outCompA = new System.Windows.Forms.Label();
            this.outComC = new System.Windows.Forms.Label();
            this.bestCompany = new System.Windows.Forms.Label();
            this.companyB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "People :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Distance (Miles):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delivery Days:";
            // 
            // peopleInput
            // 
            this.peopleInput.Location = new System.Drawing.Point(163, 79);
            this.peopleInput.Name = "peopleInput";
            this.peopleInput.Size = new System.Drawing.Size(100, 20);
            this.peopleInput.TabIndex = 3;
            // 
            // distanceInput
            // 
            this.distanceInput.Location = new System.Drawing.Point(163, 130);
            this.distanceInput.Name = "distanceInput";
            this.distanceInput.Size = new System.Drawing.Size(100, 20);
            this.distanceInput.TabIndex = 4;
            // 
            // deliveryInput
            // 
            this.deliveryInput.Location = new System.Drawing.Point(163, 178);
            this.deliveryInput.Name = "deliveryInput";
            this.deliveryInput.Size = new System.Drawing.Size(100, 20);
            this.deliveryInput.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(117, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate Cost";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Company A Cost :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Company B Cost :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(49, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Company C Cost :";
            // 
            // outCompA
            // 
            this.outCompA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outCompA.Location = new System.Drawing.Point(175, 61);
            this.outCompA.Name = "outCompA";
            this.outCompA.Size = new System.Drawing.Size(115, 20);
            this.outCompA.TabIndex = 3;
            // 
            // outComC
            // 
            this.outComC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outComC.Location = new System.Drawing.Point(175, 157);
            this.outComC.Name = "outComC";
            this.outComC.Size = new System.Drawing.Size(115, 20);
            this.outComC.TabIndex = 5;
            // 
            // bestCompany
            // 
            this.bestCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bestCompany.Location = new System.Drawing.Point(23, 212);
            this.bestCompany.Name = "bestCompany";
            this.bestCompany.Size = new System.Drawing.Size(315, 23);
            this.bestCompany.TabIndex = 6;
            // 
            // companyB
            // 
            this.companyB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyB.Location = new System.Drawing.Point(175, 106);
            this.companyB.Name = "companyB";
            this.companyB.Size = new System.Drawing.Size(115, 20);
            this.companyB.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.companyB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bestCompany);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.outCompA);
            this.groupBox1.Controls.Add(this.outComC);
            this.groupBox1.Location = new System.Drawing.Point(343, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 249);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Food Delivery Cost Calculation";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 468);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deliveryInput);
            this.Controls.Add(this.distanceInput);
            this.Controls.Add(this.peopleInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Food Delivery Cost Calculation";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox peopleInput;
        private System.Windows.Forms.TextBox distanceInput;
        private System.Windows.Forms.TextBox deliveryInput;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label outCompA;
        private System.Windows.Forms.Label outComC;
        private System.Windows.Forms.Label bestCompany;
        private System.Windows.Forms.Label companyB;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

