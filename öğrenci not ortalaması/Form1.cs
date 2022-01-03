using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace öğrenci_not_ortalaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad,numara;
            int s1, s2, s3;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            numara = textBox3.Text;
            s1 = Convert.ToInt16(textBox4.Text);
            s2 = Convert.ToInt16(textBox5.Text);
            s3 = Convert.ToInt16(textBox6.Text);
            ortalama = (s1 + s2 + s3) / 3;
            MessageBox.Show("Ad: " + ad + "\n" + "Soyad: " + soyad + "\n" + "Ortalama: " + ortalama);

        }
    }
}
