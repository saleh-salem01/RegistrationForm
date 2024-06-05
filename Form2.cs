using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            int Age = int.Parse(numericUpDown1.Value.ToString());
            string gender = "";
            if (radioButton1.Checked == true)
            {

                gender = radioButton1.Text;
            }
            else if (radioButton2.Checked == true)
            {
                gender = radioButton2.Text;
            }
            List<string> hop = new List<string>();
            if (checkBox1.Checked == true) { hop.Add(checkBox1.Text); }
            if (checkBox2.Checked == true) { hop.Add(checkBox2.Text); }
            if (checkBox3.Checked == true) { hop.Add(checkBox3.Text); }
            if (checkBox4.Checked == true) { hop.Add(checkBox4.Text); }


            int pers = int.Parse( numericUpDown2.Value.ToString());
            progressBar1.Value = pers;

            

            string res = $"Name : {Name} Age : {Age} Gender : {gender} Percentage : {pers} ";
            label4.Text = res;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
