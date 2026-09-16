using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppDotNet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Üdvözöllek " + vnev.Text + " ! ");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Vezetéknév:" + vnev.Text + "\n" +
                            "Keresztnév:" + knev.Text + "\n" +
                            "E-mail:" + email.Text + "\n" +
                            "Telefonszám:" + telszam.Text + "\n" +
                            "Kor:" + kor.Text + "\n" +
                            "Férfi" + radioButton1.Checked + "\n" +
                            "Nő" + radioButton2.Checked + "\n" +
                            "Értesitls" + checkBox1.Checked);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
