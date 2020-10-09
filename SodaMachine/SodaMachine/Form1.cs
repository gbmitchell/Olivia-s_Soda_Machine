using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace SodaMachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.MouseOverBackColor = button14.BackColor;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.MouseOverBackColor = button14.BackColor;
            button29.FlatAppearance.BorderSize = 0;
            button29.FlatAppearance.MouseOverBackColor = button14.BackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.PepsiCanRotate;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.OrangeSodaCanRotate;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackgroundImage = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.PepsiCanRotate;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.PepsiCanRotate;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.RootBeerCanRotate;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.RootBeerCanRotate;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.RootBeerCanRotate;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.OrangeSodaCanRotate;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.OrangeSodaCanRotate;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.GrapeSodaCanRotate;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.GrapeSodaCanRotate;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\SodaCanDispense.wav");
            simpleSound.Play();
            button13.BackgroundImage = SodaMachine.Properties.Resources.GrapeSodaCanRotate;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "1234")
            {
                textBox7.Text = "";
                panel2.Visible = true;
                panel3.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect Password");
                textBox7.Text = "";
                panel3.Visible = false;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\CoinReturn.wav");
            simpleSound.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\gbmit\Documents\VS Projects\SodaMachine\Pics\CoinDrop.wav");
            simpleSound.Play();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }
    }
}
