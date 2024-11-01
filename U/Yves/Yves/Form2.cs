using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yves
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            string dateOfBirth = dateTimePicker1.Value.ToString("d");
            string phone = textBox3.Text;
            string gender = comboBox1.SelectedItem?.ToString();
            string lastSchool = textBox2.Text;
            string preferredCourse = comboBox2.SelectedItem?.ToString();


            string outputMessage = $"Name : {name}\n" +
                                   $"Date of Birth : {dateOfBirth}\n" +
                                   $"Cellphone Number : {phone}\n" +
                                   $"Gender : {gender}\n" +
                                   $"Last School Attended : {lastSchool}\n" +
                                   $"Preferred Course : {preferredCourse}";

            // Output the message to label7
            label7.Text = outputMessage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "  Congratulations on this achievement! Please print this and bring it ";
            label9.Text = message;
            string mess = "to the ICI Registrar to proceed with your next steps. ";
            label14.Text = mess;
            string mes = " See you there our future ICon ♡. ";
            label15.Text = mes;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
