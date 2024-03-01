using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationInformation
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();

            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int y = 1; y <= 12; y++)
            {
                comboBox2.Items.Add(y);
            }
            int year = 1900;
            while (year <= 2024)
            {
                comboBox3.Items.Add(year++);
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

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName, firstName, midName;
            string gender = "";
            int day, month, year;
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

            day = Convert.ToInt32(comboBox1.Text);
            month = Convert.ToInt32(comboBox2.Text);
            year = Convert.ToInt32(comboBox3.Text);

            MessageBox.Show("Student Name: " + firstName + " " + midName + " " + lastName 
                + "\nGender: " + gender 
                + "\nDate of birth: " + day + "/" + month + "/" + year);

        }
    }
}
