namespace hotelrombooking
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
            this.lblguestname = new System.Windows.Forms.Label();
            this.lblroomtype = new System.Windows.Forms.Label();
            this.lblnights = new System.Windows.Forms.Label();
            this.lblpricenight = new System.Windows.Forms.Label();
            this.txtguestname = new System.Windows.Forms.TextBox();
            this.txtroomtype = new System.Windows.Forms.TextBox();
            this.txtnights = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lbldiscount = new System.Windows.Forms.Label();
            this.lblservicetax = new System.Windows.Forms.Label();
            this.lbltotalamount = new System.Windows.Forms.Label();
            this.lbldiscountamount = new System.Windows.Forms.Label();
            this.lblsevicetax = new System.Windows.Forms.Label();
            this.btncalculatebooking = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblguestname
            // 
            this.lblguestname.AutoSize = true;
            this.lblguestname.Location = new System.Drawing.Point(89, 40);
            this.lblguestname.Name = "lblguestname";
            this.lblguestname.Size = new System.Drawing.Size(134, 20);
            this.lblguestname.TabIndex = 0;
            this.lblguestname.Text = "enter guest name";
            // 
            // lblroomtype
            // 
            this.lblroomtype.AutoSize = true;
            this.lblroomtype.Location = new System.Drawing.Point(89, 80);
            this.lblroomtype.Name = "lblroomtype";
            this.lblroomtype.Size = new System.Drawing.Size(120, 20);
            this.lblroomtype.TabIndex = 1;
            this.lblroomtype.Text = "enter room type";
            // 
            // lblnights
            // 
            this.lblnights.AutoSize = true;
            this.lblnights.Location = new System.Drawing.Point(89, 111);
            this.lblnights.Name = "lblnights";
            this.lblnights.Size = new System.Drawing.Size(169, 20);
            this.lblnights.TabIndex = 2;
            this.lblnights.Text = "enter number of nights";
            // 
            // lblpricenight
            // 
            this.lblpricenight.AutoSize = true;
            this.lblpricenight.Location = new System.Drawing.Point(89, 147);
            this.lblpricenight.Name = "lblpricenight";
            this.lblpricenight.Size = new System.Drawing.Size(150, 20);
            this.lblpricenight.TabIndex = 3;
            this.lblpricenight.Text = "enter price per night";
            // 
            // txtguestname
            // 
            this.txtguestname.Location = new System.Drawing.Point(390, 23);
            this.txtguestname.Name = "txtguestname";
            this.txtguestname.Size = new System.Drawing.Size(179, 26);
            this.txtguestname.TabIndex = 4;
            // 
            // txtroomtype
            // 
            this.txtroomtype.Location = new System.Drawing.Point(390, 74);
            this.txtroomtype.Name = "txtroomtype";
            this.txtroomtype.Size = new System.Drawing.Size(179, 26);
            this.txtroomtype.TabIndex = 5;
            // 
            // txtnights
            // 
            this.txtnights.Location = new System.Drawing.Point(390, 111);
            this.txtnights.Name = "txtnights";
            this.txtnights.Size = new System.Drawing.Size(179, 26);
            this.txtnights.TabIndex = 6;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(390, 147);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(179, 26);
            this.txtprice.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltotal);
            this.groupBox1.Controls.Add(this.lbltotalamount);
            this.groupBox1.Controls.Add(this.lbldiscountamount);
            this.groupBox1.Controls.Add(this.lbldiscount);
            this.groupBox1.Controls.Add(this.lblsevicetax);
            this.groupBox1.Controls.Add(this.lblservicetax);
            this.groupBox1.Location = new System.Drawing.Point(22, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 143);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbltotal.Location = new System.Drawing.Point(387, 98);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(169, 20);
            this.lbltotal.TabIndex = 6;
            this.lbltotal.Text = "                                        ";
            // 
            // lbldiscount
            // 
            this.lbldiscount.AutoSize = true;
            this.lbldiscount.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbldiscount.Location = new System.Drawing.Point(387, 60);
            this.lbldiscount.Name = "lbldiscount";
            this.lbldiscount.Size = new System.Drawing.Size(189, 20);
            this.lbldiscount.TabIndex = 5;
            this.lbldiscount.Text = "                                             ";
            // 
            // lblservicetax
            // 
            this.lblservicetax.AutoSize = true;
            this.lblservicetax.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblservicetax.Location = new System.Drawing.Point(387, 22);
            this.lblservicetax.Name = "lblservicetax";
            this.lblservicetax.Size = new System.Drawing.Size(189, 20);
            this.lblservicetax.TabIndex = 4;
            this.lblservicetax.Text = "                                             ";
            // 
            // lbltotalamount
            // 
            this.lbltotalamount.AutoSize = true;
            this.lbltotalamount.Location = new System.Drawing.Point(67, 98);
            this.lbltotalamount.Name = "lbltotalamount";
            this.lbltotalamount.Size = new System.Drawing.Size(98, 20);
            this.lbltotalamount.TabIndex = 3;
            this.lbltotalamount.Text = "total amount";
            // 
            // lbldiscountamount
            // 
            this.lbldiscountamount.AutoSize = true;
            this.lbldiscountamount.Location = new System.Drawing.Point(67, 60);
            this.lbldiscountamount.Name = "lbldiscountamount";
            this.lbldiscountamount.Size = new System.Drawing.Size(127, 20);
            this.lbldiscountamount.TabIndex = 2;
            this.lbldiscountamount.Text = "discount amount";
            // 
            // lblsevicetax
            // 
            this.lblsevicetax.AutoSize = true;
            this.lblsevicetax.Location = new System.Drawing.Point(76, 22);
            this.lblsevicetax.Name = "lblsevicetax";
            this.lblsevicetax.Size = new System.Drawing.Size(83, 20);
            this.lblsevicetax.TabIndex = 1;
            this.lblsevicetax.Text = "service tax";
            // 
            // btncalculatebooking
            // 
            this.btncalculatebooking.Location = new System.Drawing.Point(228, 196);
            this.btncalculatebooking.Name = "btncalculatebooking";
            this.btncalculatebooking.Size = new System.Drawing.Size(239, 78);
            this.btncalculatebooking.TabIndex = 9;
            this.btncalculatebooking.Text = "calculate booking";
            this.btncalculatebooking.UseVisualStyleBackColor = true;
            this.btncalculatebooking.Click += new System.EventHandler(this.btncalculatebooking_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalculatebooking);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtnights);
            this.Controls.Add(this.txtroomtype);
            this.Controls.Add(this.txtguestname);
            this.Controls.Add(this.lblpricenight);
            this.Controls.Add(this.lblnights);
            this.Controls.Add(this.lblroomtype);
            this.Controls.Add(this.lblguestname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblguestname;
        private System.Windows.Forms.Label lblroomtype;
        private System.Windows.Forms.Label lblnights;
        private System.Windows.Forms.Label lblpricenight;
        private System.Windows.Forms.TextBox txtguestname;
        private System.Windows.Forms.TextBox txtroomtype;
        private System.Windows.Forms.TextBox txtnights;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lbldiscount;
        private System.Windows.Forms.Label lblservicetax;
        private System.Windows.Forms.Label lbltotalamount;
        private System.Windows.Forms.Label lbldiscountamount;
        private System.Windows.Forms.Label lblsevicetax;
        private System.Windows.Forms.Button btncalculatebooking;
    }
}

