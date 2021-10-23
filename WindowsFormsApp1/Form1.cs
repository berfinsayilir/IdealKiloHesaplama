using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string ad, soyad;
            int yas, boy;
            double ideal_kilo,kilo,sonuc=0;

            ad = textBox1.Text;
            soyad = textBox2.Text;

            yas = Convert.ToInt32(textBox3.Text);
            boy = Convert.ToInt32(textBox4.Text);
            kilo = Convert.ToDouble(textBox6.Text);
            
            double cinsiyet = 0;

            if(comboBox1.Text == "ERKEK")
            {
                cinsiyet = 0.9;
            }
            else
            {
                cinsiyet = 0.8;
            }

            ideal_kilo = ((boy - 100 + yas / 10) * cinsiyet);
            textBox7.Text = ideal_kilo.ToString();
              
                if(ideal_kilo==kilo)
                {
                    label8.Text = "Bravo İdeal kilodasınız.";
                }
                else if (ideal_kilo > kilo)
                {
                    label8.Text = "Zayıfısın" +( ideal_kilo -  kilo)+  " kilo almalısın.";
                   
                }
                 else if (ideal_kilo < kilo)
                {
                    label8.Text = " Şişmansın" + ( kilo  -  ideal_kilo) +  " kilo zayıflamalısın.";

                }  

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text ="" ;
            comboBox1.Text = "";
            label8.Text = "";
        }

    }
}
