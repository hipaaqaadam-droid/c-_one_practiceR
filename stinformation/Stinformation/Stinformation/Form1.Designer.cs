namespace Stinformation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.studenttype2 = new System.Windows.Forms.GroupBox();
            this.radiopost = new System.Windows.Forms.RadioButton();
            this.radiograduate = new System.Windows.Forms.RadioButton();
            this.txtmark = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblstudentname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.studenttype2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.studenttype2);
            this.groupBox1.Controls.Add(this.txtmark);
            this.groupBox1.Controls.Add(this.txtdepartment);
            this.groupBox1.Controls.Add(this.txtstudentname);
            this.groupBox1.Controls.Add(this.txtstudentid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblstudentname);
            this.groupBox1.Controls.Add(this.lblstudentid);
            this.groupBox1.Location = new System.Drawing.Point(36, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 527);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // studenttype2
            // 
            this.studenttype2.Controls.Add(this.radiopost);
            this.studenttype2.Controls.Add(this.radiograduate);
            this.studenttype2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studenttype2.Location = new System.Drawing.Point(29, 346);
            this.studenttype2.Name = "studenttype2";
            this.studenttype2.Size = new System.Drawing.Size(297, 149);
            this.studenttype2.TabIndex = 33;
            this.studenttype2.TabStop = false;
            this.studenttype2.Text = "student Type";
            // 
            // radiopost
            // 
            this.radiopost.AutoSize = true;
            this.radiopost.Location = new System.Drawing.Point(21, 103);
            this.radiopost.Name = "radiopost";
            this.radiopost.Size = new System.Drawing.Size(198, 33);
            this.radiopost.TabIndex = 9;
            this.radiopost.TabStop = true;
            this.radiopost.Text = "postgratuduate";
            this.radiopost.UseVisualStyleBackColor = true;
            // 
            // radiograduate
            // 
            this.radiograduate.AutoSize = true;
            this.radiograduate.Location = new System.Drawing.Point(21, 53);
            this.radiograduate.Name = "radiograduate";
            this.radiograduate.Size = new System.Drawing.Size(195, 33);
            this.radiograduate.TabIndex = 8;
            this.radiograduate.TabStop = true;
            this.radiograduate.Text = "undergraduate";
            this.radiograduate.UseVisualStyleBackColor = true;
            // 
            // txtmark
            // 
            this.txtmark.Location = new System.Drawing.Point(130, 175);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(340, 26);
            this.txtmark.TabIndex = 7;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(189, 127);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(340, 26);
            this.txtdepartment.TabIndex = 6;
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(189, 80);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(340, 26);
            this.txtstudentname.TabIndex = 5;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(180, 41);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(340, 26);
            this.txtstudentid.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mark:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Department:";
            // 
            // lblstudentname
            // 
            this.lblstudentname.AutoSize = true;
            this.lblstudentname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentname.Location = new System.Drawing.Point(33, 80);
            this.lblstudentname.Name = "lblstudentname";
            this.lblstudentname.Size = new System.Drawing.Size(150, 26);
            this.lblstudentname.TabIndex = 1;
            this.lblstudentname.Text = "student name:";
            // 
            // lblstudentid
            // 
            this.lblstudentid.AutoSize = true;
            this.lblstudentid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstudentid.Location = new System.Drawing.Point(45, 41);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(120, 26);
            this.lblstudentid.TabIndex = 0;
            this.lblstudentid.Text = "Student iD:";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(65, 582);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(188, 40);
            this.btnsave.TabIndex = 41;
            this.btnsave.Text = "save to file";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(650, 582);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 40);
            this.btnexit.TabIndex = 39;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(498, 582);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(139, 40);
            this.btnclear.TabIndex = 38;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(281, 582);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 40);
            this.button1.TabIndex = 40;
            this.button1.Text = "read from file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(610, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(277, 404);
            this.listBox1.TabIndex = 42;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1026, 634);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.studenttype2.ResumeLayout(false);
            this.studenttype2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox studenttype2;
        private System.Windows.Forms.RadioButton radiopost;
        private System.Windows.Forms.RadioButton radiograduate;
        private System.Windows.Forms.TextBox txtmark;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblstudentname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

