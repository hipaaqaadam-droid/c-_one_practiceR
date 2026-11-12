namespace student_information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblstudentID = new Label();
            lblstudentName = new Label();
            lbldepartment = new Label();
            lblmark = new Label();
            txtstudentID = new TextBox();
            txtstudentName = new TextBox();
            txtdepartment = new TextBox();
            txtmark = new TextBox();
            grpstudentType = new GroupBox();
            rdopostgraduate = new RadioButton();
            rdoundergraduate = new RadioButton();
            grpsavedstudentinformation = new GroupBox();
            btnsave = new Button();
            btnread = new Button();
            btnclear = new Button();
            btnexit = new Button();
            txtsavedinformation = new TextBox();
            listBox1 = new ListBox();
            grpstudentType.SuspendLayout();
            SuspendLayout();
            // 
            // lblstudentID
            // 
            lblstudentID.AutoSize = true;
            lblstudentID.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblstudentID.Location = new Point(114, 25);
            lblstudentID.Name = "lblstudentID";
            lblstudentID.Size = new Size(106, 25);
            lblstudentID.TabIndex = 0;
            lblstudentID.Text = "student ID:";
            // 
            // lblstudentName
            // 
            lblstudentName.AutoSize = true;
            lblstudentName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblstudentName.Location = new Point(114, 81);
            lblstudentName.Name = "lblstudentName";
            lblstudentName.Size = new Size(137, 25);
            lblstudentName.TabIndex = 1;
            lblstudentName.Text = "student Name:";
            // 
            // lbldepartment
            // 
            lbldepartment.AutoSize = true;
            lbldepartment.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbldepartment.Location = new Point(114, 136);
            lbldepartment.Name = "lbldepartment";
            lbldepartment.Size = new Size(118, 25);
            lbldepartment.TabIndex = 2;
            lbldepartment.Text = "department:";
            // 
            // lblmark
            // 
            lblmark.AutoSize = true;
            lblmark.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblmark.Location = new Point(108, 191);
            lblmark.Name = "lblmark";
            lblmark.Size = new Size(61, 25);
            lblmark.TabIndex = 3;
            lblmark.Text = "mark:";
            // 
            // txtstudentID
            // 
            txtstudentID.Location = new Point(284, 27);
            txtstudentID.Name = "txtstudentID";
            txtstudentID.Size = new Size(150, 31);
            txtstudentID.TabIndex = 4;
            // 
            // txtstudentName
            // 
            txtstudentName.Location = new Point(284, 75);
            txtstudentName.Name = "txtstudentName";
            txtstudentName.Size = new Size(150, 31);
            txtstudentName.TabIndex = 5;
            // 
            // txtdepartment
            // 
            txtdepartment.Location = new Point(284, 127);
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(150, 31);
            txtdepartment.TabIndex = 6;
            // 
            // txtmark
            // 
            txtmark.Location = new Point(284, 185);
            txtmark.Name = "txtmark";
            txtmark.Size = new Size(150, 31);
            txtmark.TabIndex = 7;
            // 
            // grpstudentType
            // 
            grpstudentType.Controls.Add(rdopostgraduate);
            grpstudentType.Controls.Add(rdoundergraduate);
            grpstudentType.Location = new Point(26, 255);
            grpstudentType.Name = "grpstudentType";
            grpstudentType.Size = new Size(621, 165);
            grpstudentType.TabIndex = 8;
            grpstudentType.TabStop = false;
            grpstudentType.Text = "student Type";
            // 
            // rdopostgraduate
            // 
            rdopostgraduate.AutoSize = true;
            rdopostgraduate.Location = new Point(357, 80);
            rdopostgraduate.Name = "rdopostgraduate";
            rdopostgraduate.Size = new Size(144, 29);
            rdopostgraduate.TabIndex = 1;
            rdopostgraduate.TabStop = true;
            rdopostgraduate.Text = "postgraduate";
            rdopostgraduate.UseVisualStyleBackColor = true;
            // 
            // rdoundergraduate
            // 
            rdoundergraduate.AutoSize = true;
            rdoundergraduate.Location = new Point(52, 80);
            rdoundergraduate.Name = "rdoundergraduate";
            rdoundergraduate.Size = new Size(154, 29);
            rdoundergraduate.TabIndex = 0;
            rdoundergraduate.TabStop = true;
            rdoundergraduate.Text = "undergraduate";
            rdoundergraduate.UseVisualStyleBackColor = true;
            // 
            // grpsavedstudentinformation
            // 
            grpsavedstudentinformation.Location = new Point(710, 295);
            grpsavedstudentinformation.Name = "grpsavedstudentinformation";
            grpsavedstudentinformation.Size = new Size(440, 173);
            grpsavedstudentinformation.TabIndex = 9;
            grpsavedstudentinformation.TabStop = false;
            grpsavedstudentinformation.Text = "saved student information";
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnsave.Location = new Point(30, 475);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(201, 90);
            btnsave.TabIndex = 10;
            btnsave.Text = "save to file";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnread
            // 
            btnread.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnread.Location = new Point(274, 481);
            btnread.Name = "btnread";
            btnread.Size = new Size(182, 78);
            btnread.TabIndex = 11;
            btnread.Text = "read from file";
            btnread.UseVisualStyleBackColor = true;
            btnread.Click += btnread_Click;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnclear.Location = new Point(492, 481);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(179, 74);
            btnclear.TabIndex = 12;
            btnclear.Text = "clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnexit
            // 
            btnexit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnexit.Location = new Point(721, 489);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(167, 70);
            btnexit.TabIndex = 13;
            btnexit.Text = "exit";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // txtsavedinformation
            // 
            txtsavedinformation.Location = new Point(710, 242);
            txtsavedinformation.Name = "txtsavedinformation";
            txtsavedinformation.Size = new Size(487, 31);
            txtsavedinformation.TabIndex = 14;
            txtsavedinformation.Text = resources.GetString("txtsavedinformation.Text");
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(665, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(551, 229);
            listBox1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 613);
            Controls.Add(listBox1);
            Controls.Add(txtsavedinformation);
            Controls.Add(btnexit);
            Controls.Add(btnclear);
            Controls.Add(btnread);
            Controls.Add(btnsave);
            Controls.Add(grpsavedstudentinformation);
            Controls.Add(grpstudentType);
            Controls.Add(txtmark);
            Controls.Add(txtdepartment);
            Controls.Add(txtstudentName);
            Controls.Add(txtstudentID);
            Controls.Add(lblmark);
            Controls.Add(lbldepartment);
            Controls.Add(lblstudentName);
            Controls.Add(lblstudentID);
            Name = "Form1";
            Text = "Form1";
            grpstudentType.ResumeLayout(false);
            grpstudentType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblstudentID;
        private Label lblstudentName;
        private Label lbldepartment;
        private Label lblmark;
        private TextBox txtstudentID;
        private TextBox txtstudentName;
        private TextBox txtdepartment;
        private TextBox txtmark;
        private GroupBox grpstudentType;
        private RadioButton rdoundergraduate;
        private RadioButton rdopostgraduate;
        private GroupBox grpsavedstudentinformation;
        private Button btnsave;
        private Button btnread;
        private Button btnclear;
        private Button btnexit;
        private TextBox txtsavedinformation;
        private ListBox listBox1;
    }
}
