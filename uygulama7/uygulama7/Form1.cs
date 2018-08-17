using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uygulama7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        Random a = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {

            int s1 = Convert.ToInt32(label10.Text);
            int b = Convert.ToInt32(textBox1.Text);

            int bir = pictureBox1.Left;
            int iki = pictureBox2.Left;
            int uc = pictureBox3.Left;
            int birboy = pictureBox1.Width;
            int ikiboy = pictureBox2.Width;
            int ucboy = pictureBox3.Width;
            pictureBox1.Left = pictureBox1.Left + a.Next(3, 13);
            pictureBox2.Left = pictureBox2.Left + a.Next(3, 13);
            pictureBox3.Left = pictureBox3.Left + a.Next(3, 13);
            int bitis = label4.Left;
            if (pictureBox1.Left + pictureBox1.Width > bitis)
            {

                timer1.Stop();

                MessageBox.Show("WiN FİRST HORSE");
                pictureBox1.Location = new Point(0, 9);
                pictureBox2.Location = new Point(0, 103);
                pictureBox3.Location = new Point(0, 207);
                groupBox1.Visible = true;

                if (radioButton1.Checked == true)
                {
                    label10.Text = hesapla(s1, b).ToString();
                }

            }
            if (pictureBox2.Left + pictureBox2.Width > bitis)
            {


                timer1.Stop();

                MessageBox.Show("WiN SECOND HORSE");
                pictureBox1.Location = new Point(0, 9);
                pictureBox2.Location = new Point(0, 103);
                pictureBox3.Location = new Point(0, 207);
                groupBox1.Visible = true;
                if (radioButton2.Checked == true)
                {
                    label10.Text = hesapla(s1, b).ToString();
                }

            }
            if (pictureBox3.Left + pictureBox3.Width > bitis)
            {

                timer1.Stop();

                MessageBox.Show("WiN THİRD HORSE");
                pictureBox1.Location = new Point(0, 9);
                pictureBox2.Location = new Point(0, 103);
                pictureBox3.Location = new Point(0, 207);
                groupBox1.Visible = true;
                if (radioButton3.Checked == true)
                {
                    label10.Text = hesapla(s1, b).ToString();
                }

            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            string a = textBox1.Text;
         int bahis1 = Convert.ToInt32(label10.Text);
            int bahis2 = Convert.ToInt32(textBox1.Text);

            if (textBox1.Text == "0")
            {
                MessageBox.Show("You did not deposit money!");
            }
            else
            {
               
             
                if (bahis2 <= bahis1)
                {
                 MessageBox.Show("Your bet is played: " + textBox1.Text + "$" + "\n" + "Wallet: " + label10.Text + "$");
                    timer1.Start();
                    groupBox1.Visible = false;



                    bahis1 = bahis1 - bahis2;
                    label10.Text = bahis1.ToString();
           SoundPlayer vol = new SoundPlayer("at.wav");
                vol.Play();
                }
                else
                {
                   MessageBox.Show("Inadequate  wallet");
                   
                }

            }
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        public int hesapla(int b, int c)
        {

            return c * 2 + b;



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Orange;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {

            label6.ForeColor = Color.Black;
        }
    }
}

//BY Eco.Quake
