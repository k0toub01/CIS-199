namespace Program3
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
            this.farmLbl = new System.Windows.Forms.Label();
            this.itemLbl = new System.Windows.Forms.Label();
            this.lbsLbl = new System.Windows.Forms.Label();
            this.intCostLbl = new System.Windows.Forms.Label();
            this.shipCostLbl = new System.Windows.Forms.Label();
            this.totalCosrLbl = new System.Windows.Forms.Label();
            this.disCostLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.farmList = new System.Windows.Forms.ComboBox();
            this.itemNumbertxt = new System.Windows.Forms.TextBox();
            this.quantityItemTxt = new System.Windows.Forms.TextBox();
            this.intCostTxt = new System.Windows.Forms.Label();
            this.disCostTxt = new System.Windows.Forms.Label();
            this.shipCostTxt = new System.Windows.Forms.Label();
            this.totalCostTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // farmLbl
            // 
            this.farmLbl.AutoSize = true;
            this.farmLbl.Location = new System.Drawing.Point(92, 55);
            this.farmLbl.Name = "farmLbl";
            this.farmLbl.Size = new System.Drawing.Size(33, 13);
            this.farmLbl.TabIndex = 0;
            this.farmLbl.Text = "Farm:";
            // 
            // itemLbl
            // 
            this.itemLbl.AutoSize = true;
            this.itemLbl.Location = new System.Drawing.Point(95, 84);
            this.itemLbl.Name = "itemLbl";
            this.itemLbl.Size = new System.Drawing.Size(30, 13);
            this.itemLbl.TabIndex = 1;
            this.itemLbl.Text = "Item:";
            // 
            // lbsLbl
            // 
            this.lbsLbl.AutoSize = true;
            this.lbsLbl.Location = new System.Drawing.Point(53, 119);
            this.lbsLbl.Name = "lbsLbl";
            this.lbsLbl.Size = new System.Drawing.Size(72, 13);
            this.lbsLbl.TabIndex = 2;
            this.lbsLbl.Text = "Quantity (Ibs):";
            // 
            // intCostLbl
            // 
            this.intCostLbl.AutoSize = true;
            this.intCostLbl.Location = new System.Drawing.Point(64, 209);
            this.intCostLbl.Name = "intCostLbl";
            this.intCostLbl.Size = new System.Drawing.Size(61, 13);
            this.intCostLbl.TabIndex = 3;
            this.intCostLbl.Text = "Initital Cost:";
            // 
            // shipCostLbl
            // 
            this.shipCostLbl.AutoSize = true;
            this.shipCostLbl.Location = new System.Drawing.Point(44, 277);
            this.shipCostLbl.Name = "shipCostLbl";
            this.shipCostLbl.Size = new System.Drawing.Size(81, 13);
            this.shipCostLbl.TabIndex = 5;
            this.shipCostLbl.Text = "Shipment Cost: ";
            // 
            // totalCosrLbl
            // 
            this.totalCosrLbl.AutoSize = true;
            this.totalCosrLbl.Location = new System.Drawing.Point(67, 309);
            this.totalCosrLbl.Name = "totalCosrLbl";
            this.totalCosrLbl.Size = new System.Drawing.Size(58, 13);
            this.totalCosrLbl.TabIndex = 6;
            this.totalCosrLbl.Text = "Total Cost:";
            // 
            // disCostLbl
            // 
            this.disCostLbl.AutoSize = true;
            this.disCostLbl.Location = new System.Drawing.Point(34, 239);
            this.disCostLbl.Name = "disCostLbl";
            this.disCostLbl.Size = new System.Drawing.Size(91, 13);
            this.disCostLbl.TabIndex = 7;
            this.disCostLbl.Text = "Discounted Cost: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calculate\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // farmList
            // 
            this.farmList.FormattingEnabled = true;
            this.farmList.Items.AddRange(new object[] {
            "NE",
            "NW",
            "SE",
            "SW"});
            this.farmList.Location = new System.Drawing.Point(142, 52);
            this.farmList.Name = "farmList";
            this.farmList.Size = new System.Drawing.Size(121, 21);
            this.farmList.TabIndex = 9;
            // 
            // itemNumbertxt
            // 
            this.itemNumbertxt.Location = new System.Drawing.Point(142, 84);
            this.itemNumbertxt.Name = "itemNumbertxt";
            this.itemNumbertxt.Size = new System.Drawing.Size(121, 20);
            this.itemNumbertxt.TabIndex = 10;
            // 
            // quantityItemTxt
            // 
            this.quantityItemTxt.Location = new System.Drawing.Point(142, 116);
            this.quantityItemTxt.Name = "quantityItemTxt";
            this.quantityItemTxt.Size = new System.Drawing.Size(121, 20);
            this.quantityItemTxt.TabIndex = 11;
            // 
            // intCostTxt
            // 
            this.intCostTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.intCostTxt.Cursor = System.Windows.Forms.Cursors.No;
            this.intCostTxt.Location = new System.Drawing.Point(142, 209);
            this.intCostTxt.Name = "intCostTxt";
            this.intCostTxt.Size = new System.Drawing.Size(121, 21);
            this.intCostTxt.TabIndex = 12;
            // 
            // disCostTxt
            // 
            this.disCostTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.disCostTxt.Cursor = System.Windows.Forms.Cursors.No;
            this.disCostTxt.Location = new System.Drawing.Point(142, 239);
            this.disCostTxt.Name = "disCostTxt";
            this.disCostTxt.Size = new System.Drawing.Size(121, 21);
            this.disCostTxt.TabIndex = 13;
            // 
            // shipCostTxt
            // 
            this.shipCostTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipCostTxt.Cursor = System.Windows.Forms.Cursors.No;
            this.shipCostTxt.Location = new System.Drawing.Point(142, 276);
            this.shipCostTxt.Name = "shipCostTxt";
            this.shipCostTxt.Size = new System.Drawing.Size(121, 21);
            this.shipCostTxt.TabIndex = 14;
            // 
            // totalCostTxt
            // 
            this.totalCostTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalCostTxt.Cursor = System.Windows.Forms.Cursors.No;
            this.totalCostTxt.Location = new System.Drawing.Point(142, 308);
            this.totalCostTxt.Name = "totalCostTxt";
            this.totalCostTxt.Size = new System.Drawing.Size(121, 21);
            this.totalCostTxt.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 450);
            this.Controls.Add(this.totalCostTxt);
            this.Controls.Add(this.shipCostTxt);
            this.Controls.Add(this.disCostTxt);
            this.Controls.Add(this.intCostTxt);
            this.Controls.Add(this.quantityItemTxt);
            this.Controls.Add(this.itemNumbertxt);
            this.Controls.Add(this.farmList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.disCostLbl);
            this.Controls.Add(this.totalCosrLbl);
            this.Controls.Add(this.shipCostLbl);
            this.Controls.Add(this.intCostLbl);
            this.Controls.Add(this.lbsLbl);
            this.Controls.Add(this.itemLbl);
            this.Controls.Add(this.farmLbl);
            this.Name = "Form1";
            this.Text = "uPickItGrocery Cost Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label farmLbl;
        private System.Windows.Forms.Label itemLbl;
        private System.Windows.Forms.Label lbsLbl;
        private System.Windows.Forms.Label intCostLbl;
        private System.Windows.Forms.Label shipCostLbl;
        private System.Windows.Forms.Label totalCosrLbl;
        private System.Windows.Forms.Label disCostLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox farmList;
        private System.Windows.Forms.TextBox itemNumbertxt;
        private System.Windows.Forms.TextBox quantityItemTxt;
        private System.Windows.Forms.Label intCostTxt;
        private System.Windows.Forms.Label disCostTxt;
        private System.Windows.Forms.Label shipCostTxt;
        private System.Windows.Forms.Label totalCostTxt;
    }
}

