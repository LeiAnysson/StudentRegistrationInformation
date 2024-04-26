using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();

            string[] monthList = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }
            foreach (string months in monthList)
            {
                comboBox2.Items.Add(months);
            }
            int year = 1900;
            while (year <= 2024)
            {
                comboBox3.Items.Add(year++);
            }
            ArrayList programList = new ArrayList();
            programList.Add("Bachelor of Science in Computer Science");
            programList.Add("Bachelor of Science in Information Technology");
            programList.Add("Bachelor of Science in Information Systems");
            programList.Add("Bachelor of Science in Computer Engineering");
            foreach (string programs in programList)
            {
                comboBox4.Items.Add(programs);
            }
        }

        private void frmStudentRegistration_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        ///
        private void message(string lastName, string firstName, string midName, string gender, string day, string month, string year, string program)
        {
            MessageBox.Show("Student Name: " + firstName + " " + midName + " " + lastName
                + "\nGender: " + gender
                + "\nDate of birth: " + day + "/" + month + "/" + year
                + "\nProgram: " + program);

        }
        private void messageBox(string lastName, string firstName, string midName, string program)
        {
            MessageBox.Show("Student Name: " + firstName + " " + midName + " " + lastName
                + "\nProgram: " + program);
        }
        private void messageBox(string lastName, string firstName, string midName, string day, string month, string year, string program)
        {
            MessageBox.Show("Student Name: " + firstName + " " + midName + " " + lastName
                + "\nDate of birth: " + day + "/" + month + "/" + year
                + "\nProgram: " + program);
        }
        private void messageBox(string lastName, string firstName, string midName, string gender, string program)
        {
            MessageBox.Show("Student Name: " + firstName + " " + midName + " " + lastName
                + "\nGender: " + gender
                + "\nProgram: " + program);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName, firstName, midName, program, month, day, year;
            string gender = "";
            lastName = textBox1.Text;
            firstName = textBox2.Text;
            midName = textBox3.Text;

            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }

            day = comboBox1.Text;
            month = comboBox2.Text;
            year = comboBox3.Text;
            program = comboBox4.Text;

            if (lastName != null && firstName != null && midName != null && day != "-Day-" && month != "-Month-" && year != "-Year-" && program != null && !radioButton1.Checked && !radioButton2.Checked)
            {
                messageBox(lastName, firstName, midName, day, month, year, program);
            }
            else if (lastName != null && firstName != null && midName != null && gender != null && day != "-Day-" && month != "-Month-" && year != "-Year-" && program != null)
            {
                message(lastName, firstName, midName, gender, day, month, year, program);
            }
            else if (lastName != null && firstName != null && midName != null && program != null && !radioButton1.Checked && !radioButton2.Checked)
            {
                messageBox(lastName, firstName, midName, program);
            }
            else if (lastName != null && firstName != null && midName != null && gender != null && program != null)
            {
                messageBox(lastName, firstName, midName, gender, program);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "";
            openFileDialog1.Title = "Open Files";
            openFileDialog1.ShowDialog();
             pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
        }
    }
}
