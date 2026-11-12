namespace student_information
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtstudentID.Text == "" ||
            txtstudentName.Text == "" ||
            txtdepartment.Text == "" ||
            txtmark.Text == "")
            {
                MessageBox.Show("Please enter all information.");
                return;
            }

            double mark;

            if (!double.TryParse(txtmark.Text, out mark) || mark < 0)
            {
                MessageBox.Show("Enter a valid non-negative mark.");
                return;
            }

            string studentType = rdoundergraduate.Checked
                ? "Undergraduate"
                : "Postgraduate";

            string record = txtstudentID.Text + " | " +
                            txtstudentName.Text + " | " +
                            txtdepartment.Text + " | " +
                            mark + " | " + studentType;

            File.AppendAllText("students.txt", record + Environment.NewLine);

            MessageBox.Show("Student information saved successfully!");
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            if (File.Exists("students.txt"))
            {
                txtsavedinformation.Text = File.ReadAllText("students.txt");
            }
            else
            {
                MessageBox.Show("No saved student records found.");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudentID.Clear();
            txtstudentName.Clear();
            txtdepartment.Clear();
            txtmark.Clear();
            txtsavedinformation.Clear();

            rdoundergraduate.Checked = true;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
