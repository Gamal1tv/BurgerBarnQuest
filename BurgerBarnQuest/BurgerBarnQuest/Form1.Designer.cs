namespace BurgerBarnQuest
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
            this.rbPburger = new System.Windows.Forms.RadioButton();
            this.rbCburger = new System.Windows.Forms.RadioButton();
            this.rbVburger = new System.Windows.Forms.RadioButton();
            this.rbBburger = new System.Windows.Forms.RadioButton();
            this.rbcola = new System.Windows.Forms.RadioButton();
            this.rbtea = new System.Windows.Forms.RadioButton();
            this.rbpunch = new System.Windows.Forms.RadioButton();
            this.rbwater = new System.Windows.Forms.RadioButton();
            this.listborder = new System.Windows.Forms.ListBox();
            this.gboxburgers = new System.Windows.Forms.GroupBox();
            this.gboxdrinks = new System.Windows.Forms.GroupBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btnpurchase = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.gboxsandwiches = new System.Windows.Forms.GroupBox();
            this.rbblt = new System.Windows.Forms.RadioButton();
            this.rbitaliansub = new System.Windows.Forms.RadioButton();
            this.rbturkey = new System.Windows.Forms.RadioButton();
            this.rbchicken = new System.Windows.Forms.RadioButton();
            this.cboxDiscount = new System.Windows.Forms.ComboBox();
            this.gboxburgers.SuspendLayout();
            this.gboxdrinks.SuspendLayout();
            this.gboxsandwiches.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbPburger
            // 
            this.rbPburger.AutoSize = true;
            this.rbPburger.Location = new System.Drawing.Point(18, 33);
            this.rbPburger.Name = "rbPburger";
            this.rbPburger.Size = new System.Drawing.Size(118, 17);
            this.rbPburger.TabIndex = 4;
            this.rbPburger.TabStop = true;
            this.rbPburger.Tag = "4.99";
            this.rbPburger.Text = "Plain Burger ($4.99)";
            this.rbPburger.UseVisualStyleBackColor = true;
            this.rbPburger.CheckedChanged += new System.EventHandler(this.rbPburger_CheckedChanged);
            // 
            // rbCburger
            // 
            this.rbCburger.AutoSize = true;
            this.rbCburger.Location = new System.Drawing.Point(17, 66);
            this.rbCburger.Name = "rbCburger";
            this.rbCburger.Size = new System.Drawing.Size(127, 17);
            this.rbCburger.TabIndex = 5;
            this.rbCburger.TabStop = true;
            this.rbCburger.Tag = "5.99";
            this.rbCburger.Text = "Cheeseburger ($5.99)";
            this.rbCburger.UseVisualStyleBackColor = true;
            this.rbCburger.CheckedChanged += new System.EventHandler(this.rbPburger_CheckedChanged);
            // 
            // rbVburger
            // 
            this.rbVburger.AutoSize = true;
            this.rbVburger.Location = new System.Drawing.Point(18, 102);
            this.rbVburger.Name = "rbVburger";
            this.rbVburger.Size = new System.Drawing.Size(128, 17);
            this.rbVburger.TabIndex = 6;
            this.rbVburger.TabStop = true;
            this.rbVburger.Tag = "6.49";
            this.rbVburger.Text = "Veggie Burger ($6.49)";
            this.rbVburger.UseVisualStyleBackColor = true;
            this.rbVburger.CheckedChanged += new System.EventHandler(this.rbPburger_CheckedChanged);
            // 
            // rbBburger
            // 
            this.rbBburger.AutoSize = true;
            this.rbBburger.Location = new System.Drawing.Point(17, 135);
            this.rbBburger.Name = "rbBburger";
            this.rbBburger.Size = new System.Drawing.Size(126, 17);
            this.rbBburger.TabIndex = 7;
            this.rbBburger.TabStop = true;
            this.rbBburger.Tag = "7.99";
            this.rbBburger.Text = "Bacon Burger ($7.99)";
            this.rbBburger.UseVisualStyleBackColor = true;
            this.rbBburger.CheckedChanged += new System.EventHandler(this.rbPburger_CheckedChanged);
            // 
            // rbcola
            // 
            this.rbcola.AutoSize = true;
            this.rbcola.Location = new System.Drawing.Point(15, 33);
            this.rbcola.Name = "rbcola";
            this.rbcola.Size = new System.Drawing.Size(82, 17);
            this.rbcola.TabIndex = 13;
            this.rbcola.TabStop = true;
            this.rbcola.Tag = "1.29";
            this.rbcola.Text = "Cola ($1.29)";
            this.rbcola.UseVisualStyleBackColor = true;
            this.rbcola.CheckedChanged += new System.EventHandler(this.rbcola_CheckedChanged);
            // 
            // rbtea
            // 
            this.rbtea.AutoSize = true;
            this.rbtea.Location = new System.Drawing.Point(15, 66);
            this.rbtea.Name = "rbtea";
            this.rbtea.Size = new System.Drawing.Size(80, 17);
            this.rbtea.TabIndex = 14;
            this.rbtea.TabStop = true;
            this.rbtea.Tag = "1.19";
            this.rbtea.Text = "Tea ($1.19)";
            this.rbtea.UseVisualStyleBackColor = true;
            this.rbtea.CheckedChanged += new System.EventHandler(this.rbcola_CheckedChanged);
            // 
            // rbpunch
            // 
            this.rbpunch.AutoSize = true;
            this.rbpunch.Location = new System.Drawing.Point(15, 102);
            this.rbpunch.Name = "rbpunch";
            this.rbpunch.Size = new System.Drawing.Size(115, 17);
            this.rbpunch.TabIndex = 15;
            this.rbpunch.TabStop = true;
            this.rbpunch.Tag = "1.09";
            this.rbpunch.Text = "Friut Punch ($1.09)";
            this.rbpunch.UseVisualStyleBackColor = true;
            this.rbpunch.CheckedChanged += new System.EventHandler(this.rbcola_CheckedChanged);
            // 
            // rbwater
            // 
            this.rbwater.AutoSize = true;
            this.rbwater.Location = new System.Drawing.Point(15, 135);
            this.rbwater.Name = "rbwater";
            this.rbwater.Size = new System.Drawing.Size(90, 17);
            this.rbwater.TabIndex = 16;
            this.rbwater.TabStop = true;
            this.rbwater.Tag = "0.99";
            this.rbwater.Text = "Water ($0.99)";
            this.rbwater.UseVisualStyleBackColor = true;
            this.rbwater.CheckedChanged += new System.EventHandler(this.rbcola_CheckedChanged);
            // 
            // listborder
            // 
            this.listborder.FormattingEnabled = true;
            this.listborder.Location = new System.Drawing.Point(12, 207);
            this.listborder.Name = "listborder";
            this.listborder.Size = new System.Drawing.Size(246, 160);
            this.listborder.TabIndex = 19;
            // 
            // gboxburgers
            // 
            this.gboxburgers.Controls.Add(this.rbPburger);
            this.gboxburgers.Controls.Add(this.rbCburger);
            this.gboxburgers.Controls.Add(this.rbVburger);
            this.gboxburgers.Controls.Add(this.rbBburger);
            this.gboxburgers.Location = new System.Drawing.Point(12, 12);
            this.gboxburgers.Name = "gboxburgers";
            this.gboxburgers.Size = new System.Drawing.Size(168, 170);
            this.gboxburgers.TabIndex = 20;
            this.gboxburgers.TabStop = false;
            this.gboxburgers.Text = "Burgers";
            // 
            // gboxdrinks
            // 
            this.gboxdrinks.Controls.Add(this.rbcola);
            this.gboxdrinks.Controls.Add(this.rbtea);
            this.gboxdrinks.Controls.Add(this.rbpunch);
            this.gboxdrinks.Controls.Add(this.rbwater);
            this.gboxdrinks.Location = new System.Drawing.Point(396, 12);
            this.gboxdrinks.Name = "gboxdrinks";
            this.gboxdrinks.Size = new System.Drawing.Size(200, 170);
            this.gboxdrinks.TabIndex = 22;
            this.gboxdrinks.TabStop = false;
            this.gboxdrinks.Text = "Drinks";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(277, 207);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(48, 20);
            this.txttotal.TabIndex = 17;
            // 
            // btnpurchase
            // 
            this.btnpurchase.Location = new System.Drawing.Point(277, 249);
            this.btnpurchase.Name = "btnpurchase";
            this.btnpurchase.Size = new System.Drawing.Size(146, 102);
            this.btnpurchase.TabIndex = 23;
            this.btnpurchase.Text = "Purchase";
            this.btnpurchase.UseVisualStyleBackColor = true;
            this.btnpurchase.Click += new System.EventHandler(this.btnpurchase_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(446, 249);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(146, 102);
            this.btnexit.TabIndex = 24;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // gboxsandwiches
            // 
            this.gboxsandwiches.Controls.Add(this.rbblt);
            this.gboxsandwiches.Controls.Add(this.rbitaliansub);
            this.gboxsandwiches.Controls.Add(this.rbturkey);
            this.gboxsandwiches.Controls.Add(this.rbchicken);
            this.gboxsandwiches.Location = new System.Drawing.Point(190, 12);
            this.gboxsandwiches.Name = "gboxsandwiches";
            this.gboxsandwiches.Size = new System.Drawing.Size(200, 170);
            this.gboxsandwiches.TabIndex = 25;
            this.gboxsandwiches.TabStop = false;
            this.gboxsandwiches.Text = "Sandwiches";
            // 
            // rbblt
            // 
            this.rbblt.AutoSize = true;
            this.rbblt.Location = new System.Drawing.Point(17, 135);
            this.rbblt.Name = "rbblt";
            this.rbblt.Size = new System.Drawing.Size(81, 17);
            this.rbblt.TabIndex = 3;
            this.rbblt.TabStop = true;
            this.rbblt.Tag = "3.49";
            this.rbblt.Text = "BLT ($3.49)";
            this.rbblt.UseVisualStyleBackColor = true;
            this.rbblt.CheckedChanged += new System.EventHandler(this.rbchicken_CheckedChanged);
            // 
            // rbitaliansub
            // 
            this.rbitaliansub.AutoSize = true;
            this.rbitaliansub.Location = new System.Drawing.Point(17, 102);
            this.rbitaliansub.Name = "rbitaliansub";
            this.rbitaliansub.Size = new System.Drawing.Size(111, 17);
            this.rbitaliansub.TabIndex = 2;
            this.rbitaliansub.TabStop = true;
            this.rbitaliansub.Tag = "7.49";
            this.rbitaliansub.Text = "Italian Sub ($7.49)";
            this.rbitaliansub.UseVisualStyleBackColor = true;
            this.rbitaliansub.CheckedChanged += new System.EventHandler(this.rbchicken_CheckedChanged);
            // 
            // rbturkey
            // 
            this.rbturkey.AutoSize = true;
            this.rbturkey.Location = new System.Drawing.Point(17, 66);
            this.rbturkey.Name = "rbturkey";
            this.rbturkey.Size = new System.Drawing.Size(118, 17);
            this.rbturkey.TabIndex = 1;
            this.rbturkey.TabStop = true;
            this.rbturkey.Tag = "5.49";
            this.rbturkey.Text = "Turkey Club ($5.49)";
            this.rbturkey.UseVisualStyleBackColor = true;
            this.rbturkey.CheckedChanged += new System.EventHandler(this.rbchicken_CheckedChanged);
            // 
            // rbchicken
            // 
            this.rbchicken.AutoSize = true;
            this.rbchicken.Location = new System.Drawing.Point(17, 33);
            this.rbchicken.Name = "rbchicken";
            this.rbchicken.Size = new System.Drawing.Size(150, 17);
            this.rbchicken.TabIndex = 0;
            this.rbchicken.TabStop = true;
            this.rbchicken.Tag = "3.99";
            this.rbchicken.Text = "Chicken Sandwich ($3.99)";
            this.rbchicken.UseVisualStyleBackColor = true;
            this.rbchicken.CheckedChanged += new System.EventHandler(this.rbchicken_CheckedChanged);
            // 
            // cboxDiscount
            // 
            this.cboxDiscount.FormattingEnabled = true;
            this.cboxDiscount.Items.AddRange(new object[] {
            "20%",
            "40%",
            "60%"});
            this.cboxDiscount.Location = new System.Drawing.Point(331, 206);
            this.cboxDiscount.Name = "cboxDiscount";
            this.cboxDiscount.Size = new System.Drawing.Size(92, 21);
            this.cboxDiscount.TabIndex = 26;
            this.cboxDiscount.Text = "Discount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 379);
            this.Controls.Add(this.cboxDiscount);
            this.Controls.Add(this.gboxsandwiches);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.gboxdrinks);
            this.Controls.Add(this.btnpurchase);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.gboxburgers);
            this.Controls.Add(this.listborder);
            this.Name = "Form1";
            this.Text = "Burger Barn";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxburgers.ResumeLayout(false);
            this.gboxburgers.PerformLayout();
            this.gboxdrinks.ResumeLayout(false);
            this.gboxdrinks.PerformLayout();
            this.gboxsandwiches.ResumeLayout(false);
            this.gboxsandwiches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbPburger;
        private System.Windows.Forms.RadioButton rbCburger;
        private System.Windows.Forms.RadioButton rbVburger;
        private System.Windows.Forms.RadioButton rbBburger;
        private System.Windows.Forms.RadioButton rbcola;
        private System.Windows.Forms.RadioButton rbtea;
        private System.Windows.Forms.RadioButton rbpunch;
        private System.Windows.Forms.RadioButton rbwater;
        private System.Windows.Forms.ListBox listborder;
        private System.Windows.Forms.GroupBox gboxburgers;
        private System.Windows.Forms.GroupBox gboxdrinks;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btnpurchase;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.GroupBox gboxsandwiches;
        private System.Windows.Forms.RadioButton rbblt;
        private System.Windows.Forms.RadioButton rbitaliansub;
        private System.Windows.Forms.RadioButton rbturkey;
        private System.Windows.Forms.RadioButton rbchicken;
        private System.Windows.Forms.ComboBox cboxDiscount;
    }
}

