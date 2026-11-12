namespace employee_attendance_management_system
{
    partial class Form1
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
            lblemployeeid = new Label();
            lblemployeename = new Label();
            lbldepartment = new Label();
            lblattendance = new Label();
            txtid = new TextBox();
            txtname = new TextBox();
            txtdepartment = new TextBox();
            txtattendance = new TextBox();
            btnrecordattendance = new Button();
            btnview = new Button();
            btnremove = new Button();
            btncount = new Button();
            btnclear = new Button();
            btnexit = new Button();
            rdpresent = new RadioButton();
            rdabsent = new RadioButton();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // lblemployeeid
            // 
            lblemployeeid.AutoSize = true;
            lblemployeeid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblemployeeid.Location = new Point(102, 56);
            lblemployeeid.Name = "lblemployeeid";
            lblemployeeid.Size = new Size(136, 28);
            lblemployeeid.TabIndex = 0;
            lblemployeeid.Text = "employee ID:";
            // 
            // lblemployeename
            // 
            lblemployeename.AutoSize = true;
            lblemployeename.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblemployeename.Location = new Point(91, 103);
            lblemployeename.Name = "lblemployeename";
            lblemployeename.Size = new Size(171, 28);
            lblemployeename.TabIndex = 1;
            lblemployeename.Text = "employee Name:";
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lbldepartment.Location = new Point(109, 150);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(129, 28);
            lbldepartment.TabIndex = 2;
            lbldepartment.Text = "department:";
            // 
            // lblattendance
            // 
            lblattendance.AutoSize = true;
            lblattendance.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblattendance.Location = new Point(139, 220);
            lblattendance.Name = "lblattendance";
            lblattendance.Size = new Size(123, 28);
            lblattendance.TabIndex = 3;
            lblattendance.Text = "attendance:";
            // 
            // txtid
            // 
            txtid.Location = new Point(312, 53);
            txtid.Name = "txtid";
            txtid.Size = new Size(245, 31);
            txtid.TabIndex = 4;
            // 
            // txtname
            // 
            txtname.Location = new Point(312, 100);
            txtname.Name = "txtname";
            txtname.Size = new Size(245, 31);
            txtname.TabIndex = 5;
            // 
            // txtdepartment
            // 
            txtdepartment.Location = new Point(312, 147);
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(245, 31);
            txtdepartment.TabIndex = 6;
            // 
            // txtattendance
            // 
            txtattendance.Location = new Point(296, 202);
            txtattendance.Multiline = true;
            txtattendance.Name = "txtattendance";
            txtattendance.Size = new Size(304, 67);
            txtattendance.TabIndex = 7;
            // 
            // btnrecordattendance
            // 
            btnrecordattendance.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnrecordattendance.Location = new Point(43, 446);
            btnrecordattendance.Name = "btnrecordattendance";
            btnrecordattendance.Size = new Size(182, 64);
            btnrecordattendance.TabIndex = 8;
            btnrecordattendance.Text = "record attendance";
            btnrecordattendance.UseVisualStyleBackColor = true;
            btnrecordattendance.Click += btnrecordattendance_Click;
            // 
            // btnview
            // 
            btnview.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnview.Location = new Point(261, 446);
            btnview.Name = "btnview";
            btnview.Size = new Size(182, 64);
            btnview.TabIndex = 9;
            btnview.Text = "view from file";
            btnview.UseVisualStyleBackColor = true;
            btnview.Click += btnview_Click;
            // 
            // btnremove
            // 
            btnremove.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnremove.Location = new Point(483, 446);
            btnremove.Name = "btnremove";
            btnremove.Size = new Size(182, 64);
            btnremove.TabIndex = 10;
            btnremove.Text = "remove selected";
            btnremove.UseVisualStyleBackColor = true;
            btnremove.Click += btnremove_Click;
            // 
            // btncount
            // 
            btncount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btncount.Location = new Point(710, 446);
            btncount.Name = "btncount";
            btncount.Size = new Size(182, 64);
            btncount.TabIndex = 11;
            btncount.Text = "count records";
            btncount.UseVisualStyleBackColor = true;
            btncount.Click += btncount_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnclear.Location = new Point(918, 446);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(182, 64);
            btnclear.TabIndex = 12;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnexit.Location = new Point(1126, 446);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(182, 64);
            btnexit.TabIndex = 13;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // rdpresent
            // 
            rdpresent.AutoSize = true;
            rdpresent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdpresent.Location = new Point(312, 220);
            rdpresent.Name = "rdpresent";
            rdpresent.Size = new Size(108, 32);
            rdpresent.TabIndex = 14;
            rdpresent.TabStop = true;
            rdpresent.Text = "present";
            rdpresent.UseVisualStyleBackColor = true;
            // 
            // rdabsent
            // 
            rdabsent.AutoSize = true;
            rdabsent.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            rdabsent.Location = new Point(479, 220);
            rdabsent.Name = "rdabsent";
            rdabsent.Size = new Size(100, 32);
            rdabsent.TabIndex = 15;
            rdabsent.TabStop = true;
            rdabsent.Text = "absent";
            rdabsent.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(797, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(437, 404);
            listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 624);
            Controls.Add(listBox1);
            Controls.Add(rdabsent);
            Controls.Add(rdpresent);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btncount);
            Controls.Add(btnremove);
            Controls.Add(btnview);
            Controls.Add(btnrecordattendance);
            Controls.Add(txtattendance);
            Controls.Add(txtdepartment);
            Controls.Add(txtname);
            Controls.Add(txtid);
            Controls.Add(lblattendance);
            Controls.Add(lbldepartment);
            Controls.Add(lblemployeename);
            Controls.Add(lblemployeeid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblemployeeid;
        private Label lblemployeename;
        private Label lbldepartment;
        private Label lblattendance;
        private TextBox txtid;
        private TextBox txtname;
        private TextBox txtdepartment;
        private TextBox txtattendance;
        private Button btnrecordattendance;
        private Button btnview;
        private Button btnremove;
        private Button btncount;
        private Button btnclear;
        private Button btnexit;
        private RadioButton rdpresent;
        private RadioButton rdabsent;
        private ListBox listBox1;
    }
}
