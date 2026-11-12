using System.Runtime.CompilerServices;

namespace employee_attendance_management_system
{
    public partial class Form1 : Form
    {
        string filepath = "attendance.txt";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnrecordattendance_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "" ||
                txtname.Text == "" ||
                txtdepartment.Text == "")
            {
                MessageBox.Show("please fill all fields!");
                return;
            }
            string attendance = "";
            if (rdabsent.Checked)
                attendance = "present";
            else if (rdabsent.Checked)
                attendance = "absent";
            else
            {
                MessageBox.Show("selected attendance!");
                return;
            }
            string record = txtid.Text + "|" +
                txtname.Text + "|" +
                txtdepartment.Text + "|" +
                attendance;
            File.AppendAllText(@"C:\Users\hp\Documents\rahma.txt.txt",record+Environment.NewLine);
            listBox1.Items.Add(record);

            MessageBox.Show("Attendance recorded successfully!");
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            // View From File

            listBox1.Items.Clear();

            if (File.Exists(filepath))
            {
                string[] records = File.ReadAllLines(filepath);

                listBox1.Items.AddRange(records);
            }
            else
            {
                MessageBox.Show("File not found!");
            }
            }
        
        private void btnremove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);

                File.WriteAllLines(
                    filepath,
                    listBox1.Items.Cast<string>());

                MessageBox.Show("Record removed successfully!");
            }
            else
            {
                MessageBox.Show("Please select a record!");
            }
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Records: " + listBox1.Items.Count);

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            txtdepartment.Clear();

            rdpresent.Checked = false;
            rdabsent.Checked = false;

            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

