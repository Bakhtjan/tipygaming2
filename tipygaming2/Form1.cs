using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tipygaming2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random randomL = new Random();
        Random randomR = new Random();
        int x = 0;
        int y = 0;
        char a = '@';
        private void manis_beriw()
        {
            x = randomL.Next(1, 700);
            a = (char)randomR.Next(97, 122);
            label1.Location = new Point(x, 0);
            label1.Text = a.ToString();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

     /*   private void button1_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            manis_beriw();
            timer1.Start();


        }*/

       /* private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == label1.Text)
            {
                manis_beriw();
                y = 0;
            }

        }*/
        int minut = 0;
        int sekunt = 0;
       /* private void timer1_Tick(object sender, EventArgs e)
        {
            y += 5;
            label1.Location = new Point(x, y);
            if (label1.Location.Y > 530)
            {
                manis_beriw();
                y = 0;
            }

            if (sekunt == 60)
            {
                minut++;
                sekunt = 0;
            }
            else
            {
                sekunt++;
            }

            label3.Text = "00" + ":" + "" + minut.ToString();
        }*/



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            y += 8;
            label1.Location = new Point(x, y);
            if (label1.Location.Y > 460)
            {
                manis_beriw();
                y = 0;
            }

            if (sekunt == 60)
            {
                minut++;
                sekunt = 0;
            }
            else
            {
                sekunt++;
            }

            label3.Text = "00" + ":" + "" + minut.ToString();
        }

        private void button1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar.ToString() == label1.Text)
                {
                    manis_beriw();
                    y = 0;
                }

            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            panel2.Visible = false;
            manis_beriw();
            timer1.Start();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
