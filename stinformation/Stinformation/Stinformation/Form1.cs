using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stinformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int studentID;

            if (!int.TryParse(txtstudentid.Text, out studentID) || studentID < 0)
            {
                MessageBox.Show("Student ID cannot be negative");
                return;
            }
            // create StreamWriter
            StreamWriter writes;

            // create DialogResult
            DialogResult results;

            // show SaveFileDialog
            results = saveFileDialog1.ShowDialog();

            // check user selection
            if (results == DialogResult.OK)
            {
                // create file
                writes = File.CreateText(saveFileDialog1.FileName);

                // write student information
                writes.WriteLine(txtstudentid.Text);
                writes.WriteLine(txtstudentname.Text);
                writes.WriteLine(txtdepartment.Text);
                writes.WriteLine(txtmark.Text);

                // write student type
                if (radiograduate.Checked == true)
                {
                    writes.WriteLine("Undergraduate");
                }
                else if (radiopost.Checked == true)
                {
                    writes.WriteLine("Postgraduate");
                }

                // close file
                writes.Close();

                MessageBox.Show("Student information saved successfully");
            }
            else if (results == DialogResult.Cancel)
            {
                MessageBox.Show("Save operation cancelled");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create StreamReader
            StreamReader reads;

            // create DialogResult
            DialogResult results;

            // show OpenFileDialog
            results = openFileDialog1.ShowDialog();

            // check user selection
            if (results == DialogResult.OK)
            {
                // open the selected file
                reads = File.OpenText(openFileDialog1.FileName);

                // create string variable
                string lines;

                // read file line by line
                while (reads.EndOfStream == false)
                {
                    lines = reads.ReadLine();

                    // add data to ListBox
                    listBox1.Items.Add(lines);
                }

                // close file
                reads.Close();
            }
            else if (results == DialogResult.Cancel)
            {
                MessageBox.Show("Reading operation cancelled");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstudentid.Clear();
            txtstudentname.Clear();
            txtdepartment.Clear();
            txtmark.Clear();
            listBox1.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
    

