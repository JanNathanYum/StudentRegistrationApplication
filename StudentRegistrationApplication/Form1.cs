using System;
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

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        private object i;
        private string gender;
        public Form1()
        {
            InitializeComponent();

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

            string days = comboBox1.Text;
            string months = comboBox2.Text;
            string years = comboBox3.Text;

            
            if (radioButton1.Checked == true)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }

            MessageBox.Show("Student Name: " +fName+
                " " +mName+ " " +lName+
                "\nGender: "+gender+
                "\nDate of birth: "+days+"/"+months+"/"+years+"");
            


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
    }
}
