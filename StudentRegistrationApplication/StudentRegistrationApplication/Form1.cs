using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        private object i;
        private string gender;
        public Form1()
        {
            InitializeComponent();

            ArrayList course = new ArrayList();
            course.Add("Bachelor of Science in Computer Science");
            course.Add("Bachelor of Science in Information Technology");
            course.Add("Bachelor of Science in Information Systems");
            course.Add("Bachelor of Science in Computer Engineering");

            foreach (string program in course)
            {
                comboBox4.Items.Add(program);
            }

            for (int i = 1900; i <= DateTime.Today.Year; i++)
            {
                comboBox3.Items.Add(i);           
            }
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }
            for (int i = 1; i <= 12; i++)
            {
                 comboBox2.Items.Add(i);
            }

           


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fName = textBox1.Text;
            string mName = textBox2.Text;
            string lName = textBox3.Text;
            string program =  comboBox4.Text;
            string days = comboBox1.Text;
            string months = comboBox2.Text;
            string years = comboBox3.Text;
            string gender = null;
                
            if (radioButton1.Checked == true)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                gender = "Female";
            }

            if (comboBox2.Text.Equals("-Month-") && comboBox1.Text.Equals("-Day-") && comboBox3.Text.Equals("-Year-"))
            {
                if (!radioButton1.Checked && !radioButton2.Checked)
                {
                   Message(mName, lName, fName, program);
                }
                else if (radioButton1.Checked || radioButton2.Checked)
                {
                    Message(mName, lName, fName, program, gender);
                }


            }
            else
            {
                    Message(mName, lName, fName, program, gender, days, months, years);
            }
        }

  

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            OpenFileDialog openpic = new OpenFileDialog();
            openpic.ShowDialog(this);
            if (openpic.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Bitmap.FromFile(openpic.FileName);
            }


        }
        public void Message(string mName, string lName, string fName, string program)
        {
            MessageBox.Show("Student Name: " + fName + " " + mName + " " + lName
                + "\nProgram: " + comboBox4.Text);
        }
        public void Message(string lName, string fName, string program)
        {
            MessageBox.Show("Student Name: " + fName + " " + lName
                + "\nProgram: " + comboBox4.Text);
        }

        public void Message(string mName, string lName, string fName, string program, string gender)
        {
            MessageBox.Show("Student Name: " + fName + " " + mName + " " + lName
                + "\nGender: " + gender
                + "\nProgram: " + comboBox4.Text);
        }
        public void Message(string mName, string lName, string fName, string program, string gender, string day, string month, string year)
        {
            MessageBox.Show("Student Name: " + fName + " " + mName + " " + lName
                + "\nGender: " + gender
                + "\nBirth of day: " + day + "/" + month + "/" + year
                + "\nProgram: " + comboBox4.Text);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
    